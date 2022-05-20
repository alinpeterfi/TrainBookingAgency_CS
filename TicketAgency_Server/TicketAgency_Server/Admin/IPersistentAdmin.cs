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
    public interface IPersistentAdmin 
    {
        [OperationContract]
        DataSet UserList();
        [OperationContract]
        bool UpdateUser(User user, string selectedUser);
        [OperationContract]
        bool DeleteUser(string selectedUser);
        [OperationContract]
        bool AddUser(User user);
    }
}
