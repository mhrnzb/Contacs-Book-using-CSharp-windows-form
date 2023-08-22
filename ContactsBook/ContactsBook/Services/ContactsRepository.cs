using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ContactsBook
{
    class ContactsRepository : IContactsRepository
    {
        private string connectionString = " Data Source= .;Initial Catalog=Contact_DB;Integrated Security = true";

        public bool Delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContacts Where ContactID = @ID ";
                SqlCommand command = new SqlCommand(query, connection) ;
                command.Parameters.AddWithValue("@ID" , contactId);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string query = "Insert Into MyContacts(Name , Family ,Email ,Age , Mobile , Address) values(@Name , @Family ,@Email ,@Age , @Mobile , @Address ) ";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Email", mobile);
                command.Parameters.AddWithValue("@Age", email);
                command.Parameters.AddWithValue("@Mobile", age);
                command.Parameters.AddWithValue("@Address", address);

                connection.Open();
                command.ExecuteNonQuery();
                



                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public DataTable SelectAll()
        {
            string query = "Select * From MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
