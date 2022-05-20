using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketAgency_Server;

namespace TicketAgency_Client
{
    public interface IUser
    {
        void SetControl(UserControl userControl);
        void ReinitializeList();
        void AddTicket(Ticket t);
       
    }
}
