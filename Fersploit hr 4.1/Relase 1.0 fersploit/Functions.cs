using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Functions
    {
        public static OpenFileDialog openfiledialog = new OpenFileDialog
        {
            Filter = "Lua Script Txt (.txt)|.txt|All files (.)|.",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "FerSploit V1.0.0"
        };

    };
}
