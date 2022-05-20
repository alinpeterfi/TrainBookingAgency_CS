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
    public interface IPersistentUser
    {
        [OperationContract]
        DataSet TicketList();
    }
}
