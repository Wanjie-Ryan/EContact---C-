using EContact.eContact_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact
{
    public partial class EContact : Form
    {
        public EContact()
        {
            InitializeComponent();
        }
        ContactClass c = new ContactClass();

        private void txtboxcontactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //get the values from the input fields
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmbGender.Text;

            //inserting data into db using the method we created in the contact class

            bool success = c.Insert(c);

            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("Created Contact Successfully ");
                //call the clear method here
                Clear();
            }
            else
            {
                //failed to add contact
                MessageBox.Show("Failed to add new contact. Try again");
            }

            //loading the data to the data grid view

            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;


        }

        private void EContact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to clear fields
        public void Clear()
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxContactNumber.Text = "";
            txtBoxAddress.Text = "";
            cmbGender.Text = "";
            txtboxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get data from the textboxes

            c.ContactID = int.Parse(txtboxContactID.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmbGender.Text;

            //update the data in the database

            bool success = c.Update(c);




            if (success == true)
            {
                MessageBox.Show("Contact has been updated successfully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();

            }
            else
            {

                MessageBox.Show("Failed to update contact. Try again");

            }
            



        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from the data grid view and load it to the textboxes respectively
            //identify the row which the mouse is clicked

            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the clear method

            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // get the id from the textbox

            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
            bool success = c.Delete(c);

            if(success == true)
            {
                MessageBox.Show("Contact has been deleted successfully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to delete contact. Try again");
            }

        }
    }
}
