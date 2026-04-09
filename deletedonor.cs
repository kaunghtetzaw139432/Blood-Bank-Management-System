using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BloodProject
{
    public partial class deletedonor : Form
    {
        function fn = new function();
        public deletedonor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
            if (txtdonorId.Text != "")
            {
    
                if (MessageBox.Show("Are you sure you want to delete this donor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(txtdonorId.Text);

                      
                        String query = "delete from newDonor where did = " + id;


                        fn.setDate(query);

                        MessageBox.Show("Donor Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     
                        this.deletedonor_Load(this, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Donor ID first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtdonorId_TextChanged(object sender, EventArgs e)
        {
            if (txtdonorId.Text == "")
            {
                txtname.Clear();
                txtfname.Clear();
                txtmname.Clear();
                txtdob.ResetText();
                txtmobile.Clear();
                txtgender.ResetText();
                txtemail.Clear();
                txtblood.ResetText();
                txtcity.Clear();
                txtaddress.Clear();
            }
        }

        private void deletedonor_Load(object sender, EventArgs e)
        {
            txtdonorId.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtdonorId.Text.ToString());
            String query = "select*from newDonor where did = " + id + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtname.Text = ds.Tables[0].Rows[0][1].ToString();
                txtfname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtmname.Text = ds.Tables[0].Rows[0][3].ToString();  
                txtdob.Text = ds.Tables[0].Rows[0][4].ToString();  
                txtmobile.Text = ds.Tables[0].Rows[0][5].ToString();  
                txtgender.Text = ds.Tables[0].Rows[0][6].ToString(); 
                txtemail.Text = ds.Tables[0].Rows[0][7].ToString(); 
                txtblood.Text = ds.Tables[0].Rows[0][8].ToString();  
                txtcity.Text = ds.Tables[0].Rows[0][9].ToString(); 
                txtaddress.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdonorId.Clear();
        }
    }
}
