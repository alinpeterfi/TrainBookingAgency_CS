using System;
using TicketAgency_Server;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAgency_Client
{
    public partial class EmployeeV : UserV, IEmployee
    {
        private EmployeeControl empControl;
        public EmployeeV()
        {
            InitializeComponent();
            this.btnAuthentication.Text = "Logout";
        }

        public int TrainNo { 
            get { if (this.txtTrainE.Text.Length == 0)
                {
                    MessageBox.Show("No train number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        int m = Convert.ToInt32(this.txtTrainE.Text);
                        if (m > 0)
                            return m;
                        else
                        {

                            MessageBox.Show("Incorrect train number", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Train number must be int!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
                    

            } 
            set {
                this.txtTrainE.Text = value.ToString();
            } }

        public int Duration
        {
            get
            {
                if (this.txtDurationE.Text.Length == 0)
                {
                    MessageBox.Show("No duration!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        int m = Convert.ToInt32(this.txtDurationE.Text);
                        if (m > 0)
                            return m;
                        else
                        {

                            MessageBox.Show("Incorrect duration number", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Duration must be int!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }


            }
            set
            {
                this.txtDurationE.Text = value.ToString();
            }
        }

        public int Seats
        {
            get
            {
                if (this.txtSeatsE.Text.Length == 0)
                {
                    MessageBox.Show("No seats!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        int m = Convert.ToInt32(this.txtSeatsE.Text);
                        if (m > 0)
                            return m;
                        else
                        {

                            MessageBox.Show("Incorrect seats number", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Seats must be int!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }


            }
            set
            {
                this.txtSeatsE.Text = value.ToString();
            }
        }
      

        public int Id
        {
            get
            {
                if (this.txtIdE.Text.Length == 0)
                {
                    MessageBox.Show("No id!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        int m = Convert.ToInt32(this.txtIdE.Text);
                        if (m > 0)
                            return m;
                        else
                        {

                            MessageBox.Show("Incorrect id number", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Id must be int!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }


            }
            set
            {
                this.txtIdE.Text = value.ToString();
            }
        }

        
       
        public double Price
        {
            get
            {
                if (this.txtPriceE.Text.Length == 0)
                {
                    MessageBox.Show("No seats!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        double m = Convert.ToDouble(this.txtPriceE.Text);
                        if (m > 0)
                            return m;
                        else
                        {

                            MessageBox.Show("Incorrect price number", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Price must be double!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }


            }
            set
            {
                this.txtPriceE.Text = value.ToString();
            }
        }

        public string OriginStation
        {
            get
            {
                if (this.txtOriginE.Text.Length == 0)
                {
                    MessageBox.Show("No origin station!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtOriginE.Text;
            }
            set
            {
                this.txtOriginE.Text = value;
            }
        }

        public string DestinationStation
        {
            get
            {
                if (this.txtDestinationE.Text.Length == 0)
                {
                    MessageBox.Show("No destination station!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtDestinationE.Text;
            }
            set
            {
                this.txtDestinationE.Text = value;
            }
        }



        public void SetControl(EmployeeControl empControl)
        {
            this.empControl = empControl;
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if (this.OriginStation != null && this.DestinationStation != null && this.TrainNo != -1 && this.Duration != -1 && this.Seats != -1 && this.Price != -1 && this.Id != -1)
            {
                Ticket ticket = new Ticket(this.TrainNo, this.OriginStation, this.DestinationStation, this.Duration, this.Seats, this.Price, this.Id);
                if (this.empControl.SearchId(ticket.Id))
                    MessageBox.Show("Ticket id taken, use antoher one!");
                else
                {
                    if (!this.empControl.AddTicket(ticket))
                        MessageBox.Show("Adding ticket error!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.txtDestinationE.Text = "";
                        this.txtOriginE.Text = "";
                        this.txtSeatsE.Text = "";
                        this.txtDurationE.Text = "";
                        this.txtPriceE.Text = "";
                        this.txtIdE.Text = "";
                        this.txtTrainE.Text = "";
                    }
                }
            }
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if(this.dgvUser.SelectedRows.Count > 0)
            {
                int selectedRow = this.dgvUser.SelectedRows[0].Index;
                DataGridViewRow rand = this.dgvUser.Rows[selectedRow];
                int selectedRowTicketId = Convert.ToInt32(rand.Cells[6].Value);
                var confirm = MessageBox.Show("Do you want to update?",
                        "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (this.OriginStation != null && this.DestinationStation != null && this.TrainNo != -1 && this.Duration != -1 && this.Seats != -1 && this.Price != -1 && this.Id != -1)
                    {
                        Ticket ticket = new Ticket(this.TrainNo, this.OriginStation, this.DestinationStation, this.Duration, this.Seats, this.Price, this.Id);

                        
                        
                            if (!this.empControl.UpdateTicket(ticket, selectedRowTicketId))
                                MessageBox.Show("Update error!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                this.txtDestinationE.Text = "";
                                this.txtOriginE.Text = "";
                                this.txtSeatsE.Text = "";
                                this.txtDurationE.Text = "";
                                this.txtPriceE.Text = "";
                                this.txtIdE.Text = "";
                                this.txtTrainE.Text = "";
                            }
                        

                        }
                }
            }
            else
                MessageBox.Show("No ticked selected!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (this.dgvUser.SelectedRows.Count > 0)
            {
                int selectedRow = this.dgvUser.SelectedRows[0].Index;
                DataGridViewRow rand = this.dgvUser.Rows[selectedRow];
                int selectedRowTicketId = Convert.ToInt32(rand.Cells[6].Value);
                var confirm = MessageBox.Show("Do you want to delete?",
                        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (!this.empControl.DeleteTicket(selectedRowTicketId))
                    {
                        MessageBox.Show("Delete error", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("No ticket selected", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SellRefill(int isSell)
        {
            if (this.dgvUser.SelectedRows.Count > 0)
            {
                int selectedRow = this.dgvUser.SelectedRows[0].Index;
                DataGridViewRow rand = this.dgvUser.Rows[selectedRow];
                int selectedRowTicketId = Convert.ToInt32(rand.Cells[6].Value);
                var confirm = MessageBox.Show("Do you want to sell ticket?",
                        "SELL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (isSell == 1)
                    {
                        if (!this.empControl.SellTicket(selectedRowTicketId, 1))
                        {
                            MessageBox.Show("Sell error", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (!this.empControl.SellTicket(selectedRowTicketId, 0))
                        {
                            MessageBox.Show("Refill error", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
                MessageBox.Show("No ticket selected", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellRefill(1);
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            SellRefill(0);
        }
        public override void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvUser.SelectedRows.Count > 0)
            {
                int selectedRow = this.dgvUser.SelectedRows[0].Index;
            DataGridViewRow rand = this.dgvUser.Rows[selectedRow];
                this.txtTrainE.Text = rand.Cells[0].Value.ToString();
                this.txtOriginE.Text = rand.Cells[1].Value.ToString();
                this.txtDestinationE.Text = rand.Cells[2].Value.ToString();
                this.txtDurationE.Text = rand.Cells[3].Value.ToString();
                this.txtSeatsE.Text = rand.Cells[4].Value.ToString();
                this.txtPriceE.Text = rand.Cells[5].Value.ToString();
                this.txtIdE.Text = rand.Cells[6].Value.ToString();
        }
            else
            {
                this.txtTrainE.Text = "";
                this.txtOriginE.Text = "";
                this.txtDestinationE.Text = "";
                this.txtDurationE.Text = "";
                this.txtSeatsE.Text = "";
                this.txtPriceE.Text = "";
                this.txtIdE.Text = "";
            }
}
        //logout button1
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

