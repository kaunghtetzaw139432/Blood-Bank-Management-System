using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodProject
{
    public partial class SearchBloodDonorAddress : Form
    {
        function fn = new function();
        public SearchBloodDonorAddress()
        {
            InitializeComponent();
        }

        private void SearchBloodDonorAddress_Load(object sender, EventArgs e)
        {
            String query = "Select *  from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtaddress.Text != "")
            {

                String query = "select * from newDonor where city Like '" + txtaddress.Text + "%' or daddress Like '" + txtaddress.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SearchBloodDonorAddress_Load(this, null);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10, FontStyle.Regular);
            Graphics g = e.Graphics;


            g.DrawString("Blood Donor List", titleFont, Brushes.DarkRed, new Point(320, 30));
            g.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), contentFont, Brushes.Black, new Point(650, 40));
            g.DrawLine(Pens.Black, 50, 70, 770, 70);


            int y = 90;
            g.DrawString("ID", headerFont, Brushes.Black, new Point(50, y));
            g.DrawString("Donor Name", headerFont, Brushes.Black, new Point(90, y));
            g.DrawString("Father Name", headerFont, Brushes.Black, new Point(280, y));
            g.DrawString("DOB", headerFont, Brushes.Black, new Point(480, y));
            g.DrawString("Mobile", headerFont, Brushes.Black, new Point(630, y));

            y += 25;
            g.DrawLine(Pens.Black, 50, y, 770, y);
            y += 10;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["did"].Value != null)
                {

                    g.DrawString(row.Cells["did"].Value.ToString(), contentFont, Brushes.Black, new Point(50, y));
                    g.DrawString(row.Cells["dname"].Value.ToString(), contentFont, Brushes.Black, new Point(90, y));
                    g.DrawString(row.Cells["fname"].Value.ToString(), contentFont, Brushes.Black, new Point(280, y));


                    DateTime dt = Convert.ToDateTime(row.Cells["dob"].Value);
                    string onlyDate = dt.ToString("dd/MM/yyyy"); // ရက်စွဲသီးသန့်ပဲ ယူမယ်
                    g.DrawString(onlyDate, contentFont, Brushes.Black, new Point(480, y));


                    g.DrawString(row.Cells["mobile"].Value.ToString(), contentFont, Brushes.Black, new Point(630, y));

                    y += 25;
                }
            }
        }
    }
}
