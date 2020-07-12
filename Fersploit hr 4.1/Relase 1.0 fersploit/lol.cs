using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Relase_1._0_fersploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32", EntryPoint = "GetModuleHandleA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetModuleHandle([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, uint lpNumberOfBytesWritten);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WaitForSingleObject(int hHandle, int dwMilliseconds);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int CloseHandle(int hObject);

        private bool Inject(int pID, string dllLocation)
        {
            int num1 = Form1.OpenProcess(2035711, 1, pID);
            bool flag;
            if (num1 == 0)
            {
                flag = false;
            }
            else
            {
                byte[] bytes = Encoding.ASCII.GetBytes(dllLocation);
                int num2 = Form1.VirtualAllocEx(num1, 0, bytes.Length, 4096, 4);
                if (num2 == 0)
                {
                    flag = false;
                }
                else
                {
                    string lpModuleName = "kernel32.dll";
                    int moduleHandle = Form1.GetModuleHandle(ref lpModuleName);
                    string lpProcName = "LoadLibraryA";
                    int procAddress = Form1.GetProcAddress(moduleHandle, ref lpProcName);
                    if (moduleHandle == 0 || procAddress == 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        Form1.WriteProcessMemory(num1, num2, bytes, bytes.Length, 0U);
                        int remoteThread = Form1.CreateRemoteThread(num1, 0, 0, procAddress, num2, 0, 0);
                        if (remoteThread == 0)
                        {
                            flag = false;
                        }
                        else
                        {
                            Form1.WaitForSingleObject(remoteThread, 5000);
                            Form1.CloseHandle(remoteThread);
                            Form1.CloseHandle(num1);
                            flag = true;
                        }
                    }
                }
            }
            return flag;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\SkisploitAPIModule.dll"))
            {
                try
                {
                    string dllLocation = Path.Combine(Directory.GetCurrentDirectory(), "SkisploitAPIModule.dll");
                    try
                    {
                        this.Inject(Process.GetProcessesByName("RobloxPlayerBeta")[0].Id, dllLocation);
                        
                    }
                    catch
                    {
                        int num = (int)MessageBox.Show("RobloxPlayerBeta is not running!");
                    }
                }
                catch
                {
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("SkisploitAPIModule.dll Cannot Be Found!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string text = ((Control)this.fastColoredTextBox1).Text;
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
            {
                int num1 = (int)MessageBox.Show("Please open Roblox To Execute The Script");
            }
            else
            {
                using (NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(".", "9w49yJgL5Vg8VHwHvxZNtBAb", PipeDirection.Out))
                {
                    pipeClientStream.Connect();
                    using (StreamWriter streamWriter = new StreamWriter((Stream)pipeClientStream))
                    {
                        streamWriter.Write(text);
                        streamWriter.Dispose();
                    }
                    pipeClientStream.Dispose();
                    
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FastColoredTextBox1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Main_inglesa main = new Main_inglesa();
            main.Show();
            this.Hide();
        }

        private void FastColoredTextBox1_Load_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FlatMini1_Click(object sender, EventArgs e)
        {

        }

        private void FlatClose1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = (richTextBox1.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = (richTextBox2.Text);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\TSMK2.dll"))
            {
                try
                {
                    string dllLocation = Path.Combine(Directory.GetCurrentDirectory(), "TSMK2.dll");
                    try
                    {
                        this.Inject(Process.GetProcessesByName("RobloxPlayerBeta")[0].Id, dllLocation);

                    }
                    catch
                    {
                        int num = (int)MessageBox.Show("RobloxPlayerBeta is not running!");
                    }
                }
                catch
                {
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("TSMK2.dll Cannot Be Found!");
            }
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
    }


     

