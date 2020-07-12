using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using sendWebhook;
using System.Collections.Specialized;

using System.Net;

using WindowsFormsApp1;


namespace Relase_1._0_fersploit
{
    public partial class Write_a_comment : Form
    {
        public Write_a_comment()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void SendDiscordWebHook(string webhook, string msg, string username)
        {
            Http.Post(webhook, new NameValueCollection()
       {
        {
          "username",
          username
        },
        {
          "content",
          msg
        }
       });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            SendDiscordWebHook(textBox2.Text, flatTextBox1.Text, textBox1.Text);
            MessageBox.Show("Done! you will receive a message in discord in less than 24 hours");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Write_a_comment_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options ui1 = new Options();
            ui1.Show();
            this.Hide();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // WebClient wc = new WebClient();
            //  string recive = wc.DownloadString("https://pastebin.com/raw/QeeiYMHm");
            //  if (recive.Contains(flatTextBox2.Text))
            // {

            //     SendDiscordWebHook(textBox2.Text, flatTextBox2.Text, textBox3.Text);
            //     flatButton1.Visible = true;
            ///      flatTextBox1.Visible = true;
            //      flatLabel1.Visible = false;
            //     flatTextBox2.Visible = false;
            //    flatButton2.Visible = false;

            //   }
            //  else
            // {

            //   MessageBox.Show("You are silly lmao, put your fuking key");

            //  }


            flatButton1.Visible = true;
            flatTextBox1.Visible = true;
            flatLabel1.Visible = false;
            textBox4.Visible = false;
            flatButton2.Visible = false;

        }
    }
}
