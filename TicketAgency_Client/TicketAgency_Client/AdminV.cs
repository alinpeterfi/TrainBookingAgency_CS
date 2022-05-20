using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAgency_Client
{
    public partial class AdminV : UserV, IAdmin
    {
        public AdminV()
        {
            InitializeComponent();
        }
    }
}
