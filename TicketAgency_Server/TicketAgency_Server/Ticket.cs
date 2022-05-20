using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    public class Ticket : Train
    {
        private int id;
        private int seats;
        private double price;

        public Ticket() : base()
        {
            this.id = 0;
            this.seats = 0;
            this.price = 0;
        }

        public Ticket(int trainNo, string originStation, string destinationStation, int duration, int seats, double price, int id) : base(trainNo, originStation, destinationStation, duration)
        {
            this.seats = seats;
            this.price = price;
            this.id = id;
        }

        public Ticket(Ticket t)
        {
            this.trainNo = t.trainNo;
            this.originStation = t.originStation;
            this.destinationStation = t.destinationStation;
            this.duration = t.duration;
            this.seats = t.seats;
            this.price = t.price;
            this.id = t.id;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Seats
        {
            get { return this.seats; }
            set { this.seats = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
