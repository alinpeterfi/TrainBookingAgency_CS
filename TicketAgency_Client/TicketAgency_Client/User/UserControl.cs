using TicketAgency_Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketAgency_Client
{
    public class UserControl
    {
        protected DataTable tickets;
        protected IUser userView;
        protected IPersistentUser persistentUser;
        public UserControl(IUser userView)
        {
            this.userView = userView;
            this.userView.SetControl(this);
            this.tickets = new DataTable();
            this.createLink();
        }


        //create link
        protected void createLink()
        {
            ChannelFactory<IPersistentUser> userChannel;
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            userChannel = new ChannelFactory<IPersistentUser>(tcp, "net.tcp://" + s + ":52001/Tickets");
            try
            {
                this.persistentUser = userChannel.CreateChannel();
                this.createTicketsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //get trains by number
       public List<Ticket> filterTrainByNumber(int trainNo)
        {
            try
            {
                    List<Ticket> trains = new List<Ticket>();
                    foreach (DataRow dr in this.tickets.Rows)
                    {
                        if (trainNo == Convert.ToInt32(dr["trainNo"]))
                            trains.Add(new Ticket(Convert.ToInt32(dr["trainNo"]), dr["originStation"].ToString(), dr["destinationStation"].ToString(), Convert.ToInt32(dr["duration"]), Convert.ToInt32(dr["seats"]), Convert.ToDouble(dr["price"]), Convert.ToInt32(dr["tickedId"])));
                    }
                    if (trains.Count > 0)
                        return trains;
                    else
                        return null;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //get trains by stations
        public List<Ticket> filterTrainByStation(String originStation, String destinationStation)
        {
            try
            {
                if (originStation != null && destinationStation != null)
                {
                    List<Ticket> trains = new List<Ticket>();
                    foreach (DataRow dr in this.tickets.Rows)
                    {
                        if (originStation.Equals(dr["originStation"]) && destinationStation.Equals(dr["destinationStation"]))
                            trains.Add(new Ticket(Convert.ToInt32(dr["trainNo"]), dr["originStation"].ToString(), dr["destinationStation"].ToString(), Convert.ToInt32(dr["duration"]), Convert.ToInt32(dr["seats"]), Convert.ToDouble(dr["price"]), Convert.ToInt32(dr["tickedId"])));
                    }
                    if (trains.Count > 0)
                        return trains;
                    else
                        return null;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        //fill the table with data
        protected void createTicketsList()
        {
            try
            {
                DataSet ds = this.persistentUser.TicketList();
                this.tickets = ds.Tables["viewTickets"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Authentication()
        {
            AuthenticationV authV = new AuthenticationV();
            authV.Visible = false;
            AuthenticationControl control = new AuthenticationControl(authV);
            authV.ShowDialog();
        }

        //update data grid view
        public void View()
        {
            try
            {
                this.userView.ReinitializeList();
                foreach (DataRow dr in this.tickets.Rows)
                {
                    Ticket ticket = new Ticket(Convert.ToInt32(dr["trainNo"]), dr["originStation"].ToString(), dr["destinationStation"].ToString(), Convert.ToInt32(dr["duration"]), Convert.ToInt32(dr["seats"]), Convert.ToDouble(dr["price"]), Convert.ToInt32(dr["tickedId"]));
                    this.userView.AddTicket(ticket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
