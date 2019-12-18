namespace NewApplication
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InfBack = new System.Windows.Forms.Button();
            this.Ifon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ifon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InfBack
            // 
            this.InfBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfBack.Image = global::NewApplication.Properties.Resources.Untitled_18;
            this.InfBack.Location = new System.Drawing.Point(124, 466);
            this.InfBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfBack.Name = "InfBack";
            this.InfBack.Size = new System.Drawing.Size(141, 55);
            this.InfBack.TabIndex = 0;
            this.InfBack.Text = "Назад";
            this.InfBack.UseVisualStyleBackColor = true;
            this.InfBack.Click += new System.EventHandler(this.InfBack_Click);
            // 
            // Ifon
            // 
            this.Ifon.BackColor = System.Drawing.Color.SteelBlue;
            this.Ifon.BackgroundImage = global::NewApplication.Properties.Resources._888811;
            this.Ifon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ifon.Location = new System.Drawing.Point(-12, -32);
            this.Ifon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ifon.Name = "Ifon";
            this.Ifon.Size = new System.Drawing.Size(408, 594);
            this.Ifon.TabIndex = 1;
            this.Ifon.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 111);
            this.label1.MaximumSize = new System.Drawing.Size(280, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ця програма була розроблена\r\nв якості завдання до курсової роботи\r\nстудентами гру" +
    "пи КНТ-118\r\nІвахненко Богдан\r\nКлоков Артем\r\nШевердінкін Ілля\r\nЧерник Дмитро\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Information
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfBack);
            this.Controls.Add(this.Ifon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZPizza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Information_FormClosing);
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ifon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InfBack;
        private System.Windows.Forms.PictureBox Ifon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}