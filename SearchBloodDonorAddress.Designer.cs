namespace BloodProject
{
    partial class SearchBloodDonorAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBloodDonorAddress));
            label1 = new Label();
            label2 = new Label();
            txtaddress = new TextBox();
            dataGridView1 = new DataGridView();
            btnprint = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(532, 36);
            label1.TabIndex = 0;
            label1.Text = "SEARCH BLOOD DONOR(ADDRESS)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 79);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "ADDRESS";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(269, 80);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(213, 27);
            txtaddress.TabIndex = 2;
            txtaddress.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(702, 287);
            dataGridView1.TabIndex = 3;
            // 
            // btnprint
            // 
            btnprint.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprint.Location = new Point(49, 436);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(94, 29);
            btnprint.TabIndex = 4;
            btnprint.Text = "PRINT";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(500, 436);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(-69, 60);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 2);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-69, 420);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 2);
            panel2.TabIndex = 7;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // SearchBloodDonorAddress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 486);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnprint);
            Controls.Add(dataGridView1);
            Controls.Add(txtaddress);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBloodDonorAddress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchBloodDonorAddress";
            Load += SearchBloodDonorAddress_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtaddress;
        private DataGridView dataGridView1;
        private Button btnprint;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}