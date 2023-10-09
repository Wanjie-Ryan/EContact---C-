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
                //Clear();
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
    }
}
