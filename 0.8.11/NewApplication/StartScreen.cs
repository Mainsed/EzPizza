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
    public partial class StartScreen : Form
    {

        public StartScreen()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            progressBar.Increment(1000);

        }
        int nGifcount = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            nGifcount++;
            if (nGifcount == 4)
            {
                nGifcount = 0;
            }
            else
            {
                pictureBox1.Image = imageList1.Images[nGifcount];
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
            timer1.Stop();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (ChatLog.SClose == true)
            {
                this.Close();
            }
        }
    }
}
