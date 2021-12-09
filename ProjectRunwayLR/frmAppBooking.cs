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
    public partial class frmAppBooking : Form
    {


        /* put under dataadapter and ds set up
          string[] times = { "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
         "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
         "16:00:00", "16:30:00", "17:00:00", "17:30:00" };*/
        public frmAppBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmAppBooking_SizeChanged(object sender, EventArgs e)
        {
        //    tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        private void frmAppBooking_Load(object sender, EventArgs e)
        {



            /* add in tooo for times
             * for (int r = 0; r <= 16; r++)
            {
                dgvAppointments.Rows.Add(new object[] { "", "" });
                if (r % 2 == 0)
                {

                    dgvAppointments.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".00";
                }
                else
                {
                    dgvAppointments.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".30";
                }
            } */
            //   tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void tabApp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(255, 250, 237, 174);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 250, 237, 174);

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Standard;

        }
    }
}

