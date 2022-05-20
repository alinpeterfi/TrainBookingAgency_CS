using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

namespace TicketAgency_Server
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class PersistentAdmin : IPersistentAdmin
    {
        public bool AddUser(User user)
        {
            bool add = true;
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand actualizare = new SqlCommand("insert into Users values('" +user.UserName+"', '" +user.Password +"', '" +user.Role +"')", connection);
                if (actualizare.ExecuteNonQuery() == 0)
                    add = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                add = false;
            }
            return add;
        }

        public bool DeleteUser(string selectedUser)
        {
            bool delete = true;
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand actualizare = new SqlCommand("delete from Users where username = '" +selectedUser +"'", connection);
                if (actualizare.ExecuteNonQuery() == 0)
                    delete = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                delete = false;
            }
            return delete;
        }

        public bool UpdateUser(User user, string selectedUser)
        {
            bool update = true;
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand actualizare = new SqlCommand("update Users set username = '" + user.UserName + "', password = '" + user.Password + "', role = '" + user.Role + "'" +" where username = '" +selectedUser +"'", connection);
                if (actualizare.ExecuteNonQuery() == 0)
                    update = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                update = false;
            }
            return update;
        }

        public DataSet UserList()
        {
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand vizualizare = new SqlCommand("Select * from Users", connection);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "viewUsers");
                connection.Close();
                Console.WriteLine(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
