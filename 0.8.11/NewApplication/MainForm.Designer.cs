namespace NewApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Settings = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.MyOrder = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.ToOrder = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MFon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MFon)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBox
            // 
            this.AddBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBox.Location = new System.Drawing.Point(19, 343);
            this.AddBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBox.Multiline = true;
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(293, 53);
            this.AddBox.TabIndex = 1;
            this.AddBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddBox_KeyDown);
            this.AddBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddBox_KeyPress);
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.HorizontalScrollbar = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(19, 53);
            this.ListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(347, 276);
            this.ListBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(124, 14);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(136, 28);
            this.Settings.TabIndex = 15;
            this.Settings.Text = "Налаштування";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Information
            // 
            this.Information.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.Information.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Information.FlatAppearance.BorderSize = 0;
            this.Information.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Information.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(265, 14);
            this.Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(100, 28);
            this.Information.TabIndex = 14;
            this.Information.Text = "Інформація";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Question
            // 
            this.Question.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.Question.FlatAppearance.BorderSize = 0;
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Question.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(19, 14);
            this.Question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(100, 28);
            this.Question.TabIndex = 13;
            this.Question.Text = "Команди";
            this.Question.UseVisualStyleBackColor = true;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // MyOrder
            // 
            this.MyOrder.BackColor = System.Drawing.SystemColors.Control;
            this.MyOrder.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.MyOrder.FlatAppearance.BorderSize = 0;
            this.MyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyOrder.Location = new System.Drawing.Point(195, 409);
            this.MyOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(171, 59);
            this.MyOrder.TabIndex = 12;
            this.MyOrder.Text = "Кошик";
            this.MyOrder.UseVisualStyleBackColor = false;
            this.MyOrder.Click += new System.EventHandler(this.MyOrder_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Menu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Location = new System.Drawing.Point(19, 409);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(171, 59);
            this.Menu.TabIndex = 11;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ToOrder
            // 
            this.ToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToOrder.BackColor = System.Drawing.SystemColors.Control;
            this.ToOrder.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_18;
            this.ToOrder.FlatAppearance.BorderSize = 0;
            this.ToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToOrder.Location = new System.Drawing.Point(19, 480);
            this.ToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToOrder.Name = "ToOrder";
            this.ToOrder.Size = new System.Drawing.Size(347, 59);
            this.ToOrder.TabIndex = 10;
            this.ToOrder.Text = "Замовити";
            this.ToOrder.UseVisualStyleBackColor = false;
            this.ToOrder.Click += new System.EventHandler(this.ToOrder_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SendButton.BackgroundImage = global::NewApplication.Properties.Resources.Untitled_17;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendButton.Location = new System.Drawing.Point(312, 343);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(55, 53);
            this.SendButton.TabIndex = 2;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MFon
            // 
            this.MFon.BackColor = System.Drawing.Color.SteelBlue;
            this.MFon.BackgroundImage = global::NewApplication.Properties.Resources.Ghjphfxysq11;
            this.MFon.Location = new System.Drawing.Point(-11, -37);
            this.MFon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MFon.Name = "MFon";
            this.MFon.Size = new System.Drawing.Size(405, 602);
            this.MFon.TabIndex = 16;
            this.MFon.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 553);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.MyOrder);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ToOrder);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.MFon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZPizza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ToOrder;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button MyOrder;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button Settings;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox MFon;
        public System.Windows.Forms.ListBox ListBox;
        public System.Windows.Forms.TextBox AddBox;
    }
}