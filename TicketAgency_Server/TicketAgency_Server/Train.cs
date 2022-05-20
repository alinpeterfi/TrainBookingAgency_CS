using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    public class Train
    {
        protected int trainNo;
        protected string originStation;
        protected string destinationStation;
        protected int duration;

        public Train()
        {
            this.trainNo = 0;
            this.destinationStation = "";
            this.originStation = "";
            this.duration = 0;
        }

        public Train(int trainNo, string originStation, string destinationStation, int duration)
        {
            this.trainNo = trainNo;
            this.originStation = originStation;
            this.destinationStation = destinationStation;
            this.duration = duration;
        }

        public Train(Train t)
        {
            this.trainNo = t.trainNo;
            this.originStation = t.originStation;
            this.destinationStation = t.destinationStation;
            this.duration = t.duration;
        }
        //setters and getters
        public int TrainNo
        {
            get { return this.trainNo; }
            set { this.trainNo = value; }
        }

        public string OriginStation
        {
            get { return this.originStation; }
            set { this.originStation = value; }
        }

        public string DestinationStation
        {
            get { return this.destinationStation; }
            set { this.destinationStation = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            return this.trainNo.ToString() + ";" + this.originStation + ";" + this.destinationStation + ";" + this.duration;
        }
    }
}
