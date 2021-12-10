using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRunwayLR
{
    public partial class frmAppBooking : Form
    {

        SqlDataAdapter daCustomers, daTreatments, daRooms, daBooking, daBokingDet, daBookedAppointments;
        DataSet dsRunway = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails, cmdTreatmentDetails, cmdRoomDetails;


        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingDet, cmdBBookedAppointments, cmdBTreatments;

  

        DataRow drCustomer;

       

        String sqlCustomerDetails, sqlTreatmentDetails, sqlRoomDetails, sqlBooking, sqlBookingDet, sqlBookedAppointments;

   

        String connStr;



        /* put under dataadapter and ds set up
          string[] times = { "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
         "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
         "16:00:00", "16:30:00", "17:00:00", "17:30:00" };*/
        public frmAppBooking()
        {
            InitializeComponent();
        }


        private void frmAppBooking_SizeChanged(object sender, EventArgs e)
        {
        //    tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        private void frmAppBooking_Load(object sender, EventArgs e)
        {

            lblBookingDatee.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;
            connStr = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";

            conn = new SqlConnection(connStr);

            sqlCustomerDetails = @"Select * from Customer order by CustomerSurname";
            daCustomers = new SqlDataAdapter(sqlCustomerDetails, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomers);
            daCustomers.FillSchema(dsRunway   , SchemaType.Source, "Customer");
            daCustomers.Fill(dsRunway, "Customer");
            populateCustomers();

            sqlTreatmentDetails = @"Select * from Treatment order by TreatmentDesc";
            daTreatments = new SqlDataAdapter(sqlTreatmentDetails, connStr);
            cmdBTreatments = new SqlCommandBuilder(daTreatments);
            daTreatments.FillSchema(dsRunway, SchemaType.Source, "Treatment");
            daTreatments.Fill(dsRunway, "Treatment");
            populateTreatments();


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

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustNo = int.Parse(cmbCustomer.Text.Substring(cmbCustomer.Text.Length - 7, 5));
            drCustomer = dsRunway.Tables["Customer"].Rows.Find(CustNo);
            lblCust1.Text = drCustomer["TelNo"].ToString();
            lblCust2.Text = drCustomer["Email"].ToString();
            lblCust3.Text = drCustomer["Postcode"].ToString();

            dtpStartDate.Enabled = true;
        }



        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpTime.Enabled = true;
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


        private void populateCustomers()
        {
            int noRows = dsRunway.Tables["Customer"].Rows.Count;
            cmbCustomer.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["customer"].Rows)
            {
                cmbCustomer.Items.Add(dr["CustomerSurname"].ToString() + ", " + dr["CustomerForename"].ToString() + " (" + dr["CustomerNo"].ToString() + " )");
            }
        }
          
        private void populateTreatments()
        {
            int noRows = dsRunway.Tables["Treatment"].Rows.Count;
            cmbTreatment.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["Treatment"].Rows)
            {
                cmbTreatment.Items.Add(dr["TreatmentDesc"].ToString() + ", "+ " (" + dr["TreatmentNo"].ToString() + " )");
            }
        }
    }
}

