using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TicketAgency_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectare la baza de date Firma ...");
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.ReaderQuotas.MaxArrayLength = System.Int32.MaxValue;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;
            try
            {
                //connections to database
                PersistentUser pUser = new PersistentUser();
                PersistentAdmin pAdmin = new PersistentAdmin();
                PersistentEmployee pEmployee = new PersistentEmployee();
                ServiceHost userHost = new ServiceHost(pUser);
                ServiceHost adminHost = new ServiceHost(pAdmin);
                ServiceHost employeeHost = new ServiceHost(pEmployee);
                userHost.AddServiceEndpoint(typeof(IPersistentUser), tcp, "net.tcp://" + s + ":52001/Tickets");
                userHost.Open();
                employeeHost.AddServiceEndpoint(typeof(IPersistentEmployee), tcp, "net.tcp://" + s + ":52001/Employees");
                employeeHost.Open();
                adminHost.AddServiceEndpoint(typeof(IPersistentAdmin), tcp, "net.tcp://" + s + ":52001/Users");
                adminHost.Open();
                Console.WriteLine("Conectare realizata.");
                pUser.TicketList();
                pEmployee.TicketList();
                pAdmin.UserList();
                Console.ReadLine();
                userHost.Close();
                adminHost.Close();
                employeeHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nu s-a realizat conectarea la baza de date. " + ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
