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
    public class PersistentEmployee : PersistentUser, IPersistentEmployee
    {
        public bool AddTicket(Ticket t)
        {
            bool add = true;
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
                SqlCommand actualizare = new SqlCommand("insert into Tickets values(" +t.TrainNo +", '" +t.OriginStation +"', '" +t.DestinationStation +"', " +t.Duration +", " +t.Seats +", " +t.Price +", " +t.Id +")", connection);
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

        public bool DeleteTicket(int ticketId)
        {
            bool delete = true;
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
                SqlCommand actualizare = new SqlCommand("delete from Tickets where tickedId = " +ticketId, connection);
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


        public bool UpdateTicket(Ticket t, int ticketId)
        {
            bool update = true;
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
                SqlCommand actualizare = new SqlCommand("update Tickets set trainNo = " + t.TrainNo + ", originStation ='" + t.OriginStation + "', destinationStation = '" + t.DestinationStation + "', duration = " + t.Duration + ", seats = " + t.Seats + ", price = " + t.Price + ", tickedId = " + t.Id + "where tickedId = " +ticketId , connection);
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

        public bool SellTicket(int ticketId, int isSell)
        {
            bool update = true;
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
                SqlCommand actualizare = new SqlCommand();
                if (isSell == 1)
                {
                    actualizare = new SqlCommand("update Tickets set seats = (seats - 1) where tickedId = " + ticketId, connection);
                }
                else
                {
                    actualizare = new SqlCommand("update Tickets set seats = (seats + 20) where tickedId = " + ticketId, connection);
                }
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
    }
}
