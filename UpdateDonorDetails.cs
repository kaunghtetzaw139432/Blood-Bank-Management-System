using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodProject
{
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtdonorId.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtdonorId.Text.ToString());
            String query = "select*from newDonor where did = " + id + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
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

        private void txtdonorId_TextChanged(object sender, EventArgs e)
        {
            if (txtdonorId.Text == "")
            {
                txtName.Clear();
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdonorId.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
            if (txtName.Text != "" && txtfname.Text != "" && txtmname.Text != "" &&
                txtdob.Text != "" && txtmobile.Text != "" && txtgender.Text != "" &&
                txtemail.Text != "" && txtblood.Text != "" && txtcity.Text != "" && txtaddress.Text != "")
            {
                try
                {
                   
                    int id = int.Parse(txtdonorId.Text); 
                    String dname = txtName.Text;
                    String fname = txtfname.Text;
                    String mname = txtmname.Text;
                    String dob = txtdob.Value.ToString("yyyy-MM-dd");
                    String mobile = txtmobile.Text;
                    String gender = txtgender.Text;
                    String email = txtemail.Text;
                    String blood = txtblood.Text;
                    String city = txtcity.Text;
                    String address = txtaddress.Text;

          
                    String query = "update newDonor set dname = '" + dname + "', fname = '" + fname + "', mname = '" + mname + "', dob = '" + dob + "', mobile = '" + mobile + "', gender = '" + gender + "', email = '" + email + "', bloodgroup = '" + blood + "', city = '" + city + "', daddress = '" + address + "' where did = " + id;

                
                    fn.setDate(query);

                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 

                    UpdateDonorDetails_Load(this,null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
