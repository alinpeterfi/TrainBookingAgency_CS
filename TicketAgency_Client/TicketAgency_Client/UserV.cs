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
    public partial class UserV : Form, IUser
    {
        protected UserControl userControl;
        public UserV()
        {
            InitializeComponent();
        }

       

        public void AddTicket(Ticket t)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dgvUser);
            rand.Cells[0].Value = t.TrainNo;
            rand.Cells[1].Value = t.OriginStation;
            rand.Cells[2].Value = t.DestinationStation;
            rand.Cells[3].Value = t.Duration;
            rand.Cells[4].Value = t.Seats;
            rand.Cells[5].Value = t.Price;
            rand.Cells[6].Value = t.Id;
            this.dgvUser.Rows.Add(rand);
        }

        public void filterTrainByNumber(int ticketId)
        {
            throw new NotImplementedException();
        }

        public void ReinitializeList()
        {
            this.dgvUser.Rows.Clear();
        }

        public void SetControl(UserControl userControl)
        {
            this.userControl = userControl;
        }

        protected void btnListTrains_Click(object sender, EventArgs e)
        {
            this.userControl.View();
        }

        protected void btnSearchTrain_Click(object sender, EventArgs e)
        {
            int getTrainNo = Convert.ToInt32(this.txtTrainNo.Text);
            List<Ticket> trains = this.userControl.filterTrainByNumber(getTrainNo);
            if (trains != null)
            {
                this.ReinitializeList();
                foreach(Ticket t in trains) 
                this.AddTicket(t);
            }
            else
            {
                this.ReinitializeList();
                MessageBox.Show("The train does not exist!");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String getDestinationStation = this.cmbDestination.Text;
            String getOriginStation = this.cmbOrigin.Text;

            List<Ticket> trains = this.userControl.filterTrainByStation(getOriginStation, getDestinationStation);
            if (trains != null)
            {
                this.ReinitializeList();
                foreach (Ticket t in trains)
                    this.AddTicket(t);
            }
            else
            {
                this.ReinitializeList();
                MessageBox.Show("The train does not exist!");
            }
        }

        protected void btnAuthentication_Click(object sender, EventArgs e)
        {
            if (this.btnAuthentication.Text.Equals("AUTHENTICATION"))
            {
                this.Hide();
                this.userControl.Authentication();
            }
        }

        public virtual void dgvUser_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
