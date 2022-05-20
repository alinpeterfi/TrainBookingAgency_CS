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
    public partial class AdminV : UserV, IAdmin
    {
        private AdminControl adminControl;
        public AdminV()
        {
            InitializeComponent();
            this.btnAuthentication.Text = "Logout";
        }

        public string Username
        {
            get
            {
                if (this.txtUser.Text.Length == 0)
                {
                    MessageBox.Show("No username!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtUser.Text;
            }
            set
            {
                this.txtUser.Text = value;
            }
        }
        public string Password
        {
            get
            {
                if (this.txtPassword.Text.Length == 0)
                {
                    MessageBox.Show("No password!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtPassword.Text;
            }
            set
            {
                this.txtPassword.Text = value;
            }
        }
        public string Role
        {
            get
            {
                if (this.cmbRoleUser.Text.Length == 0)
                {
                    MessageBox.Show("No role!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbRoleUser.Text;
            }
            set
            {
                this.cmbRoleUser.Text = value;
            }
        }

        public string RoleFilter
        {
            get
            {
                if (this.cmbFilterUser.Text.Length == 0)
                {
                    MessageBox.Show("No filter selected for displaying!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbFilterUser.Text;
            }
            set
            {
                this.cmbFilterUser.Text = value;
            }
        }

        public void AddUser(User u)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dataGridView1); //user data grid
            rand.Cells[0].Value = u.UserName;
            rand.Cells[1].Value = u.Password;
            rand.Cells[2].Value = u.Role;
            this.dataGridView1.Rows.Add(rand);
        }

        public void ReinitializeUserList()
        {
            this.dataGridView1.Rows.Clear();
        }

        public void SetControl(AdminControl adminControl)
        {
            this.adminControl = adminControl;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(this.Username != null && this.Password != null && this.Role != null)
            {
                User user = new User(this.Username, this.Password, this.Role);
                if (this.adminControl.SearchUser(user.UserName))
                    MessageBox.Show("Username already taken, use another one!");
                else
                {
                    if (!this.adminControl.AddUser(user))
                        MessageBox.Show("Adding user error!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.txtUser.Text = "";
                        this.txtPassword.Text = "";
                        this.cmbRoleUser.Text = "";
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = this.dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rand = this.dataGridView1.Rows[selectedRow];
                this.txtUser.Text = rand.Cells[0].Value.ToString();
                this.txtPassword.Text = rand.Cells[1].Value.ToString();
                this.cmbRoleUser.Text = rand.Cells[2].Value.ToString();
            }
            else
            {
                this.txtUser.Text = "";
                this.txtPassword.Text = "";
                this.cmbRoleUser.Text = "";
            }
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            if(this.RoleFilter != null)
            this.adminControl.ViewUsers(this.RoleFilter);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = this.dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rand = this.dataGridView1.Rows[selectedRow];
                string selectedRowUsername = rand.Cells[0].Value.ToString();
                var confirm = MessageBox.Show("Do you want to delete?",
                        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (!this.adminControl.DeleteUser(selectedRowUsername))
                    {
                        MessageBox.Show("Delete error", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("No user selected", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = this.dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rand = this.dataGridView1.Rows[selectedRow];
                string selectedRowUsername = rand.Cells[0].Value.ToString();
                var confirm = MessageBox.Show("Do you want to update?",
                        "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (this.Username != null && this.Password != null && this.Role != null)
                    {
                        User user = new User(this.Username, this.Password, this.Role);

                        if (!this.adminControl.UpdateUser(user, selectedRowUsername))
                            MessageBox.Show("Update error!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            this.txtUser.Text = "";
                            this.txtPassword.Text = "";
                            this.cmbRoleUser.Text = "";
                        }


                    }
                }
            }
            else
                MessageBox.Show("No ticked selected!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAuthentication_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserV userV = new UserV();
            userV.Visible = false;
            UserControl control = new UserControl(userV);
            userV.ShowDialog();
        }
    }
}
