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
    public class EmployeeControl : UserControl
    {
        private IEmployee empView;
        private IPersistentEmployee persistentEmployee;

        public EmployeeControl(IEmployee empView) : base(empView)
        {
            this.empView = empView;
            this.empView.SetControl(this);
            this.createLinkEmp();
            //base.createLink();
        }
        //create link
        private void createLinkEmp()
        {
            ChannelFactory<IPersistentEmployee> employeeChannel;
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
            employeeChannel = new ChannelFactory<IPersistentEmployee>(tcp, "net.tcp://" + s + ":52001/Employees");
            try
            {
                this.persistentEmployee = employeeChannel.CreateChannel();
                this.createTicketsList(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool SearchId(int ticketId)
        {
            try
            {
                bool isTaken = false;
                foreach (DataRow dr in this.tickets.Rows)
                {
                    if (ticketId == Convert.ToInt32(dr["tickedId"]))
                        isTaken = true;
                }
                    return isTaken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AddTicket(Ticket ticket)
        {
            if (this.persistentEmployee.AddTicket(ticket))
            {
                this.createTicketsList();
                this.View();
                return true;
            }
            else
                return false;
        }

        public bool DeleteTicket(int ticketId)
        {
            if (this.persistentEmployee.DeleteTicket(ticketId))
            {
                this.createTicketsList();
                this.View();
                return true;
            }
            return false;
        }

        public bool SellTicket (int ticketId, int isSell)
        {
            if(this.persistentEmployee.SellTicket(ticketId, isSell))
            {
                this.createTicketsList();
                this.View();
                return true;
            }
            return false;
        }

        public bool UpdateTicket(Ticket ticket, int selectedTicketId)
        {
            if (this.persistentEmployee.UpdateTicket(ticket, selectedTicketId))
            {
                this.createTicketsList();
                this.View();
                return true;
            }
            return false;
        }

    }
}
