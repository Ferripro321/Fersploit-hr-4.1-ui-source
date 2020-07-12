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

namespace Relase_1._0_fersploit
{
    public partial class Updater_English : Form
    {
        public Updater_English()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/VhrxLxd0").Contains("3.0"))
            {
                if (MessageBox.Show("There is a new update, download in Fersploit Bootstrapper", "Fersploit update assistant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("No updates available", "Fersploit update assistant");
               // Menu_ingles main = new Menu_ingles();
              //  main.Show();
              //  this.Hide();
            }
        }

        private void Updater_English_Load(object sender, EventArgs e)
        {

        }

        private void FlatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
