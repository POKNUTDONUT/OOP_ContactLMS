using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace OOP_ContactLMS
{
    public class ContactDB
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=ContactLMS;Integrated Security=True";

        // Get all contacts from the database
        public DataTable GetContacts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Contacts", conn);
                DataTable contactsTable = new DataTable();
                adapter.Fill(contactsTable);
                return contactsTable;
            }
        }

        // Get a single contact by its ID
        public Contact GetContactByID(int contactID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactID", contactID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contact
                            {
                                ContactID = (int)reader["ContactID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                CompanyName = reader["CompanyName"].ToString(),
                                Address = reader["Address"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool IsPhoneNumberExists(string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Contacts WHERE PhoneNumber = @PhoneNumber";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        // Add a new contact to the database
        public void AddContact(string firstName, string lastName, string email, string phone, string company, string address)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Contacts (FirstName, LastName, Email, PhoneNumber, CompanyName, Address) " +
                               "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @CompanyName, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@CompanyName", company);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Update an existing contact in the database
        public void UpdateContact(int contactID, string firstName, string lastName, string email, string phone, string company, string address)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Contacts SET FirstName=@FirstName, LastName=@LastName, Email=@Email, PhoneNumber=@PhoneNumber, " +
                               "CompanyName=@CompanyName, Address=@Address WHERE ContactID=@ContactID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactID", contactID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@CompanyName", company);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete a contact from the database
        public void DeleteContact(int contactID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Contacts WHERE ContactID=@ContactID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactID", contactID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchContacts(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM Contacts 
                                 WHERE FirstName LIKE @searchText 
                                 OR LastName LIKE @searchText 
                                 OR Email LIKE @searchText 
                                 OR PhoneNumber LIKE @searchText";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable filteredContacts = new DataTable();
                adapter.Fill(filteredContacts);
                return filteredContacts;
            }
        }
    }


    // Contact class representing a contact record
    public class Contact
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
