using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    public class User
    {
        private string userName;
        private string password;
        private string role;

        public User()
        {
            this.userName = "";
            this.password = "";
            this.role = "";
        }

        public User(string user, string password, string role)
        {
            this.userName = user;
            this.password = password;
            this.role = role;
        }

        public User(User u)
        {
            this.userName = u.userName;
            this.password = u.password;
            this.role = u.role;
        }
        public String UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public String Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
    }
    }
