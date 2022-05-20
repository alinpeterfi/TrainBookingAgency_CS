using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    [ServiceContract]
    public interface IPersistentEmployee : IPersistentUser
    {
        [OperationContract]
        bool AddTicket(Ticket t);

        [OperationContract]
        bool DeleteTicket(int ticketId);

        [OperationContract]
        bool UpdateTicket(Ticket t, int ticketId);

        [OperationContract]
        bool SellTicket(int ticketId, int isSell);
    }
}
