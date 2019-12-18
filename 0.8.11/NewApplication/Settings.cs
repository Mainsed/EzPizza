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
    public partial class Settings : Form
    {
        MainForm mui; 
        int Sfont = MainForm.Mfont;
        public Settings()
        {
            InitializeComponent();
        }

        private void SetBack_Click(object sender, EventArgs e)
        {
            mui = new MainForm();
            mui.Show(); 
            this.Close();
           
        }
        int nGifcount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            nGifcount++;
            if (nGifcount == 15)
            {
                nGifcount = 0;
            }
            else
            {
                Gif.Image = imageList1.Images[nGifcount];
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Sfont == 1)
            {
                this.BackColor = Color.Red;
            }
            else if (Sfont == 2)
            {
                this.BackColor = Color.SteelBlue;
            }
            else if (Sfont == 3)
            {
                this.BackColor = Color.LawnGreen;
            }
        }

        private void IconRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MainForm.Mfont = 1;
            OrderDialog.Qfont = 1;
            Information.Ifont = 1;
        }

        private void IconBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
            MainForm.Mfont = 2;
            OrderDialog.Qfont = 2;
            Information.Ifont = 2;
        }

        private void IconGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LawnGreen;
            MainForm.Mfont = 3;
            OrderDialog.Qfont = 3;
            Information.Ifont = 3;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
