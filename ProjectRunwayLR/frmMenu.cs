using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRunwayLR
{
    public partial class frmMenu : Form
    {
        Boolean vis;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            tmrMenu.Enabled = true;
            vis = !vis;
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (vis)
            {
                if (pnlMenu.Left > -1000)
                {
                    pnlMenu.Left -= 80;
                

                }
                else
                {
                    tmrMenu.Enabled = false;
                }
            }
            else
            {
                if (pnlMenu.Left < 0)
                {
                    pnlMenu.Left += 80;

                }
                else
                {
                    tmrMenu.Enabled = false;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
         }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentBooking Check = new frmAppointmentBooking();
            Check.Show();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers Check = new frmCustomers();
            Check.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff Check = new frmStaff();
            Check.Show();
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            frmTreatment Check = new frmTreatment();
            Check.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom Check = new frmRoom();
            Check.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment Check = new frmPayment();
            Check.Show();
        }
    }
}
