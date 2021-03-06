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
        DataSet dsRunway = new DataSet();
        SqlConnection conn;
        String connStr;


        public frmAppBooking()
        {
            InitializeComponent();
        }

        private void tabApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabApp.SelectedIndex == 2)
                populateEditTab();
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
            loadAddAppointment();
            loadSchedule();
            //   tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        #region Appointment Schedule

        SqlCommand cmdAppointment, cmdAppTreat;
        string sqlScheduleAppointment, sqlScheduleAppTreat, sqlRoom;
        SqlDataAdapter daScheduleAppointment, daScheduleAppTreat, daRoom;

        DateTime monStartDate = new DateTime();

        Boolean formLoad = true;

        DateTime[] currentWeek = new DateTime[]
        {
            new DateTime(2021,11,24),
             new DateTime(2021,11,25),
              new DateTime(2021,11,26),
               new DateTime(2021,11,27),
                new DateTime(2021,11,28),
                 new DateTime(2021,11,29),
                  new DateTime(2021,11,24),
                  new DateTime(2021,11,24)

        };


        //put under dataadapter and ds set up
        string[] times = { "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
         "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
         "16:00:00", "16:30:00", "17:00:00", "17:30:00" };

        private void loadSchedule()
        {
            sqlScheduleAppointment = @"Select * from Appointment where (AppointmentDate between @startDate and @endDate)";
            cmdAppointment = new SqlCommand(sqlScheduleAppointment, conn);
            cmdAppointment.Parameters.Add("@startDate", SqlDbType.Date);
            cmdAppointment.Parameters.Add("@endDate", SqlDbType.Date);//add
            daScheduleAppointment = new SqlDataAdapter(cmdAppointment);
            daScheduleAppointment.FillSchema(dsRunway, SchemaType.Source, "ScheduleAppointments");

            sqlScheduleAppTreat = @"Select AppointmentNo, Treatment.TreatmentNo,TreatmentTime, TreatmentDuration
from AppointmentTreatment 
join Treatment on AppointmentTreatment.TreatmentNo= Treatment.TreatmentNo
where (AppointmentNo =@AppointmentNo) and RoomNo = @RoomNo";
            cmdAppTreat = new SqlCommand(sqlScheduleAppTreat, conn);
            cmdAppTreat.Parameters.Add("@AppointmentNo", SqlDbType.Int);
            cmdAppTreat.Parameters.Add("@RoomNo", SqlDbType.Int);

            daScheduleAppTreat = new SqlDataAdapter(cmdAppTreat);
            daScheduleAppTreat.FillSchema(dsRunway, SchemaType.Source, "ScheduleAppTreat");


            sqlRoom = @"SELECT * from Room";
            daRoom = new SqlDataAdapter(sqlRoom, conn);
            daRoom.FillSchema(dsRunway, SchemaType.Source, "RoomSch");
            daRoom.Fill(dsRunway, "RoomSch");
            cmbDisplayRoomNo.DataSource = dsRunway.Tables["RoomSch"];
            cmbDisplayRoomNo.ValueMember = "RoomNo";// the index
            cmbDisplayRoomNo.DisplayMember = "RoomNo";// how its displayed 
         //   cmbDisplayRoomNo.SelectedIndex = 0;


            // add in tooo for times
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
            dtpBookingsStartDate.Value = DateTime.Now;
        }

        private void btnDeleteDisplay_Click(object sender, EventArgs e)
        {
          

            //delete apppointment treat

            //delete appoint
            // same as appointment populate Edit tab sort through get data row then delet data row then commit changes to db
            //chgeck eacxh row in appointment treatment table to se eif it matches that appoinmtnet for each

            int bookingID = -1;

            //    bookingClicked 
            if (dgvAppointments.SelectedCells.Count > 0)
            {
                if (dgvAppointments.SelectedCells[0].Value.ToString() != "")
                {
                    bookingID = Int32.Parse(dgvAppointments.SelectedCells[0].Value.ToString());  //must have booking id cell selected has value, result must be a booking id insdie it
                    //check booking id filled out
                }

            }

            if (bookingID > -1)  //check if booking id is chnage form -1
            {
                if (MessageBox.Show("Are You Sure You Want To Delete Booking Number: " 
                  +bookingID, "Delete Booking ",
                  MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {




                    DataRow drRa = dsRunway.Tables["Appointment"].Rows.Find(bookingID);

                    foreach (DataRow dr in dsRunway.Tables["AppointmentTreatment"].Rows)
                    {

                        if (dr["AppointmentNo"].ToString() == drRa["AppointmentNo"].ToString())
                        {
                            dr.Delete();//delete appointment treatment one at a time, updates

                        }
                    }

                    daBookingDetails.Update(dsRunway, "AppointmentTreatment");
                    drRa.Delete();
                    daBooking.Update(dsRunway, "Appointment");
                    updateSchedule();
                }

            }
        }
        private void populateGrid2(DateTime[] currentWeek, DateTime monStartDate)
        {
            bool ok = true;
            try
            {
                if (ok)
                {
                    dsRunway.Tables["ScheduleAppointments"].Clear();

                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 16; j++)
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

                    //daStaffAppointment.Fill(dsRunway, "StaffAppointment");
                    daScheduleAppointment.Fill(dsRunway, "ScheduleAppointments");

                }
                foreach (DataRow dr in dsRunway.Tables["ScheduleAppointments"].Rows)
                {


                    for (int i = 0; i < 7; i++)
                    {
                        if (Convert.ToDateTime(dr["AppointmentDate"]).ToShortDateString().Equals(currentWeek[i].ToShortDateString()))
                        {
                            cmdAppTreat.Parameters["@AppointmentNo"].Value = dr["AppointmentNo"];
                            cmdAppTreat.Parameters["@RoomNo"].Value = cmbDisplayRoomNo.SelectedValue;//replace with value from comboBox
                            //selected value = room no that is selected.

                            dsRunway.Tables["ScheduleAppTreat"].Rows.Clear();
                            daScheduleAppTreat.Fill(dsRunway, "ScheduleAppTreat");
                            
                            for (int j = 0; j < 16; j++)
                            {
                                foreach (DataRow tRow in dsRunway.Tables["ScheduleAppTreat"].Rows)
                                {
                                    string starttime = (tRow["TreatmentTime"].ToString());
                                    if (times[j].Equals(starttime))
                                    {
                                        dgvAppointments.Rows[j].Cells[i].Value = dr["AppointmentNo"].ToString();
                                        if (starttime == dr["AppointmentTime"].ToString())
                                        {
                                            dgvAppointments.Rows[j].Cells[i].Style.BackColor = Color.Goldenrod;
                                           
                                        }
                                        else
                                        {

                                            dgvAppointments.Rows[j].Cells[i].Style.BackColor = Color.Gold;
                                        }
                                        int start = j;

                                        int Duration = int.Parse(tRow["TreatmentDuration"].ToString());
                                        int end = start + Duration;
                                        if (start == j)
                                        {

                                            start++;

                                        }
                                        for (int k = start; k < end; k++)
                                        {
                                            dgvAppointments.Rows[k].Cells[i].Value = dr["AppointmentNo"].ToString();
                                            dgvAppointments.Rows[k].Cells[i].Style.BackColor = Color.Gold;
                                        }
                                        //start = end;
                                    }


                                    //for (int k = 1; k < Convert.ToInt32(dr["TreatmentDuration"]); k++)
                                    //{
                                    //    dgvAppointments.Rows[j + k].Cells[i].Style.BackColor = Color.LightGreen;
                                    //}
                                }
                            }
                        }
                    }
                }  
            }
            catch (System.Data.SqlTypes.SqlTypeException)
            {
                ok = false;
            }
            dgvAppointments.AutoResizeColumns();
        }
        private void dtpBookingsStartDate_ValueChanged(object sender, EventArgs e)
        {
            updateSchedule();
        }
        private void cmbDisplayRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dgvAppointments.Rows.Count>15)
            updateSchedule();
        }

        private void btnCancelDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You And Goodbye", "Close Runway Application");
              
            Application.Exit();
        }

        private void updateSchedule()
        {

            DateTime startDate = new DateTime();
            DateTime d = dtpBookingsStartDate.Value;

            if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Monday"))
            {
                startDate = d.Add(TimeSpan.FromDays(0));
            }
            else if (dtpBookingsStartDate.Value.DayOfWeek.ToString().Equals("Tuesday"))
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

            dgvAppointments.Columns["Monday"].HeaderText = "Monday\n " + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Tuesday"].HeaderText = "Tuesday\n " + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Wednesday"].HeaderText = "Wednesday\n " + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Thursday"].HeaderText = "Thursday\n" + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Friday"].HeaderText = "Friday\n " + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Saturday"].HeaderText = "Saturday\n" + startDate.ToShortDateString();
            startDate = startDate.Add(TimeSpan.FromDays(1));
            dgvAppointments.Columns["Sunday"].HeaderText = "Sunday\n" + startDate.ToShortDateString();
            
            // if (!formLoad)
            populateGrid2(currentWeek, monStartDate);
            //else
            //    formLoad = false;
        }
        //int bookingClicked = -1;
        //private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{        
        //    if (dgvAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        bookingClicked = int.Parse(dgvAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

        //    }
        //    else bookingClicked = -1;
        //}
        #endregion


        #region Add Booking

        SqlDataAdapter daCustomers, daTreatments, daStaff, daRoomsAppointments, daRooms, daBooking, daBookings, daBookingDetails, daBookedAppointments;


        SqlCommand cmdCustomerDetails, cmdTreatmentDetails, cmdRoomDetails, cmdRoomAppointmentDetails;
        SqlCommandBuilder cmdBCustomer, cmdBStaff, cmdBBookedRooms, cmdBBookingDetails, cmdBTreatments, cmdBBooking;

     
        DataRow drCustomer, drTreatment;

       

        String sqlCustomerDetails, sqlTreatmentDetails, sqlStaffDetails, sqlRoomDetails, sqlRooms, sqlBooking, sqlBookingDetails, sqlBookings;


        private void loadAddAppointment()
        {
            sqlCustomerDetails = @"Select * from Customer order by CustomerSurname";
            daCustomers = new SqlDataAdapter(sqlCustomerDetails, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomers);
            daCustomers.FillSchema(dsRunway, SchemaType.Source, "Customer");
            daCustomers.Fill(dsRunway, "Customer");
            populateCustomers();

            //sqlStaffDetails = @"Select * from Staff order by StaffSurname";
            //daStaff = new SqlDataAdapter(sqlStaffDetails, connStr);
            //cmdBStaff = new SqlCommandBuilder(daStaff);
            //daStaff.FillSchema(dsRunway, SchemaType.Source, "Staff");
            //daStaff.Fill(dsRunway, "Staff");
            //populateStaff();

            sqlTreatmentDetails = @"Select * from Treatment order by TreatmentDesc";
            daTreatments = new SqlDataAdapter(sqlTreatmentDetails, connStr);
            cmdBTreatments = new SqlCommandBuilder(daTreatments);
            daTreatments.FillSchema(dsRunway, SchemaType.Source, "Treatment");
            daTreatments.Fill(dsRunway, "Treatment");
            populateTreatments();
            



            sqlRooms = @"Select * from Room where TreatmentType = @TreatmentType";
            cmdRoomDetails = new SqlCommand(sqlRooms, conn);
            cmdRoomDetails.Parameters.Add("@TreatmentType", SqlDbType.Int);
            daRooms = new SqlDataAdapter(cmdRoomDetails);
            daRooms.FillSchema(dsRunway, SchemaType.Source, "Room");




            //            sqlRoomDetails = @"Select distinct Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime, sum( Treatment.TreatmentDuration)  as Duration
            // from Room 

            //left join AppointmentTreatment on Room.RoomNo= AppointmentTreatment.RoomNo
            //left join Appointment on AppointmentTreatment.AppointmentNo=Appointment.AppointmentNo
            //left join Treatment on AppointmentTreatment.TreatmentNo=Treatment.TreatmentNo

            //Where Room.RoomNo=@RoomNo
            //Group by Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime;";

            sqlRoomDetails = @"Select distinct Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,AppointmentTime, sum( Treatment.TreatmentDuration)  as Duration
 from Room 

left join AppointmentTreatment on Room.RoomNo= AppointmentTreatment.RoomNo
left join Appointment on AppointmentTreatment.AppointmentNo=Appointment.AppointmentNo
left join Treatment on AppointmentTreatment.TreatmentNo=Treatment.TreatmentNo

Where Room.RoomNo=1
Group by Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,AppointmentTime";
            cmdRoomAppointmentDetails = new SqlCommand(sqlRoomDetails, conn);
            cmdRoomAppointmentDetails.Parameters.Add("@RoomNo", SqlDbType.Int);
            daRoomsAppointments = new SqlDataAdapter(cmdRoomAppointmentDetails);
            daRoomsAppointments.FillSchema(dsRunway, SchemaType.Source, "RoomAppointment");


            sqlBooking = @"SELECT * from Appointment";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsRunway, SchemaType.Source, "Appointment");
            daBooking.Fill(dsRunway, "Appointment");


            sqlBookingDetails = @"SELECT * from AppointmentTreatment";
            daBookingDetails = new SqlDataAdapter(sqlBookingDetails, conn);
            cmdBBookingDetails = new SqlCommandBuilder(daBookingDetails);
            daBookingDetails.FillSchema(dsRunway, SchemaType.Source, "AppointmentTreatment");
            daBookingDetails.Fill(dsRunway, "AppointmentTreatment");
        }







        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                lblCust1.Text = "-";
                lblCust2.Text = "-";
                lblCust3.Text = "-";
                dtpStartDate.Enabled = false;

            }
            else
            {
                int CustNo = int.Parse(cmbCustomer.Text.Substring(cmbCustomer.Text.Length - 5, 4));
                drCustomer = dsRunway.Tables["Customer"].Rows.Find(CustNo);
                lblCust1.Text = drCustomer["CustomerTelNo"].ToString();
                lblCust2.Text = drCustomer["CustomerEmail"].ToString();
                lblCust3.Text = drCustomer["CustomerPostcode"].ToString();

                dtpStartDate.Enabled = true;
            }

        }
        private void cmbAppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTreatmentTime.Text = cmbAppointmentTime.Text;
            cmbTreatment.SelectedIndex = -1;

            if (cmbAppointmentTime.SelectedIndex > -1)
                pnlRoom.Enabled = true;
            else pnlRoom.Enabled = false;
        }
        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)//list of room which treatment has been selected
        {

            cmbRoomNo.Items.Clear();
            cmbRoomNo.Text = "";
            if (cmbTreatment.SelectedIndex == -1) return;
            int TreatmentNo = int.Parse(cmbTreatment.Text.Substring(cmbTreatment.Text.Length - 4, 3));
            drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
            cmdRoomDetails.Parameters["@TreatmentType"].Value = drTreatment["TreatmentType"];
            dsRunway.Tables["Room"].Rows.Clear();
            daRooms.Fill(dsRunway, "Room");
            foreach (DataRow room in dsRunway.Tables["Room"].Rows)
            {
                bool add = true;
                cmdRoomAppointmentDetails.Parameters["@RoomNo"].Value = room["RoomNo"];
                dsRunway.Tables["RoomAppointment"].Rows.Clear();
                daRoomsAppointments.Fill(dsRunway, "RoomAppointment");


                foreach (DataRow ra in dsRunway.Tables["RoomAppointment"].Rows)
                {

                    DateTime date = DateTime.Parse(ra["AppointmentDate"].ToString());
                    if (date.Date != dtpStartDate.Value.Date)
                    {
                        continue;
                    }
                    TimeSpan bookingStart = TimeSpan.Parse(ra["AppointmentTime"].ToString());
                    int minutes = int.Parse(ra["Duration"].ToString()) * 30;
                    TimeSpan bookingEnd = bookingStart.Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                    //new treatment time through these three lines of code, start is new treamtn tim, set label treaemtn end to string 
                    TimeSpan treatmentStart = TimeSpan.Parse(lblTreatmentTime.Text);
                    int minutesT = int.Parse(drTreatment["TreatmentDuration"].ToString()) * 30;
                    TimeSpan treatmentEnd = treatmentStart.Add(new TimeSpan(minutesT / 60, minutesT % 60, 0));
                    if ((bookingStart >= treatmentStart && bookingStart < treatmentEnd) ||
                       (bookingEnd > treatmentStart && bookingEnd <= treatmentEnd) ||
                       (bookingStart < treatmentStart && bookingEnd > treatmentEnd))
                    {
                        add = false;
                        break;
                    }


                }
              
                if (add)
                {
                    cmbRoomNo.Items.Add(room["RoomNo"]);
                }
            }

            if(cmbRoomNo.Items.Count==0)
            {
                MessageBox.Show("No Rooms Available for This Time! Sorry");
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpTime.Enabled = true;
        }
        private void fillAvailibleRooms()
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


        private void populateCustomers()
        {
            int noRows = dsRunway.Tables["Customer"].Rows.Count;
            cmbCustomer.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["customer"].Rows)
            {
                cmbCustomer.Items.Add(dr["CustomerSurname"].ToString() + ", " + dr["CustomerForename"].ToString() + " (" + dr["CustomerNo"].ToString() + ")");
            }
        }

        //private void populateStaff()
        //{
        //    int noRows = dsRunway.Tables["Staff"].Rows.Count;
        //    cmbStaff.Items.Clear();
        //    foreach (DataRow dr in dsRunway.Tables["Staff"].Rows)
        //    {
        //        cmbStaff.Items.Add(dr["StaffSurname"].ToString() + ", " + dr["StaffForename"].ToString() + " (" + dr["StaffNo"].ToString() + ")");
        //    }
        //}
        private void populateTreatments()
        {
            int noRows = dsRunway.Tables["Treatment"].Rows.Count;
            cmbTreatment.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["Treatment"].Rows)
            {
                cmbTreatment.Items.Add(dr["TreatmentDesc"].ToString() + ", " + " (" + dr["TreatmentNo"].ToString() + ")");
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {

            bool ok = true;
            //bool exits = false;
            if (cmbCustomer.Text == "")
                MessageBox.Show("please select a customer", "Customer");

            else if (dtpStartDate.Value < DateTime.Now.Date)
                MessageBox.Show("please select a Appointment Date", "AppointmentDate");
            else if (cmbAppointmentTime.Text == "")
            {
                MessageBox.Show("please select a Appointment Time", "AppointmentTime");

                cmbAppointmentTime.Focus();
            }
            else if (cmbTreatment.Text == "")
                MessageBox.Show("please select a Treatment", "Treatment");
            //else if (cmbStaff.Text == "")
            //        MessageBox.Show("please select a Staff", "Staff");


            else if (cmbRoomNo.Text == "")
                MessageBox.Show("please select a Room", "Room");

            else
            {
                //foreach (ListViewItem item in lvwBooking.Items)
                //{
                //    if (item.SubItems[1].Text == cmbRoomNo.Text)
                //    {
                //        MessageBox.Show("Room already selected for this booking", "Booking");
                //        exits = true;
                //        break;
                //    }
                //}
                //if (!exits)
                ////{
                //    DateTime start = DateTime.Parse(cmbAppointmentTime.Text.Trim());
                //    foreach (DataRow dr in dsRunway.Tables["Appointment"].Rows)
                //    {
                //        DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());
                //        if (start >= bookedDate && start <= bookedDate.AddDays(int.Parse(cmbAppointmentTime.Text)))
                //        {

                //            if ((dr["BookedRooms"] == cmbRoomNo.SelectedValue))
                //            {
                //                MessageBox.Show("the selected Room is already included in a booking for this dayte range. pleasereselect", "Booking");
                //                ok = false;
                //            }
                //            if (!ok)
                //                break;
                //        }
                //    }
                int TreatmentNo = int.Parse(cmbTreatment.Text.Substring(cmbTreatment.Text.Length - 4, 3));
                foreach (ListViewItem items in lvwBooking.Items)
                {
                    if (items.SubItems[0].Text == TreatmentNo.ToString())
                    {
                        ok = false;
                        MessageBox.Show("Treatment " + TreatmentNo + "  Already added, please select another", "Treatment already Added ");

                    }

                }
                if (ok)
                {
                    pnlCustomer.Enabled = false;


                    drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
                    //DataRow room = dsRunway.Tables["Room"].Rows.Find(int.Parse(cmbRoomNo.Text));



                    ListViewItem item = new ListViewItem(TreatmentNo.ToString());
                    item.SubItems.Add(drTreatment["TreatmentDesc"].ToString());
                    item.SubItems.Add(lblTreatmentTime.Text);
                    //int StaffNo = int.Parse(cmbStaff.Text.Substring(cmbStaff.Text.Length - 5, 4));
                    //item.SubItems.Add(StaffNo.ToString());
                    item.SubItems.Add(cmbRoomNo.Text);

                    lvwBooking.Items.Add(item);
                    int minutes = int.Parse(drTreatment["TreatmentDuration"].ToString()) * 30;
                    TimeSpan nextTreatment = TimeSpan.Parse(lblTreatmentTime.Text).Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                    lblTreatmentTime.Text = nextTreatment.ToString(@"hh\:mm");




                }

            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {


            if (lvwBooking.SelectedItems.Count != 0)
            {
                var item = lvwBooking.SelectedItems[0];
                lvwBooking.Items.Remove(item);
            }


        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            DataRow drBooking;
            int bookingNo;
            int noRows = dsRunway.Tables["Appointment"].Rows.Count;
            drBooking = dsRunway.Tables["Appointment"].Rows[noRows - 1];
            bookingNo = (int.Parse(drBooking["AppointmentNo"].ToString()) + 1);

            if (cmbCustomer.SelectedIndex == -1)
                MessageBox.Show("Please select a customer", "Customer");



            else if (cmbAppointmentTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please input appointment time", "AppointmentTime");
                cmbAppointmentTime.Focus();
            }
            else if (lvwBooking.Items.Count == 0)
            {
                MessageBox.Show("please add  to the booking", "BookingDetails");
            }
            else
            {
                drBooking = dsRunway.Tables["Appointment"].NewRow();

                drBooking["AppointmentNo"] = bookingNo;
                int CustNo = int.Parse(cmbCustomer.Text.Substring(cmbCustomer.Text.Length - 5, 4));
                drBooking["CustomerNo"] = CustNo;

                //drBooking["AppointmentDate"] = DateTime.Parse(lblBookingDatee.Text.Trim());
                drBooking["AppointmentDate"] = DateTime.Parse(dtpStartDate.Text.Trim());
                drBooking["AppointmentTime"] = TimeSpan.Parse(cmbAppointmentTime.Text);

                dsRunway.Tables["Appointment"].Rows.Add(drBooking);
                daBooking.Update(dsRunway, "Appointment");


                foreach (ListViewItem item in lvwBooking.Items)
                {
                    DataRow drBookingDets = dsRunway.Tables["AppointmentTreatment"].NewRow();
                    drBookingDets["AppointmentNo"] = drBooking["AppointmentNo"];
                    drBookingDets["TreatmentTime"] = TimeSpan.Parse(item.SubItems[2].Text);
                    drBookingDets["RoomNo"] = int.Parse(item.SubItems[3].Text);
                    drBookingDets["TreatmentNo"] = int.Parse(item.SubItems[0].Text);
                    dsRunway.Tables["AppointmentTreatment"].Rows.Add(drBookingDets);
                    daBookingDetails.Update(dsRunway, "AppointmentTreatment");
                }
                dtpBookingsStartDate.Value = dtpStartDate.Value;
                if (MessageBox.Show("Booking no: " + drBooking["AppointmentNo"].ToString()
                    + "added to system. Do you want to Add aother? ", "Booking Added ",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    clearFrm();
                }
                else
                {
                    tabApp.SelectedIndex = 0;
                    clearFrm();

                }
            }
        }
        private void clearFrm()
        {
            cmbCustomer.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            cmbAppointmentTime.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;
            cmbRoomNo.SelectedIndex = -1;
            lvwBooking.Items.Clear();
            pnlBooking.Enabled = true;
            cmbCustomer.Enabled = true;
            pnlCustomer.Enabled = true;
        }


        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Addition Of Appointment?", "Add Cancel",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabApp.SelectedIndex = 0;
        }

        private void btnAddDisplay_Click(object sender, EventArgs e)
        {
            tabApp.SelectedIndex = 1;
        }
        private void btnEditDisplay_Click(object sender, EventArgs e)
        {
            populateEditTab();//bind up to slected index change bound to button,
          
        }
     
        #endregion




        #region editBooking
        //region start edit booking
        private void populateEditTab()
        {
            int bookingID = -1;
        //    bookingClicked 
        if (dgvAppointments.SelectedCells.Count>0)
            {
                if (dgvAppointments.SelectedCells[0].Value.ToString() != "")
                {
                    bookingID = Int32.Parse(dgvAppointments.SelectedCells[0].Value.ToString());  //must have booking id cell selected has value, result must be a booking id insdie it
                    //check booking id filled out
                }
                
            }
            if(bookingID>-1)  //check if booking id is chnage form -1
            {
                DataRow drRa =dsRunway.Tables["Appointment"].Rows.Find(bookingID);
                DataRow drCus = dsRunway.Tables["Customer"].Rows.Find(drRa["CustomerNo"]);// get customer no from data row as above llokjing for a col of of data row called customer
                //
                lblEditCustomer1.Text = drCus["CustomerForename"].ToString() + " " + drCus["CustomerSurname"].ToString();
                lblEditCustomer2.Text = drCus["CustomerTelNo"].ToString() ;
                lblEditCustomer3.Text = drCus["CustomerEmail"].ToString();
                dtpEditStartDate.Value = DateTime.Parse(drRa["AppointmentDate"].ToString());
                String selectedTime =TimeSpan.Parse(drRa["AppointmentTime"].ToString()).ToString(@"hh\:mm");
                for (int i = 0; i < cmbEditAppointmentTime.Items.Count; i++)
                {
                    if (cmbEditAppointmentTime.Items[i].ToString() == selectedTime)
                        cmbEditAppointmentTime.SelectedIndex = i;
                }

                //count total of duartion
                int totalDuration = 0;
                lvwEditBooking.Items.Clear();

                //chgeck eacxh row in appointment treatment table to se eif it matches that appoinmtnet for each
                foreach(DataRow dr in dsRunway.Tables["AppointmentTreatment"].Rows)
                {
                    
                    if (dr["AppointmentNo"].ToString() == drRa["AppointmentNo"].ToString())
                    {//must compare values and not objects
                        ListViewItem apps = new ListViewItem(dr["TreatmentNo"].ToString()); //put item inot contruct , main item then sub items
                      
                        DataRow drTreat = dsRunway.Tables["Treatment"].Rows.Find(dr["TreatmentNo"]);
                        totalDuration += Int32.Parse(drTreat["TreatmentDuration"].ToString());
                        

                        apps.SubItems.Add(drTreat["TreatmentDesc"].ToString());
                        apps.SubItems.Add(dr["TreatmentTime"].ToString());
                        apps.SubItems[2].Tag= Int32.Parse(drTreat["TreatmentDuration"].ToString());
                        apps.SubItems.Add(dr["RoomNo"].ToString());
                        lvwEditBooking.Items.Add(apps);
                    }
                }
                int minutes = totalDuration * 30;
                TimeSpan nextTreatment = TimeSpan.Parse(cmbEditAppointmentTime.Text.ToString()).Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                lblEditTreatmentTime.Text = nextTreatment.ToString(@"hh\:mm");
                populateEditTreatments();

                //cmdAppTreat.Parameters["@AppointmentNo"].Value = drRa["AppointmentNo"]; //
                //cmdAppTreat.Parameters["@RoomNo"].Value= null ;//searches for all rooms
                //dsRunway.Tables["ScheduleAppTreat"].Rows.Clear();
                //daScheduleAppTreat.Fill(dsRunway, "ScheduleAppTreat");

                tabApp.SelectedIndex = 2;
                drEditBooking=drRa;
            }
            else
            {
                tabApp.SelectedIndex = 0;
                MessageBox.Show("Please Select An Appointment", "AppointmentNo");
            }
          
              
        }
     
        private void populateEditTreatments()
        {
            int noRows = dsRunway.Tables["Treatment"].Rows.Count;
            cmbEditTreatment.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["Treatment"].Rows)
            {
                cmbEditTreatment.Items.Add(dr["TreatmentDesc"].ToString() + ", " + " (" + dr["TreatmentNo"].ToString() + ")");
            }
        }

        private void cmbEditAppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEditAppointmentTime.SelectedIndex > -1)
                pnlEditTreat.Enabled = true;
            else pnlEditTreat.Enabled = false;
        }
        private void cmbEditTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEditRoomNo.Items.Clear();
            cmbEditRoomNo.Text = "";
            if (cmbEditTreatment.SelectedIndex == -1) return;
            int TreatmentNo = int.Parse(cmbEditTreatment.Text.Substring(cmbEditTreatment.Text.Length - 4, 3));
            drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
            cmdRoomDetails.Parameters["@TreatmentType"].Value = drTreatment["TreatmentType"];
            dsRunway.Tables["Room"].Rows.Clear();
            daRooms.Fill(dsRunway, "Room");
            foreach (DataRow room in dsRunway.Tables["Room"].Rows)
            {
                bool add = true;
                cmdRoomAppointmentDetails.Parameters["@RoomNo"].Value = room["RoomNo"];
                dsRunway.Tables["RoomAppointment"].Rows.Clear();
                daRoomsAppointments.Fill(dsRunway, "RoomAppointment");


                foreach (DataRow ra in dsRunway.Tables["RoomAppointment"].Rows)
                {
                    DateTime date = DateTime.Parse(ra["AppointmentDate"].ToString());
                    if (date.Date != dtpEditStartDate.Value.Date)
                    {
                        continue;
                    }
                    TimeSpan bookingStart = TimeSpan.Parse(ra["AppointmentTime"].ToString());
                    int minutes = int.Parse(ra["Duration"].ToString()) * 30;
                    TimeSpan bookingEnd = bookingStart.Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                    //new treatment time through these three lines of code, start is new treamtn tim, set label treaemtn end to string 
                    TimeSpan treatmentStart = TimeSpan.Parse(lblEditTreatmentTime.Text);
                    int minutesT = int.Parse(drTreatment["TreatmentDuration"].ToString()) * 30;
                    TimeSpan treatmentEnd = treatmentStart.Add(new TimeSpan(minutesT / 60, minutesT % 60, 0));
                    if ((bookingStart >= treatmentStart && bookingStart < treatmentEnd) ||
                       (bookingEnd > treatmentStart && bookingEnd <= treatmentEnd) ||
                       (bookingStart < treatmentStart && bookingEnd > treatmentEnd))
                    {
                        add = false;
                        break;
                    }


                }
                if (add)
                {
                    cmbEditRoomNo.Items.Add(room["RoomNo"]);
                }
            }
            if (cmbRoomNo.Items.Count == 0)
            {
                MessageBox.Show("No Rooms Available for This Time! Sorry", "Rooms!");
            }
        }

        private void btnReS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Re-Schedule Your Appointment?" + drEditBooking["AppointmentNo"].ToString() ,
               "Re-Schedule Appointment",  MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                
                //clearFrm();
                //pnlEditCustomer.Enabled = true;
                //pnlEditTreat.Enabled = true;
                //pnlEditBooking.Enabled = true;
                lvwEditBooking.Items.Clear();
                dtpEditStartDate.Enabled = true;
                cmbEditAppointmentTime.Enabled = true;
            }
       
        }

        DataRow drEditBooking;
        private void btnEditItem_Click(object sender, EventArgs e)
        {

            bool ok = true;
            //bool exits = false;
         
  
            //if (MessageBox.Show("Booking no: " + drBooking["AppointmentNo"].ToString()
            //   + "added to system. Do you want to Add aother? ", "Booking Added ",
            //   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)

            if (cmbEditAppointmentTime.Text == "")
            {
                MessageBox.Show("please select a Appointment Time", "AppointmentTime");

                cmbEditAppointmentTime.Focus();
            }
            else if (cmbEditTreatment.Text == "")
                MessageBox.Show("please select a Treatment", "Treatment");
            //else if (cmbStaff.Text == "")
            //        MessageBox.Show("please select a Staff", "Staff");


            else if (cmbEditRoomNo.Text == "")
                MessageBox.Show("please select a Room", "Room");

            else
            {
                
                int TreatmentNo = int.Parse(cmbEditTreatment.Text.Substring(cmbEditTreatment.Text.Length - 4, 3));
                foreach (ListViewItem items in lvwEditBooking.Items)
                {
                    if (items.SubItems[0].Text == TreatmentNo.ToString())
                    {
                        ok = false;
                        MessageBox.Show("Treatment " + TreatmentNo + "  Already added, please select another", "Treatment already Added ");

                    }

                }
                if (ok)
                {
                  //  pnlEditCustomer.Enabled = false;


                    drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
                    //DataRow room = dsRunway.Tables["Room"].Rows.Find(int.Parse(cmbRoomNo.Text));



                    ListViewItem item = new ListViewItem(TreatmentNo.ToString());
                    item.SubItems.Add(drTreatment["TreatmentDesc"].ToString());
                    item.SubItems.Add(lblEditTreatmentTime.Text);
                    //int StaffNo = int.Parse(cmbStaff.Text.Substring(cmbStaff.Text.Length - 5, 4));
                    //item.SubItems.Add(StaffNo.ToString());
                    item.SubItems.Add(cmbEditRoomNo.Text);

                    lvwEditBooking.Items.Add(item);
                    int minutes = int.Parse(drTreatment["TreatmentDuration"].ToString()) * 30;
                    TimeSpan nextTreatment = TimeSpan.Parse(lblEditTreatmentTime.Text).Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                    lblEditTreatmentTime.Text = nextTreatment.ToString(@"hh\:mm");


                }
            }
                
            }
        private void btnEditRemove_Click(object sender, EventArgs e)
        {


            if (lvwEditBooking.SelectedItems.Count != 0)
            {
                var item = lvwEditBooking.SelectedItems[0];
                lvwEditBooking.Items.Remove(item);

                calculateTimes();
                
              

            }
        }
        private void calculateTimes()
        {
            int totalTime = 0;
            TimeSpan time = TimeSpan.Parse(cmbEditAppointmentTime.Text);//start time

            foreach(ListViewItem item in lvwEditBooking.Items)         //each appointment Time
            {
                item.SubItems[2].Text=time.ToString(@"hh\:mm"); //setting sub item to time above
                      //add udration of that appointment on to time
                int duration = (int)item.SubItems[2].Tag;//finding duration
                int minutes = duration* 30;
                time =  time.Add(new TimeSpan(minutes / 60, minutes % 60, 0));//adding on no of minutes, time is now 30 mins later

                
         
            }
            lblEditTreatmentTime.Text = time.ToString(@"hh\:mm");//text property of label setting to string
            
        }
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Addition Of Appointment?", "Add Cancel",
              MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabApp.SelectedIndex = 0;
        }



        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            int bookingNo;
            int noRows = dsRunway.Tables["Appointment"].Rows.Count;

            bookingNo = (int.Parse(drEditBooking["AppointmentNo"].ToString()) + 1);

            if (cmbEditAppointmentTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please input appointment time", "AppointmentTime");
                cmbEditAppointmentTime.Focus();
            }
            else if (lvwEditBooking.Items.Count == 0)
            {
                MessageBox.Show("please add  to the booking", "BookingDetails");
            }
            else
            {

                foreach (DataRow dr in dsRunway.Tables["AppointmentTreatment"].Rows)
                {

                    if (dr["AppointmentNo"].ToString() == drEditBooking["AppointmentNo"].ToString())//apppointment that match edit appointment treatments
                    {//must compare values and not objects
                        dr.Delete();

                    }
                }
                daBookingDetails.Update(dsRunway, "AppointmentTreatment");//updating to db
                //drEditBooking["AppointmentNo"] = bookingNo;
                //int CustNo = int.Parse(cmbEditCustomer.Text.Substring(cmbCustomer.Text.Length - 5, 4));
                //drEditBooking["CustomerNo"] = CustNo;

                //drBooking["AppointmentDate"] = DateTime.Parse(lblBookingDatee.Text.Trim());
                drEditBooking.BeginEdit();
                drEditBooking["AppointmentDate"] = DateTime.Parse(dtpEditStartDate.Text.Trim()); //updatin date and toime if changed
                drEditBooking["AppointmentTime"] = TimeSpan.Parse(cmbEditAppointmentTime.Text);

                drEditBooking.EndEdit();

                daBooking.Update(dsRunway, "Appointment");


                foreach (ListViewItem item in lvwEditBooking.Items) //readding in eadch of treatments
                {
                    DataRow drBookingDets = dsRunway.Tables["AppointmentTreatment"].NewRow();
                    drBookingDets["AppointmentNo"] = drEditBooking["AppointmentNo"];
                    drBookingDets["TreatmentTime"] = TimeSpan.Parse(item.SubItems[2].Text);
                    drBookingDets["RoomNo"] = int.Parse(item.SubItems[3].Text);
                    drBookingDets["TreatmentNo"] = int.Parse(item.SubItems[0].Text);
                    dsRunway.Tables["AppointmentTreatment"].Rows.Add(drBookingDets);
                    daBookingDetails.Update(dsRunway, "AppointmentTreatment");
                }
                dtpBookingsStartDate.Value = dtpEditStartDate.Value;
                if (MessageBox.Show("Booking no: " + drEditBooking["AppointmentNo"].ToString()
                    + "Are You Done Editing? ", "Booking Added ",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    clearFrm();
                  
                }
                else
                {
                    tabApp.SelectedIndex = 0;
                    clearFrm();

                }
                updateSchedule();
            }
        }
        ///region end 
        #endregion
    }
}

