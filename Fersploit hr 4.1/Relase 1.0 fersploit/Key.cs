using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowsFormsApp1;

namespace Relase_1._0_fersploit
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/MyUP6YZ");
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //WebClient wc = new WebClient();
            // //string recive = wc.DownloadString("https://pastebin.com/raw/QeeiYMHm");
            // if (recive.Contains(richTextBox2.Text))
            //{

            // Form1 main = new Form1();
            //  main.Show();
            // this.Hide();

            // }
            //  else {

            //  MessageBox.Show("LMAO (incorrect key)");

            // }

         //   string whitelist = richTextBox2.Text;
           // if (whitelist.Length > 9) 
           // {
               // WebClient wc = new WebClient();
               // string recieve = wc.DownloadString("https://pastebin.com/raw/QeeiYMHm");

           //     if (recieve.Contains(whitelist))
             //   {
                 //   MessageBox.Show("Done, starting fersploit hr");
                    Form1 main = new Form1();
                    main.Show();
                    this.Hide();
            //    }
            //    else
              // {
               //     MessageBox.Show("Incorrect key");
               //     richTextBox2.Text = "";
              //  }
          //  }
         //   else
           // {
            //    MessageBox.Show("OMG HACKERRRR", "Noob error");
             //   richTextBox2.Text = "";
           // }


        }

    
    private void Button4_Click(object sender, EventArgs e)
        {
            
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

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
