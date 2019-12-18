using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class OrderDialog : Form
    {
        private MainForm MF;
        string buf = "";
        public static int Qfont = 0;
        public OrderDialog(MainForm mainform)
        {
            InitializeComponent();
            MF = mainform;
        }
        private void BackQuest_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 13)
            {
                MessageBox.Show("Неправильний формат номеру", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MF.isQuestionOpen = false;
                MF.ListBox.Items.Add("Ваше замовлення обробляється...");
                MF.ListBox.Items.Add("Очікуйте на дзвінок оператора");
                MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
                MF.ListBox.SelectedIndex = -1;
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            if (Qfont == 1)
            {
                Qfon.BackColor = Color.Red;
                Qfon.BackColor = Color.Red;
            }
            else if (Qfont == 2)
            {
                Qfon.BackColor = Color.SteelBlue;
                Qfon.BackColor = Color.SteelBlue;
            }
            else if (Qfont == 3)
            {
                Qfon.BackColor = Color.LawnGreen;
                Qfon.BackColor = Color.LawnGreen;
            }
        }

        private void Question_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BackQuest_Click(sender,e);
                    this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long num;
            try { buf = textBox1.Text.Substring(0, 4); }
            catch
            {
                buf = "+380";
                textBox1.Text = buf;
            }
            if (buf != "+380")
            {
                buf = textBox1.Text;
                try{buf = "+380" + buf.Substring(4, buf.Length - 1);}
                catch { buf = "+380"; }
                textBox1.Text = buf;
            }
            if (!long.TryParse(textBox1.Text, out num))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
