using System;
using System.Data;
using System.Windows.Forms;

namespace OOP_ContactLMS
{
    public partial class ViewContactsControl : UserControl
    {
        // Create an instance of the ContactDB class
        ContactDB contactDB = new ContactDB();

        public ViewContactsControl()
        {
            InitializeComponent();
        }

        // Load the contacts into the DataGridView when the control is loaded
        private void ViewContactsControl_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        // Method to load all contacts from the database
        private void LoadContacts()
        {
            try
            {
                // Retrieve the contacts from the database
                DataTable contacts = contactDB.GetContacts();

                // Bind the contacts to the DataGridView
                dataGridView1.DataSource = contacts;

                // Optionally, update the total contacts label
                totalContacts.Text = contacts.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contacts: " + ex.Message);
            }
        }

        // This method will be triggered as the user types in the search box
        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = bigTextBox1.Text.Trim();

            // If there's search text, perform the search; otherwise, reload all contacts
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchContacts(searchText);
            }
            else
            {
                LoadContacts();
            }
        }

        // Method to search contacts by name, email, or phone
        private void SearchContacts(string searchText)
        {
            try
            {
                // Retrieve the filtered contacts from the database based on the search text
                DataTable filteredContacts = contactDB.SearchContacts(searchText);

                // Bind the filtered contacts to the DataGridView
                dataGridView1.DataSource = filteredContacts;

                // Optionally, update the total contacts label
                totalContacts.Text = filteredContacts.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching contacts: " + ex.Message);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}