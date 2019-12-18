using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class Information : Form
    {
        MainForm mad;
        public static int Ifont = 0;
        public Information()
        {
            InitializeComponent();
        }

        private void InfBack_Click(object sender, EventArgs e)
        {
            mad = new MainForm();
            mad.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ifont == 1)
            {
                Ifon.BackColor = Color.Red;
            }
            else if (Ifont == 2)
            {
                Ifon.BackColor = Color.SteelBlue;
            }
            else if (Ifont == 3)
            {
                Ifon.BackColor = Color.LawnGreen;
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
