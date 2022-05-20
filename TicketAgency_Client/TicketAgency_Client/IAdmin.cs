using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketAgency_Server;

namespace TicketAgency_Client
{
    public interface IAdmin : IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string Role { get; set; }
        void SetControl(AdminControl adminControl);
        void ReinitializeUserList();
        void AddUser(User u);
    }
}
