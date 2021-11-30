using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectRunwayLR
{
    public partial class frmSchedule : Form
    {
        DateTime monStartDate = new DateTime();
        DataSet dsRunway = new DataSet();
        SqlDataAdapter daAppointment;
        SqlConnection conn;
        SqlCommand cmdAppointment;
        SqlCommandBuilder cmdBAppointment;
        DataRow drAppointment;
        String sqlAppointments, connStr;
        Boolean formLoad = true;

        DateTime[] currentWeek = new DateTime[]
        {
            new DateTime(2021,11,24),
            new DateTime(2021,11,25),
            new DateTime(2021,11,26),
            new DateTime(2021,11,27),
            new DateTime(2021,11,28),
            new DateTime(2021,11,29),
            new DateTime(2021,11,30)
        };

        string[] times = { "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
         "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
         "16:00:00", "16:30:00", "17:00:00", "17:30:00" };

        public frmSchedule()
        {
            InitializeComponent();
        }


        private void frmSchedule_Load(object sender, EventArgs e)
        {
            dtpBookingsStartDate.MinDate = DateTime.Now;
            connStr = @"Data Source = .; Initia Catalog = Runway; Integrated Security = true";
            conn = new SqlConnection(connStr);

            for (int r = 0; r <= 16; r++)
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
            }
            sqlAppointments = @"select * from Appointment a where (a.appontmentdate between @StartDate and @EndDate)";
            cmdAppointment = new SqlCommand(sqlAppointments, conn);
            cmdAppointment.Parameters.Add("@StartDate", SqlDbType.SmallDateTime);
            cmdAppointment.Parameters.Add("@EndDate", SqlDbType.SmallDateTime);
            daAppointment = new SqlDataAdapter(cmdAppointment);
            daAppointment.FillSchema(dsRunway, SchemaType.Source, "Appointment");
        }

    }
}
