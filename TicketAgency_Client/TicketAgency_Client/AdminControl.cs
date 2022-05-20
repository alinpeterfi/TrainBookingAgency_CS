using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAgency_Server;

namespace TicketAgency_Client
{
    public class AdminControl : UserControl
    {
        private IAdmin adminView;
        private IPersistentAdmin persistentAdmin;
        public AdminControl(IAdmin adminView) : base (adminView)
        {
            this.adminView = adminView;
            this.adminView.SetControl(this);
            this.createLinkAdmin();
        }
        public void createLinkAdmin()
        {
            ChannelFactory<IPersistentAdmin> employeeChannel;
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
            employeeChannel = new ChannelFactory<IPersistentAdmin>(tcp, "net.tcp://" + s + ":52001/Users");
            try
            {
                this.persistentAdmin = employeeChannel.CreateChannel();
                this.createTicketsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
