namespace BloodProject
{
    partial class stockincrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockincrease));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtblood = new ComboBox();
            txtunit = new ComboBox();
            dataGridView1 = new DataGridView();
            btnincrease = new Button();
            button1 = new Button();
            btnprint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 39);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 0;
            label1.Text = "STOCK(INCREASE)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 112);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Units";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Blood Group";
            // 
            // txtblood
            // 
            txtblood.DropDownStyle = ComboBoxStyle.DropDownList;
            txtblood.FormattingEnabled = true;
            txtblood.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtblood.Location = new Point(121, 109);
            txtblood.Name = "txtblood";
            txtblood.Size = new Size(177, 28);
            txtblood.TabIndex = 3;
            // 
            // txtunit
            // 
            txtunit.DropDownStyle = ComboBoxStyle.DropDownList;
            txtunit.FormattingEnabled = true;
            txtunit.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            txtunit.Location = new Point(393, 109);
            txtunit.Name = "txtunit";
            txtunit.Size = new Size(177, 28);
            txtunit.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(719, 280);
            dataGridView1.TabIndex = 5;
            // 
            // btnincrease
            // 
            btnincrease.Location = new Point(590, 112);
            btnincrease.Name = "btnincrease";
            btnincrease.Size = new Size(100, 27);
            btnincrease.TabIndex = 6;
            btnincrease.Text = "Increase";
            btnincrease.UseVisualStyleBackColor = true;
            btnincrease.Click += btnincrease_Click;
            // 
            // button1
            // 
            button1.Location = new Point(590, 497);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 7;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(12, 497);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(100, 27);
            btnprint.TabIndex = 8;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // stockincrease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 550);
            Controls.Add(btnprint);
            Controls.Add(button1);
            Controls.Add(btnincrease);
            Controls.Add(dataGridView1);
            Controls.Add(txtunit);
            Controls.Add(txtblood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stockincrease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "stockincrease";
            Load += stockincrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtblood;
        private ComboBox txtunit;
        private DataGridView dataGridView1;
        private Button btnincrease;
        private Button button1;
        private Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}