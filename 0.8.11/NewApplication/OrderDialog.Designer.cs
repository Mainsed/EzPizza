namespace NewApplication
{
    partial class OrderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDialog));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BackQuest = new System.Windows.Forms.Button();
            this.Qfon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Qfon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(57, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 13;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "+380";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BackQuest
            // 
            this.BackQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackQuest.BackColor = System.Drawing.SystemColors.Control;
            this.BackQuest.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.BackQuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackQuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackQuest.Location = new System.Drawing.Point(105, 220);
            this.BackQuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackQuest.Name = "BackQuest";
            this.BackQuest.Size = new System.Drawing.Size(141, 55);
            this.BackQuest.TabIndex = 3;
            this.BackQuest.Text = "Ок";
            this.BackQuest.UseVisualStyleBackColor = false;
            this.BackQuest.Click += new System.EventHandler(this.BackQuest_Click);
            // 
            // Qfon
            // 
            this.Qfon.BackColor = System.Drawing.Color.SteelBlue;
            this.Qfon.BackgroundImage = global::NewApplication.Properties.Resources._999999991;
            this.Qfon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Qfon.Location = new System.Drawing.Point(-12, -39);
            this.Qfon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Qfon.Name = "Qfon";
            this.Qfon.Size = new System.Drawing.Size(380, 348);
            this.Qfon.TabIndex = 4;
            this.Qfon.TabStop = false;
            // 
            // Question
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NewApplication.Properties.Resources.Ghjphfxysq11;
            this.ClientSize = new System.Drawing.Size(356, 297);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackQuest);
            this.Controls.Add(this.Qfon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZPizza";
            this.Load += new System.EventHandler(this.Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qfon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackQuest;
        private System.Windows.Forms.PictureBox Qfon;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox textBox1;
    }
}