using System;
using System.Windows.Forms;
using System.Data;

namespace OOP_ContactLMS
{
    public partial class AddContactsControl : UserControl
    {
        ContactDB contactDB = new ContactDB();
        private int selectedContactID = 0;

        public AddContactsControl()
        {
            InitializeComponent();
            LoadContacts();

            // Event handler for selecting a row in DataGridView
            this.contact_dataGrid.CellClick += new DataGridViewCellEventHandler(this.contact_dataGrid_CellContentClick);
        }

        private void LoadContacts()
        {
            // Get all contacts from the database
            DataTable contacts = contactDB.GetContacts();

            // Bind contacts to DataGridView
            contact_dataGrid.DataSource = contacts;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Add a new contact
            contactDB.AddContact(
                firstName.Text,
                lastName.Text,
                email.Text,
                phoneNumber.Text,
                companyName.Text,
                address.Text
            );
            // Reload contacts
            LoadContacts();
            MessageBox.Show("Contact added successfully!");
            ClearFields();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Check if a contact is selected
            if (selectedContactID != 0)
            {
                // Update the selected contact
                contactDB.UpdateContact(
                    selectedContactID,
                    firstName.Text,
                    lastName.Text,
                    email.Text,
                    phoneNumber.Text,
                    companyName.Text,
                    address.Text
                );
                // Reload contacts
                LoadContacts();
                MessageBox.Show("Contact updated successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // Clear all fields
            ClearFields();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            // Check if a contact is selected
            if (selectedContactID != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the contact
                    contactDB.DeleteContact(selectedContactID);
                    // Reload contacts
                    LoadContacts();
                    MessageBox.Show("Contact deleted successfully!");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }
        }

        // Event handler for selecting a row in DataGridView
        private void contact_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = contact_dataGrid.Rows[e.RowIndex];

                // Set selected contact ID using the correct column name
                selectedContactID = Convert.ToInt32(row.Cells["contactIDDataGridViewTextBoxColumn"].Value);

                // Populate the text fields with the contact details
                firstName.Text = row.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
                lastName.Text = row.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
                email.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                phoneNumber.Text = row.Cells["phoneNumberDataGridViewTextBoxColumn"].Value.ToString();
                companyName.Text = row.Cells["companyNameDataGridViewTextBoxColumn"].Value.ToString();
                address.Text = row.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
            }
        }



        // Method to clear all text fields
        private void ClearFields()
        {
            firstName.Clear();
            lastName.Clear();
            email.Clear();
            phoneNumber.Clear();
            companyName.Clear();
            address.Clear();
            selectedContactID = 0; // Reset selected contact ID
        }
    }
}
