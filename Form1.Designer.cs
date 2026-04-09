namespace BloodProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            btnlogin = new Button();
            checkBox = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            panel3 = new Panel();
            btnHideShow = new LinkLabel();
            txtPassword = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(-12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 769);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 512);
            label3.Name = "label3";
            label3.Size = new Size(281, 20);
            label3.TabIndex = 8;
            label3.Text = "Accept our Teams and Condition to login";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnlogin);
            panel4.Controls.Add(checkBox);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(46, 6);
            panel4.Margin = new Padding(5, 6, 5, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(100, 0, 0, 0);
            panel4.Size = new Size(573, 653);
            panel4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 542);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Read T/C";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(128, 255, 128);
            btnlogin.Location = new Point(217, 441);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(127, 37);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(250, 399);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(104, 24);
            checkBox.TabIndex = 5;
            checkBox.Text = "Accept T/C";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 315);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 232);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(129, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 82);
            panel2.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 128, 0);
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(21, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 34);
            txtUsername.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHideShow);
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(126, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 79);
            panel3.TabIndex = 11;
            // 
            // btnHideShow
            // 
            btnHideShow.AutoSize = true;
            btnHideShow.Location = new Point(246, 2);
            btnHideShow.Name = "btnHideShow";
            btnHideShow.Size = new Size(45, 20);
            btnHideShow.TabIndex = 7;
            btnHideShow.TabStop = true;
            btnHideShow.Text = "Show";
            btnHideShow.LinkClicked += btnHideShow_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 192, 128);
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(24, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 34);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1318, 7);
            button1.Name = "button1";
            button1.Size = new Size(71, 48);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1392, 651);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox checkBox;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Button btnlogin;
        private LinkLabel btnHideShow;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
    }
}
