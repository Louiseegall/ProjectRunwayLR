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
        SqlDataAdapter daAppointment, daStaffAppointment, daStaff;
        SqlConnection conn;
        SqlCommand cmdAppointment, cmdStaffAppointment, cmdStaff;
        SqlCommandBuilder cmdBAppointment, cmdBStaffAppointment, cmdBStaff;
        DataRow drAppointment, drStaffAppointment, drStaff;
        String sqlAppointments, sqlStaffAppointment, sqlStaff, connStr;
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
            connStr = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";
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
            sqlAppointments = @"select * from Appointment a where (a.AppointmentDate between @StartDate and @EndDate)";
            sqlStaff = @"select * from Staff";
            sqlStaffAppointment = @"select * from StaffAppointment";
            cmdAppointment = new SqlCommand(sqlAppointments, conn);
            cmdAppointment.Parameters.Add("@StartDate", SqlDbType.SmallDateTime);
            cmdAppointment.Parameters.Add("@EndDate", SqlDbType.SmallDateTime);
            daAppointment = new SqlDataAdapter(cmdAppointment);
            daAppointment.FillSchema(dsRunway, SchemaType.Source, "StaffAppointment");
        }

        private void dtpBookingsStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime();
            DateTime d = dtpBookingsStartDate.Value;

            if(dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Monday"))
            {
                startDate = d.Add(TimeSpan.FromDays(0));
            }
            else if(dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Tuesday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-1));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Wednesday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-2));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Thursday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-3));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Friday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-4));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Saturday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-5));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Sunday"))
            {
                startDate = d.Add(TimeSpan.FromDays(-6));
            }
            monStartDate = startDate;

            dgvAppointments.Columns["colMon"].HeaderText = "Monday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colTue"].HeaderText = "Tuesday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colWed"].HeaderText = "Wednesday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colThur"].HeaderText = "Thursday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colFri"].HeaderText = "Friday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colSat"].HeaderText = "Saturday" + startDate.ToShortDateString();
            dgvAppointments.Columns["colSun"].HeaderText = "Sunday" + startDate.ToShortDateString();

            if (!formLoad)
                populateGrid2(currentWeek, monStartDate);
            else
                formLoad = false;
        }

        private void populateGrid2(DateTime[] currentWeek, DateTime monStartDate)
        {
            bool ok = true;
            try
            {
                if(ok)
                {
                    dsRunway.Tables["Appointments"].Clear();

                    for (int i = 0; i <7; i++)
                    {
                        for(int j = 0; j <16; j++)
                        {
                            dgvAppointments.Rows[j].Cells[i].Value = DBNull.Value;
                            dgvAppointments.Rows[j].Cells[i].Style.BackColor = Color.White;
                        }
                    }
                    cmdAppointment.Parameters["@StartDate"].Value = monStartDate.Date;
                    cmdAppointment.Parameters["@EndDate"].Value = monStartDate.AddDays(7).Date;

                    currentWeek[0] = monStartDate.Date;
                    currentWeek[1] = monStartDate.AddDays(1).Date;
                    currentWeek[2] = monStartDate.AddDays(2).Date;
                    currentWeek[3] = monStartDate.AddDays(3).Date;
                    currentWeek[4] = monStartDate.AddDays(4).Date;
                    currentWeek[5] = monStartDate.AddDays(5).Date;
                    currentWeek[6] = monStartDate.AddDays(6).Date;

                    daAppointment.Fill(dsRunway, "Appointments");

                }
                foreach(DataRow dr in dsRunway.Tables["Appointments"].Rows)
                {
                    string starttime = (dr["TimeStart"].ToString());

                    for(int i = 0; i < 7; i++)
                    {
                        if(Convert.ToDateTime(dr["DateStart"]).ToShortDateString().Equals(currentWeek[i].ToShortDateString()))
                        {
                            for(int j = 0; j < 16; j++)
                            {
                                if(times[j].Equals(starttime))
                                {
                                    dgvAppointments.Rows[j].Cells[i].Style.BackColor = Color.Green;
                                    dgvAppointments.Rows[j].Cells[i].Value = dr["AppointmentNo"].ToString();

                                    for(int k = 1; k < Convert.ToInt32(dr["NoSlots"]); k++)
                                    {
                                        dgvAppointments.Rows[j + k].Cells[i].Style.BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(System.Data.SqlTypes.SqlTypeException)
            {
                ok = false;
            }
        }

    }
}
