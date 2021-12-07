using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRunwayLR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogIn());
            //Application.Run(new frmExampleMenu());
            //Application.Run(new Form3());
            Application.Run(new frmMainMenu());
          //  Application.Run(new frmCustomer());
            //Application.Run(new frmMenu());
            //Application.Run(new frmCustomers());
            //Application.Run(new frmStaff());
            //Application.Run(new frmTreatment());
            //Application.Run(new frmAppointment());
            //Application.Run(new frmPayment());
            //Application.Run(new frmRoom());
            //Application.Run(new Form1());
        }
    }
}
