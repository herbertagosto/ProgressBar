using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // start
            ProgressBar.UI.Start(this);
            for (int i = 0; i < 2; i++)
            {
                // long process..
                System.Threading.Thread.Sleep(1000);
            }
            // stop/exit
            ProgressBar.UI.Stop();
        }
    }
}
