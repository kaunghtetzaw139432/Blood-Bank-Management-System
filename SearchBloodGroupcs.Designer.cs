namespace BloodProject
{
    partial class SearchBloodGroupcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBloodGroupcs));
            label1 = new Label();
            label2 = new Label();
            txtblood = new TextBox();
            dataGridView1 = new DataGridView();
            btnprint = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 21);
            label1.Name = "label1";
            label1.Size = new Size(582, 32);
            label1.TabIndex = 0;
            label1.Text = "SEARCH BLOOD DONOR (BLOOD GROUP)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            // 
            // txtblood
            // 
            txtblood.Location = new Point(281, 74);
            txtblood.Name = "txtblood";
            txtblood.Size = new Size(221, 27);
            txtblood.TabIndex = 3;
            txtblood.TextChanged += txtblood_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(682, 254);
            dataGridView1.TabIndex = 4;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(51, 389);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(94, 29);
            btnprint.TabIndex = 5;
            btnprint.Text = "PRINT";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // button2
            // 
            button2.Location = new Point(547, 389);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // SearchBloodGroupcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 439);
            Controls.Add(button2);
            Controls.Add(btnprint);
            Controls.Add(dataGridView1);
            Controls.Add(txtblood);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchBloodGroupcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchBloodGroupcs";
            Load += SearchBloodGroupcs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtblood;
        private DataGridView dataGridView1;
        private Button btnprint;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}