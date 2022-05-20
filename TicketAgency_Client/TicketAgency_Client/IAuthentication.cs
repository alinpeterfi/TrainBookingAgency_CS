using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Client
{
    public interface IAuthentication
    {
        void SetControl(AuthenticationControl authControl);
    }
}
