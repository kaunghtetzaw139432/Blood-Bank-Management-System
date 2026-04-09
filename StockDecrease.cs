using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodProject
{
    public partial class StockDecrease : Form
    {
        function fn = new function();
        String query;
        public StockDecrease()
        {
            InitializeComponent();
        }

        private void StockDecrease_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select bid, blood_group, quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btndecrease_Click(object sender, EventArgs e)
        {

            string bGroup = txtblood.Text;
            int decreaseUnits = Math.Abs(Convert.ToInt32(txtunit.Text));


            query = "select quantity from stock where blood_group = '" + bGroup + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int currentUnits = int.Parse(ds.Tables[0].Rows[0][0].ToString());


                if (currentUnits >= decreaseUnits)
                {

                    int finalUnits = currentUnits - decreaseUnits;
                    query = "update stock set quantity = " + finalUnits + " where blood_group = '" + bGroup + "'";
                    fn.setDate(query);

                    loadData();
                }
                else
                {

                    MessageBox.Show("No Enough Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font contentFont = new Font("Arial", 11, FontStyle.Regular);
            Graphics g = e.Graphics;


            g.DrawString("Current Blood Stock Report", titleFont, Brushes.DarkBlue, new Point(250, 40));
            g.DrawString("Print Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), contentFont, Brushes.Black, new Point(550, 80));


            g.DrawLine(Pens.Black, 100, 110, 700, 110);


            int y = 130;

            g.FillRectangle(Brushes.LightGray, 100, y, 600, 30);

            g.DrawString("Blood ID", headerFont, Brushes.Black, new Point(120, y + 5));
            g.DrawString("Blood Group", headerFont, Brushes.Black, new Point(300, y + 5));
            g.DrawString("Available Quantity (Units)", headerFont, Brushes.Black, new Point(500, y + 5));

            y += 35;
            g.DrawLine(Pens.Black, 100, y, 700, y);
            y += 10;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["blood_group"].Value != null)
                {

                    g.DrawString(row.Cells["bid"].Value.ToString(), contentFont, Brushes.Black, new Point(120, y));
                    g.DrawString(row.Cells["blood_group"].Value.ToString(), contentFont, Brushes.Black, new Point(300, y));
                    g.DrawString(row.Cells["quantity"].Value.ToString(), contentFont, Brushes.Black, new Point(500, y));

                    y += 30;


                    g.DrawLine(Pens.LightGray, 100, y, 700, y);
                    y += 5;
                }
            }


            g.DrawString("End of Report", contentFont, Brushes.Gray, new Point(350, y + 20));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
