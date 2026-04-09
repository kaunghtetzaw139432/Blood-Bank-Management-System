namespace BloodProject
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtdonorId = new MaskedTextBox();
            btnsearch = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            txtName = new TextBox();
            txtfname = new TextBox();
            txtmname = new TextBox();
            txtmobile = new TextBox();
            txtemail = new TextBox();
            txtcity = new TextBox();
            txtdob = new DateTimePicker();
            txtblood = new ComboBox();
            txtaddress = new RichTextBox();
            btnupdate = new Button();
            btnreset = new Button();
            button4 = new Button();
            label5 = new Label();
            txtgender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(466, 39);
            label1.TabIndex = 0;
            label1.Text = "UPDATE DONOR DETAILS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(-124, 106);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 2);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 3;
            label2.Text = "Donor ID:";
            // 
            // txtdonorId
            // 
            txtdonorId.Location = new Point(232, 128);
            txtdonorId.Margin = new Padding(4);
            txtdonorId.Name = "txtdonorId";
            txtdonorId.Size = new Size(228, 31);
            txtdonorId.TabIndex = 4;
            txtdonorId.TextChanged += txtdonorId_TextChanged;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = SystemColors.ActiveCaption;
            btnsearch.Location = new Point(487, 123);
            btnsearch.Margin = new Padding(4);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(152, 40);
            btnsearch.TabIndex = 5;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-11, 178);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 4);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 215);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 402);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 8;
            label4.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 282);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 11;
            label7.Text = "Blood Group";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(438, 472);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 12;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 343);
            label9.Name = "label9";
            label9.Size = new Size(122, 25);
            label9.TabIndex = 13;
            label9.Text = "Mother Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(456, 215);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 14;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 473);
            label11.Name = "label11";
            label11.Size = new Size(67, 25);
            label11.TabIndex = 15;
            label11.Text = "Mobile";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(43, 277);
            label13.Name = "label13";
            label13.Size = new Size(112, 25);
            label13.TabIndex = 17;
            label13.Text = "Father Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 408);
            label12.Name = "label12";
            label12.Size = new Size(115, 25);
            label12.TabIndex = 16;
            label12.Text = "Date Of Birth";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(-11, 520);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 2);
            panel3.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 215);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 19;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(181, 274);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(200, 31);
            txtfname.TabIndex = 20;
            // 
            // txtmname
            // 
            txtmname.Location = new Point(181, 340);
            txtmname.Name = "txtmname";
            txtmname.Size = new Size(200, 31);
            txtmname.TabIndex = 21;
            // 
            // txtmobile
            // 
            txtmobile.Location = new Point(181, 470);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(200, 31);
            txtmobile.TabIndex = 22;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(596, 212);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(200, 31);
            txtemail.TabIndex = 23;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(598, 402);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(200, 31);
            txtcity.TabIndex = 24;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(181, 402);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(200, 31);
            txtdob.TabIndex = 26;
            // 
            // txtblood
            // 
            txtblood.DropDownStyle = ComboBoxStyle.DropDownList;
            txtblood.FormattingEnabled = true;
            txtblood.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtblood.Location = new Point(598, 279);
            txtblood.Name = "txtblood";
            txtblood.Size = new Size(198, 33);
            txtblood.TabIndex = 28;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(596, 448);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(199, 62);
            txtaddress.TabIndex = 29;
            txtaddress.Text = "";
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(159, 548);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(117, 31);
            btnupdate.TabIndex = 30;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(381, 548);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(117, 31);
            btnreset.TabIndex = 31;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // button4
            // 
            button4.Location = new Point(624, 548);
            button4.Name = "button4";
            button4.Size = new Size(117, 31);
            button4.TabIndex = 32;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 340);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 33;
            label5.Text = "Gender";
            // 
            // txtgender
            // 
            txtgender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtgender.FormattingEnabled = true;
            txtgender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtgender.Location = new Point(596, 335);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(198, 33);
            txtgender.TabIndex = 34;
            // 
            // UpdateDonorDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 591);
            Controls.Add(txtgender);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(btnreset);
            Controls.Add(btnupdate);
            Controls.Add(txtaddress);
            Controls.Add(txtblood);
            Controls.Add(txtdob);
            Controls.Add(txtcity);
            Controls.Add(txtemail);
            Controls.Add(txtmobile);
            Controls.Add(txtmname);
            Controls.Add(txtfname);
            Controls.Add(txtName);
            Controls.Add(panel3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(btnsearch);
            Controls.Add(txtdonorId);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "UpdateDonorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDonorDetails";
            Load += UpdateDonorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private MaskedTextBox txtdonorId;
        private Button btnsearch;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label12;
        private Panel panel3;
        private TextBox txtName;
        private TextBox txtfname;
        private TextBox txtmname;
        private TextBox txtmobile;
        private TextBox txtemail;
        private TextBox txtcity;
        private DateTimePicker txtdob;
        private ComboBox txtblood;
        private RichTextBox txtaddress;
        private Button btnupdate;
        private Button btnreset;
        private Button button4;
        private Label label5;
        private ComboBox txtgender;
    }
}