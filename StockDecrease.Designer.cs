namespace BloodProject
{
    partial class StockDecrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDecrease));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtblood = new ComboBox();
            txtunit = new ComboBox();
            btndecrease = new Button();
            btnprint = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 28);
            label1.Name = "label1";
            label1.Size = new Size(301, 36);
            label1.TabIndex = 0;
            label1.Text = "STOCK(DECREASE)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 98);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // txtblood
            // 
            txtblood.FormattingEnabled = true;
            txtblood.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtblood.Location = new Point(153, 95);
            txtblood.Name = "txtblood";
            txtblood.Size = new Size(137, 28);
            txtblood.TabIndex = 3;
            // 
            // txtunit
            // 
            txtunit.FormattingEnabled = true;
            txtunit.Items.AddRange(new object[] { "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10" });
            txtunit.Location = new Point(380, 95);
            txtunit.Name = "txtunit";
            txtunit.Size = new Size(168, 28);
            txtunit.TabIndex = 4;
            // 
            // btndecrease
            // 
            btndecrease.Location = new Point(571, 95);
            btndecrease.Name = "btndecrease";
            btndecrease.Size = new Size(94, 29);
            btndecrease.TabIndex = 5;
            btndecrease.Text = "Decrease";
            btndecrease.UseVisualStyleBackColor = true;
            btndecrease.Click += btndecrease_Click;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(60, 444);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(94, 29);
            btnprint.TabIndex = 6;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(521, 444);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 285);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // StockDecrease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 503);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(btnprint);
            Controls.Add(btndecrease);
            Controls.Add(txtunit);
            Controls.Add(txtblood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDecrease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockDecrease";
            Load += StockDecrease_Load;
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
        private Button btndecrease;
        private Button btnprint;
        private Button button3;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}