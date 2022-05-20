using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketAgency_Server;
namespace TicketAgency_Client
{
    public interface IEmployee : IUser
    {
        int TrainNo { get; set; }
        string OriginStation { get; set; }
        string DestinationStation { get; set; }
        int Duration { get; set; }
        int Seats { get; set; }
        double Price { get; set; }
        int Id { get; set; }
        void SetControl(EmployeeControl empControl);
    }
}
