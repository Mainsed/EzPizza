namespace NewApplication
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.IconGreen = new System.Windows.Forms.Button();
            this.IconBlue = new System.Windows.Forms.Button();
            this.IconRed = new System.Windows.Forms.Button();
            this.Gif = new System.Windows.Forms.PictureBox();
            this.SetBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // IconGreen
            // 
            this.IconGreen.BackColor = System.Drawing.Color.Black;
            this.IconGreen.BackgroundImage = global::NewApplication.Properties.Resources.Green;
            this.IconGreen.Location = new System.Drawing.Point(269, 70);
            this.IconGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconGreen.Name = "IconGreen";
            this.IconGreen.Size = new System.Drawing.Size(80, 80);
            this.IconGreen.TabIndex = 2;
            this.IconGreen.UseVisualStyleBackColor = false;
            this.IconGreen.Click += new System.EventHandler(this.IconGreen_Click);
            // 
            // IconBlue
            // 
            this.IconBlue.BackColor = System.Drawing.Color.Black;
            this.IconBlue.BackgroundImage = global::NewApplication.Properties.Resources.Blue;
            this.IconBlue.Location = new System.Drawing.Point(155, 70);
            this.IconBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBlue.Name = "IconBlue";
            this.IconBlue.Size = new System.Drawing.Size(80, 80);
            this.IconBlue.TabIndex = 1;
            this.IconBlue.UseVisualStyleBackColor = false;
            this.IconBlue.Click += new System.EventHandler(this.IconBlue_Click);
            // 
            // IconRed
            // 
            this.IconRed.BackColor = System.Drawing.Color.Black;
            this.IconRed.BackgroundImage = global::NewApplication.Properties.Resources.REd;
            this.IconRed.Location = new System.Drawing.Point(35, 70);
            this.IconRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconRed.Name = "IconRed";
            this.IconRed.Size = new System.Drawing.Size(80, 80);
            this.IconRed.TabIndex = 0;
            this.IconRed.UseVisualStyleBackColor = false;
            this.IconRed.Click += new System.EventHandler(this.IconRed_Click);
            // 
            // Gif
            // 
            this.Gif.BackColor = System.Drawing.Color.Transparent;
            this.Gif.Location = new System.Drawing.Point(67, 178);
            this.Gif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gif.Name = "Gif";
            this.Gif.Size = new System.Drawing.Size(251, 250);
            this.Gif.TabIndex = 3;
            this.Gif.TabStop = false;
            // 
            // SetBack
            // 
            this.SetBack.BackColor = System.Drawing.SystemColors.Control;
            this.SetBack.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.SetBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetBack.Location = new System.Drawing.Point(124, 466);
            this.SetBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetBack.Name = "SetBack";
            this.SetBack.Size = new System.Drawing.Size(141, 55);
            this.SetBack.TabIndex = 4;
            this.SetBack.Text = "Назад";
            this.SetBack.UseVisualStyleBackColor = false;
            this.SetBack.Click += new System.EventHandler(this.SetBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "11.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13.png");
            this.imageList1.Images.SetKeyName(14, "0.png");
            this.imageList1.Images.SetKeyName(15, "0.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оберіть стиль";
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::NewApplication.Properties.Resources.Ghjphfxysq11;
            this.ClientSize = new System.Drawing.Size(384, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBack);
            this.Controls.Add(this.Gif);
            this.Controls.Add(this.IconGreen);
            this.Controls.Add(this.IconBlue);
            this.Controls.Add(this.IconRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZPizza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IconRed;
        private System.Windows.Forms.Button IconBlue;
        private System.Windows.Forms.Button IconGreen;
        private System.Windows.Forms.PictureBox Gif;
        private System.Windows.Forms.Button SetBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}