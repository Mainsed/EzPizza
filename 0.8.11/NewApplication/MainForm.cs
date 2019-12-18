using System;
using System.Drawing;
using System.Windows.Forms;



namespace NewApplication
{
    public partial class MainForm : Form
    {
        public DateTime EnterDate, CloseDate;
        public bool isError = false, isQuestionOpen = false;
        ChatLog CL;
        DataRead DR;
        RequestProcessing RP; 
        Settings set;
        Information inf;
        OrderDialog faq;
        public static int Mfont = 0;

        public MainForm()
        {
            InitializeComponent();
            RequestProcessing reqproc = new RequestProcessing(this);
            RP = reqproc;
            ChatLog chatlog = new ChatLog(this, RP);
            CL = chatlog;
            DataRead dataread = new DataRead(RP, this);
            DR = dataread;
            OrderDialog question = new OrderDialog(this);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AddBox.Text))
            {
                RP.UserRequest();
            }
        }

        private void AddBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(AddBox.Text))
                {
                    RP.UserRequest();
                }
            }
        }

        private void AddBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AddBox.Text == String.Empty)
            {
                if (!Char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Question_Click(object sender, EventArgs e)
        {
            RP.Instruction();
        }

        private void Information_Click(object sender, EventArgs e)
        {
            this.Hide();
            inf = new Information();
            inf.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            set = new Settings();
            set.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mfont == 1)
            {
                MFon.BackColor = Color.Red;
            }
            else if (Mfont == 2)
            {
                MFon.BackColor = Color.SteelBlue;
            }
            else if (Mfont == 3)
            {
                MFon.BackColor = Color.LawnGreen;
            }
        }

        private void ToOrder_Click(object sender, EventArgs e)
        {
            if (RP.Ulist.Count != 0 || RP.Basket!=null && !isQuestionOpen)
            {
                faq = new OrderDialog(this);
                faq.Show();
                isQuestionOpen = true;
            }
            else ListBox.Items.Add("Ваш кошик порожнiй, нiчого замовляти!");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //записть лога чата
            CL.SaveChat();
            CloseDate = DateTime.Now;
            CL.programUsage();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            RP.Pizza_Menu();
        }

        private void MyOrder_Click(object sender, EventArgs e)
        {
            RP.Basket_menu();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //Считывание xml файла и запись в массив
            DR.ReadData();
            RP.BubbleSort();
            //считывание лога чата
            CL.LoadChat();
            EnterDate = DateTime.Now;
        }
    }
}
