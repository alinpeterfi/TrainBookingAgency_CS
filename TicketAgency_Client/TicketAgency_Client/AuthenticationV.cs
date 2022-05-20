using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAgency_Server;

namespace TicketAgency_Client
{
    public partial class AuthenticationV : Form, IAuthentication
    {
        private AuthenticationControl authControl;
        public AuthenticationV()
        {
            InitializeComponent();
        }

        public void SetControl(AuthenticationControl authControl)
        {
            this.authControl = authControl;
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            User user = this.authControl.findUser(this.txtUsername.Text, this.txtPassword.Text);
            if(user != null)
            {
                this.Hide();
                this.authControl.login(user.UserName);
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }
    }
}
