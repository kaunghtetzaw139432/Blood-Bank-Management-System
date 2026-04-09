using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodProject
{
    public partial class AddNewDonor : Form
    {
      
        function fn = new function();

        public AddNewDonor()
        {
            InitializeComponent();
        }

     
        public void setID()
        {
            try
            {
                
                String query = "select isnull(max(did), 0) from newDonor";
                DataSet ds = fn.getData(query);

               
                int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelNewID.Text = (count + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ID: " + ex.Message);
            }
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            setID(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtName.Text != "" && txtFatherName.Text != "" && txtMotherName.Text != "" &&
                txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" &&
                txtEmail.Text != "" && txtBlood.Text != "" && txtCity.Text != "" && txtAddress.Text != "")
            {
                String dname = txtName.Text;
                String fname = txtFatherName.Text;
                String mname = txtMotherName.Text;
                String dob = txtDOB.Value.ToString("yyyy-MM-dd");
                String mobile = txtMobile.Text;
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String blood = txtBlood.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;

                String query = "insert into newDonor (dname, fname, mname, dob, mobile, gender, email, bloodgroup, city, daddress) " +
                               "values ('" + dname + "','" + fname + "','" + mname + "','" + dob + "','" + mobile + "','" + gender + "','" + email + "','" + blood + "','" + city + "','" + address + "')";

                try
                {

                    fn.setDate(query);
                    MessageBox.Show("Data processed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    clearAll();
                    setID();
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

        public void clearAll()
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtBlood.SelectedIndex = -1;
            txtCity.Clear();
            txtAddress.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void label13_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
    }
}