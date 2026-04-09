namespace BloodProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addNewDonorToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchBloodDonorToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1330, 12);
            button1.Name = "button1";
            button1.Size = new Size(71, 48);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 128);
            menuStrip1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchBloodDonorToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(10);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 4, 2);
            menuStrip1.Size = new Size(1413, 70);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonorToolStripMenuItem, updateDetailsToolStripMenuItem, allDonorDetailsToolStripMenuItem });
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Padding = new Padding(20, 30, 5, 0);
            donorToolStripMenuItem.Size = new Size(128, 63);
            donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonorToolStripMenuItem
            // 
            addNewDonorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("addNewDonorToolStripMenuItem.BackgroundImage");
            addNewDonorToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonorToolStripMenuItem.Image");
            addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            addNewDonorToolStripMenuItem.Size = new Size(279, 34);
            addNewDonorToolStripMenuItem.Text = "Add New Donor";
            addNewDonorToolStripMenuItem.Click += addNewDonorToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDetailsToolStripMenuItem.Image");
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(279, 34);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            allDonorDetailsToolStripMenuItem.Image = (Image)resources.GetObject("allDonorDetailsToolStripMenuItem.Image");
            allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            allDonorDetailsToolStripMenuItem.Size = new Size(279, 34);
            allDonorDetailsToolStripMenuItem.Text = "All Donor Details";
            allDonorDetailsToolStripMenuItem.Click += allDonorDetailsToolStripMenuItem_Click;
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem });
            searchBloodDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchBloodDonorToolStripMenuItem.Image");
            searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            searchBloodDonorToolStripMenuItem.Padding = new Padding(20, 30, 5, 0);
            searchBloodDonorToolStripMenuItem.Size = new Size(280, 63);
            searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Image = (Image)resources.GetObject("locationToolStripMenuItem.Image");
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(237, 34);
            locationToolStripMenuItem.Text = "Location";
            locationToolStripMenuItem.Click += locationToolStripMenuItem_Click;
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("bloodGroupToolStripMenuItem.Image");
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(237, 34);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            bloodGroupToolStripMenuItem.Click += bloodGroupToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Padding = new Padding(20, 30, 5, 0);
            stockToolStripMenuItem.Size = new Size(122, 63);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Image = (Image)resources.GetObject("increaseToolStripMenuItem.Image");
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(224, 34);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Image = (Image)resources.GetObject("decreaseToolStripMenuItem.Image");
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(224, 34);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = (Image)resources.GetObject("detailsToolStripMenuItem.Image");
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(224, 34);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Padding = new Padding(20, 30, 5, 0);
            deleteDonorToolStripMenuItem.Size = new Size(205, 63);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            deleteDonorToolStripMenuItem.Click += deleteDonorToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem1.Image");
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(243, 34);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Padding = new Padding(20, 30, 5, 0);
            logoutToolStripMenuItem.Size = new Size(136, 63);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1413, 671);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addNewDonorToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}