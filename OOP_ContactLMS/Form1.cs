using System;
using System.Windows.Forms;

namespace OOP_ContactLMS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Get the entered phone number from the hopeTextBox2
            string phoneNumber = hopeTextBox2.Text.Trim();

            // Check if the phone number is empty
            if (string.IsNullOrEmpty(phoneNumber))
            {
                // Display a message and prevent login
                MessageBox.Show("Please enter a phone number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution to prevent login
            }

            // Create an instance of the ContactDB class
            ContactDB contactDB = new ContactDB();

            // Check if the phone number exists in the database
            if (contactDB.IsPhoneNumberExists(phoneNumber))
            {
                // Display a message and prevent login
                MessageBox.Show("This phone number is already registered. Please use a different phone number.", "Phone Number Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution to prevent login
            }

            // Proceed with login if the phone number does not exist
            // Create a new instance of MainPage
            MainPage mainPage = new MainPage();

            // Hide the current LoginPage
            this.Hide();

            // Show the MainPage
            mainPage.ShowDialog();

            // Close the LoginPage once MainPage is closed
            this.Close();
        }



        private void hopeTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

