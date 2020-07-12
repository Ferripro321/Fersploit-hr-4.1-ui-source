using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Relase_1._0_fersploit
{
    internal class Injector
    {
        public enum DllInjectionResult
        {
            DllNotFound,
            GameProcessNotFound,
            InjectionFailed,
            Success
        }

        public sealed class DllInjector
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern int CloseHandle(IntPtr hObject);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);


            public static Injector.DllInjector GetInstance
            {
                get
                {
                    bool flag = Injector.DllInjector._instance == null;
                    if (flag)
                    {
                        Injector.DllInjector._instance = new Injector.DllInjector();
                    }
                    return Injector.DllInjector._instance;
                }
            }

            private DllInjector()
            {
            }

            public Injector.DllInjectionResult Inject(string sProcName, string sDllPath)
            {
                bool flag = !File.Exists(sDllPath);
                Injector.DllInjectionResult result;
                if (flag)
                {
                    result = Injector.DllInjectionResult.DllNotFound;
                }
                else
                {
                    uint num = 0U;
                    Process[] processes = Process.GetProcesses();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        bool flag2 = processes[i].ProcessName == sProcName;
                        if (flag2)
                        {
                            num = (uint)processes[i].Id;
                            break;
                        }
                    }
                    bool flag3 = num == 0U;
                    if (flag3)
                    {
                        result = Injector.DllInjectionResult.GameProcessNotFound;
                    }
                    else
                    {
                        bool flag4 = !this.bInject(num, sDllPath);
                        if (flag4)
                        {
                            result = Injector.DllInjectionResult.InjectionFailed;
                        }
                        else
                        {
                            result = Injector.DllInjectionResult.Success;
                        }
                    }
                }
                return result;
            }

            private bool bInject(uint pToBeInjected, string sDllPath)
            {
                IntPtr intPtr = Injector.DllInjector.OpenProcess(1082U, 1, pToBeInjected);
                bool flag = intPtr == Injector.DllInjector.INTPTR_ZERO;
                bool result;
                if (flag)
                {
                    result = false;
                }
                else
                {
                    IntPtr procAddress = Injector.DllInjector.GetProcAddress(Injector.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                    bool flag2 = procAddress == Injector.DllInjector.INTPTR_ZERO;
                    if (flag2)
                    {
                        result = false;
                    }
                    else
                    {
                        IntPtr intPtr2 = Injector.DllInjector.VirtualAllocEx(intPtr, (IntPtr)null, (IntPtr)sDllPath.Length, 12288U, 64U);
                        bool flag3 = intPtr2 == Injector.DllInjector.INTPTR_ZERO;
                        if (flag3)
                        {
                            result = false;
                        }
                        else
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
                            bool flag4 = Injector.DllInjector.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0;
                            if (flag4)
                            {
                                result = false;
                            }
                            else
                            {
                                bool flag5 = Injector.DllInjector.CreateRemoteThread(intPtr, (IntPtr)null, Injector.DllInjector.INTPTR_ZERO, procAddress, intPtr2, 0U, (IntPtr)null) == Injector.DllInjector.INTPTR_ZERO;
                                if (flag5)
                                {
                                    result = false;
                                }
                                else
                                {
                                    Injector.DllInjector.CloseHandle(intPtr);
                                    result = true;
                                }
                            }
                        }
                    }
                }
                return result;
            }

            private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

            private static Injector.DllInjector _instance;
        }
    }
}
