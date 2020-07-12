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
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/VhrxLxd0").Contains("2.6"))
            {
                if (MessageBox.Show("Hay una actualización nueva, descargala en Fersploit Bootstrapper", "Asistente de actualizaciónes de fersploit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("No hay actualizaciónes disponibles", "Asistente de actualizaciónes de fersploit");
                main main = new main();
                main.Show();
                this.Hide();
            }
        }

        private void Updater_Load(object sender, EventArgs e)
        {

        }

        private void FlatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
