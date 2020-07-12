using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relase_1._0_fersploit
{
    public partial class Fersploit_script_hub : Form
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Fersploit_script_hub()
        {
            InitializeComponent();
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            flatButton3.Visible = true;
            pictureBox2.Visible = true;
            flatButton5.Visible = false;
            pictureBox3.Visible = false;
        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {  
          this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript(richTextBox1.Text);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FlatButton2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
            flatButton3.Visible = false;
            pictureBox2.Visible = false;
            flatButton5.Visible = true;
            pictureBox3.Visible = true;
        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript(richTextBox2.Text);
        }
    }
}
