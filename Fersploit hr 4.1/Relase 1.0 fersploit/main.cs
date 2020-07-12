using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Relase_1._0_fersploit
{
    public partial class main : Form
    {

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);
        public main()
        {
            InitializeComponent();

        }

        private void FormSkin1_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton6_Click(object sender, EventArgs e)
        {
          
        }

        private void FlatButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton8_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton10_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton11_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatMini1_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton12_Click(object sender, EventArgs e)
        {
           
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton13_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton14_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton15_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton16_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton17_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton18_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton19_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.roblox.com/home");
        }

        private void FlatTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/BCaw7sm");
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCF4Y74tQk4n9-noyWB-loQw?view_as=subscriber");
        }

        private void FlatTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Ferripro3211");
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://fersploit.weebly.com/fersploit-hr-caracteristicas-y-descargas.html");
        }

        private void FlatButton18_Click_1(object sender, EventArgs e)
        {
           
        }

        private void FlatButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton19_Click_1(object sender, EventArgs e)
        {
          
        }

        private void FlatButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void FlatButton20_Click(object sender, EventArgs e)
        {
          
        }

        private void FlatButton23_Click(object sender, EventArgs e)
        {
       
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void FlatButton24_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatButton24_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox2.Text = ("");
        }

        private void FlatButton25_Click(object sender, EventArgs e)
        {
            SendLimitedLuaScript(fastColoredTextBox2.Text);
        }

        private void SendLuaScript(string text)
        {
            throw new NotImplementedException();
        }

        private void FlatButton26_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton27_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TabPage9_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton28_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton1_Click_1(object sender, EventArgs e)
        {
            LaunchExploit();
            Process.Start("https://discord.gg/JzV5Afw");
        }

        private void FlatButton29_Click(object sender, EventArgs e)
        {
            
        }

        private void FlatButton30_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void FastColoredTextBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void FastColoredTextBox2_Load(object sender, EventArgs e)
        {
            fastColoredTextBox2.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void FlatButton26_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FlatButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void FlatTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

