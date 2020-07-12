using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Relase_1._0_fersploit;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.IO.Pipes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        int mov;
        int movX;
        int movY;
        
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

        // Token: 0x0600001A RID: 26
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

        // Token: 0x0600001B RID: 27
        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetModuleHandleA", SetLastError = true)]
        private static extern int GetModuleHandle([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

        // Token: 0x0600001C RID: 28
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

        // Token: 0x0600001D RID: 29
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, uint lpNumberOfBytesWritten);

        // Token: 0x0600001E RID: 30
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, int lpThreadId);

        // Token: 0x0600001F RID: 31
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WaitForSingleObject(int hHandle, int dwMilliseconds);

        // Token: 0x06000020 RID: 32
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int CloseHandle(int hObject);

        WebClient wc = new WebClient();
        private string defPath = Application.StartupPath + "//Monaco//";

        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            webBrowser1.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Proxy = null;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            webBrowser1.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            await Task.Delay(500);
            webBrowser1.Document.InvokeScript("SetTheme", new string[]
            {
                   "Dark" 
                   /*
                    There are 2 Themes Dark and Light
                   */
            });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            webBrowser1.Document.InvokeScript("SetText", new object[]
            {
                 "--FerSploit V.4.0.0--"
            });
        }

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)

            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255); label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private bool Inject(int pID, string dllLocation)
        {
            int num = Form1.OpenProcess(2035711, 1, pID);
            bool flag = num == 0;
            bool result;
            if (flag)
            {
                result = false;
            }
            else
            {
                byte[] bytes = Encoding.ASCII.GetBytes(dllLocation);
                int num2 = Form1.VirtualAllocEx(num, 0, bytes.Length, 4096, 4);
                bool flag2 = num2 == 0;
                if (flag2)
                {
                    result = false;
                }
                else
                {
                    string text = "kernel32.dll";
                    int moduleHandle = Form1.GetModuleHandle(ref text);
                    string text2 = "LoadLibraryA";
                    int procAddress = Form1.GetProcAddress(moduleHandle, ref text2);
                    bool flag3 = moduleHandle == 0 || procAddress == 0;
                    if (flag3)
                    {
                        result = false;
                    }
                    else
                    {
                        Form1.WriteProcessMemory(num, num2, bytes, bytes.Length, 0U);
                        int num3 = Form1.CreateRemoteThread(num, 0, 0, procAddress, num2, 0, 0);
                        bool flag4 = num3 == 0;
                        if (flag4)
                        {
                            result = false;
                        }
                        else
                        {
                            Form1.WaitForSingleObject(num3, 5000);
                            Form1.CloseHandle(num3);
                            Form1.CloseHandle(num);
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI: Made by NuzeryX#5011 Programed by: Ferripro#3714");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetText", new object[]
            {
                ""
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    webBrowser1.Document.InvokeScript("SetText", new object[]
                    {
                          MainText
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
            if (flag)
            {
                int num = (int)MessageBox.Show("Please open Roblox To Execute The Script");
            }
            else
            {
                using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", "ferripro", PipeDirection.Out))
                {
                    namedPipeClientStream.Connect();
                    using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
                    {
                        streamWriter.Write(script);
                        streamWriter.Dispose();
                    }
                    namedPipeClientStream.Dispose();
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            bool flag = File.Exists(Directory.GetCurrentDirectory() + "\\Fersploit api.dll");
            if (flag)
            {
                try
                {
                    string dllLocation = Path.Combine(Directory.GetCurrentDirectory(), "Fersploit api.dll");
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
                int num2 = (int)MessageBox.Show("Fersploit api.dll Cannot Be Found!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Options main = new Options();
            main.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ScriptHub = new Form2();
            ScriptHub.Show();
        }
    }
}
