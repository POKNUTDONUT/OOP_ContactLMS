using System;
using System.Windows.Forms;

namespace OOP_ContactLMS
{
    public partial class MainPage : Form
    {
        // Declare instances of the UserControls
        private ViewContactsControl viewContactsControl;
        private AddContactsControl addContactsControl;

        public MainPage()
        {
            InitializeComponent();

            // Initialize the UserControls
            viewContactsControl = new ViewContactsControl();
            addContactsControl = new AddContactsControl();

            // Load ViewContactsControl by default
            LoadUserControl(viewContactsControl);
        }

        // Event handler for the "LOGOUT" button (button1_Click_1)
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of LoginPage
            LoginPage loginpage = new LoginPage();

            // Hide the current MainPage
            this.Hide();

            // Show the loginPage as a dialog
            loginpage.ShowDialog();

            // Close the MainPage when LoginPage is closed
            this.Close();
        }

        // Method to load a UserControl into the panel
        private void LoadUserControl(UserControl userControl)
        {
            // Clear any existing controls in the panel before adding the new one
            metroPanel1.Controls.Clear();
            userControl.Dock = DockStyle.None;  // Ensure the UserControl fills the panel
            metroPanel1.Controls.Add(userControl);  // Add the UserControl to the panel
        }

        // Event handler for the "VIEW CONTACTS" MaterialButton (materialButton1)
        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Load the ViewContactsControl into the panel
            LoadUserControl(viewContactsControl);
        }

        // Event handler for the "ADD CONTACTS" MaterialButton (materialButton2)
        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Load the AddContactsControl into the panel
            LoadUserControl(addContactsControl);
            

        }

        // Placeholder event handler for the metroPanel (in case you have a paint event for it)
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Leave empty or handle any specific painting tasks you may have
        }
    }
}
