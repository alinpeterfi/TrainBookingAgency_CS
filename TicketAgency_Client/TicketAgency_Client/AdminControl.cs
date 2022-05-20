using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private DataTable users;
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
                this.createUsersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
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
        public void ViewUsers(string filter)
        {
            try
            {
                this.adminView.ReinitializeUserList();
                foreach (DataRow dr in this.users.Rows)
                {
                    User user = new User(dr["username"].ToString(), dr["password"].ToString(), dr["role"].ToString());
                    if(filter.Equals(dr["role"]))
                    this.adminView.AddUser(user);
                    else if(filter.Equals("ALL"))
                        this.adminView.AddUser(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool SearchUser(string username)
        {
            try
            {
                bool isTaken = false;
                foreach (DataRow dr in this.users.Rows)
                {
                    if (username.Equals(dr["username"].ToString()))
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

        public bool AddUser(User user)
        {
            if (this.persistentAdmin.AddUser(user))
            {
                this.createUsersList();
                this.ViewUsers("ALL");
                return true;
            }
            else
                return false;
        }
        public bool DeleteUser(string selectedUser)
        {
            if (this.persistentAdmin.DeleteUser(selectedUser))
            {
                this.createUsersList();
                this.ViewUsers("ALL");
                return true;
            }
            else
                return false;
        }
        public bool UpdateUser(User user, string selectedUser)
        {
            if (this.persistentAdmin.UpdateUser(user, selectedUser))
            {
                this.createUsersList();
                this.ViewUsers("ALL");
                return true;
            }
            else
                return false;
        }
    }
}
