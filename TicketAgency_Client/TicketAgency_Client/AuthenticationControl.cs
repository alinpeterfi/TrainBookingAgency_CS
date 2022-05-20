using System;
using TicketAgency_Server;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace TicketAgency_Client
{
    public class AuthenticationControl
    {
        private DataTable users;
        private IAuthentication authView;
        private IPersistentAdmin persistentAdmin;

        public AuthenticationControl(IAuthentication authView)
        {
            this.authView = authView;
            this.authView.SetControl(this);
            this.users = new DataTable();
            this.createLink();
        }
        //create link
        private void createLink()
        {
            ChannelFactory<IPersistentAdmin> adminChannel;
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
            adminChannel = new ChannelFactory<IPersistentAdmin>(tcp, "net.tcp://" + s + ":52001/Users");
            try
            {
                this.persistentAdmin = adminChannel.CreateChannel();
                this.createUsersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //fill the table with data
        private void createUsersList()
        {
            try
            {
                DataSet ds = this.persistentAdmin.UserList();
                this.users = ds.Tables["viewUsers"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //find user in database function
        public User findUser(string username, string password)
        {
            if(username != null && password != null)
            {
                foreach(DataRow dr in this.users.Rows)
                {
                    if(dr["username"].Equals(username) && dr["password"].Equals(password))
                    {
                        return new User(dr["username"].ToString(), dr["password"].ToString(), dr["role"].ToString());
                    }
                }
                return null;
            }
            else
            {
                MessageBox.Show("Empty fields!");
            }

            return null;
        }
        
        public void login(string role)
        {
            if (role.ToUpper().Equals("ADMIN"))
            {
                AdminV admV = new AdminV();
                admV.Visible = false;
                UserControl control = new AdminControl(admV);
                admV.ShowDialog();
            }
            else
            {
                EmployeeV empV = new EmployeeV();
                empV.Visible = false;
                UserControl control = new EmployeeControl(empV);
                empV.ShowDialog();
            }

            //

        }
        
    }//class
}
