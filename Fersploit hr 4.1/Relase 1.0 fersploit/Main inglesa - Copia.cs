using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Relase_1._0_fersploit
{
    public partial class Main_inglesa : Form
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);

        public Main_inglesa()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.roblox.com/home");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript(fastColoredTextBox1.Text);
        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://fersploit.weebly.com/fersploit-hr-caracteristicas-y-descargas.html");
        }

        private void FlatButton7_Click(object sender, EventArgs e)
        {
            Scripts_de_Juegos main = new Scripts_de_Juegos();
            main.Show();
            this.Hide();
        }

        private void FlatButton8_Click(object sender, EventArgs e)
        {
            LaunchExploit();
            Process.Start("https://discord.gg/JzV5Afw");

        }

        private void FormSkin1_Click(object sender, EventArgs e)
        {

        }

        private void FastColoredTextBox1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void FlatButton30_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
