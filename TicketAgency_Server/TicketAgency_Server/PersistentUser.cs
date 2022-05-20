using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    public class PersistentUser : IPersistentUser
    {
        public DataSet TicketList()
        {
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Tickets"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand vizualizare = new SqlCommand("Select * from Tickets", connection);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "viewTickets");
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

        public DataSet TicketSearch(int ticketId)
        {
            SqlConnection connection = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["Tickets"].ConnectionString;
                connection = new SqlConnection(s);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                {
                    connection.Close();
                    connection.Open();
                }
                SqlCommand vizualizare = new SqlCommand("Select * from Tickets where tickedId = '" +ticketId +"'", connection);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "viewTicketSearch");
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
