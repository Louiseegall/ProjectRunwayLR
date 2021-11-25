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
    public partial class frmStaff : Form
    {
        SqlDataAdapter daStaff;
        DataSet dsRunway = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;
        int selectedTab = 0;
        bool staffSelected = false;
        int staffNoSelected = 0;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            connStr = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";

            sqlStaff = @"select * from Staff";
            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            cmdBStaff = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsRunway, SchemaType.Source, "Staff");
            daStaff.Fill(dsRunway, "Staff");

            dgvStaff.DataSource = dsRunway.Tables["Staff"];

            dgvStaff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabStaff.SelectedIndex = 1;
            tabStaff.SelectedIndex = 0;

        }

        private void frmStaff_Shown(object sender, EventArgs e) //throws events, calls& creates
        {
            tabStaff.TabPages[0].CausesValidation = true;
            tabStaff.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabStaff.TabPages[2].CausesValidation = true;
            tabStaff.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 1;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Edit Of The Staff No: " + lblEditStaffNo.Text + 
                "?", "Edit Staff", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabStaff.SelectedIndex = 0;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Addition Of The Customer No: " + lblAddStaffNo.Text + 
                "?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabStaff.SelectedIndex = 0;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            tabStaff.SelectedIndex = 2;
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {//reset
                staffSelected = false;
                staffNoSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                staffNoSelected = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }
        }

        private void frmCustomer_Shown(object sender, EventArgs e) //throws events, calls& creates
        {
            tabStaff.TabPages[0].CausesValidation = true;
            tabStaff.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabStaff.TabPages[2].CausesValidation = true;
            tabStaff.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }

        void EditTabValidate(object sender, EventArgs e)
        {
            if (staffSelected == false && staffNoSelected == 0)
            { //Reset
                staffSelected = false;
                staffNoSelected = 0;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                staffSelected = true;
                staffNoSelected = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }

        }

        private void btnAddAdd_Click(object sender,EventArgs e)
        {
            MyStaff myStaff = new MyStaff();
            bool ok = Capture;
            errP.Clear();

            try
            {
                myStaff.StaffNumber = Convert.ToInt32(lblAddStaffNo.Text.Trim());
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(lblAddStaffNo, MyException.toString());
            }

            try
            {
                myStaff.Title = cmbAddTitle.Text.Trim();
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(cmbAddTitle, MyException.toString());
            }

            try
            {
                myStaff.Surname = txtAddSurename.Text.Trim();
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddForename, MyException.toString());
            }

            try
            {
                myStaff.Forename = txtAddForename.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddForename, MyException.toString());
            }

            try
            {
                myStaff.DOB = dtpAdd.Value;
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(dtpAdd, MyException.toString());
            }

            try
            {
                myStaff.Street = txtAddStreet.Text.Trim();
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyException.toString());
            }

            try
            {
                myStaff.Town = txtAddTown.Text.Trim();
            }
            catch(MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddTown, MyException.toString());
            }

            try
            {
                myStaff.County = txtAddCounty.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyException.toString());
            }

            try
            {
                myStaff.Country = txtAddCountry.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddCountry, MyException.toString());
            }

            try
            {
                myStaff.Postcode = txtAddPostcode.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyException.toString());
            }

            try
            {
                myStaff.TelNo = txtAddTelNo.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddTelNo, MyException.toString());
            }

            try
            {
                myStaff.email = txtAddEmail.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyException.toString());
            }

            try
            {
                if(ok)
                {
                    drStaff = dsRunway.Tables["Staff"].NewRow();
                    drStaff["StaffNo"] = myStaff.StaffNumber;
                    drStaff["StaffTitle"] = myStaff.Title;
                    drStaff["StaffForename	"] = myStaff.Forename;
                    drStaff["StaffSurname"] = myStaff.Surname;
                    drStaff["StaffDOB"] = myStaff.DOB;
                    drStaff["StaffStreet"] = myStaff.Street;
                    drStaff["StaffTown"] = myStaff.Town;
                    drStaff["County"] = myStaff.County;
                    drStaff["Country"] = myStaff.Country;
                    drStaff["Postcode"] = myStaff.Postcode;
                    drStaff["TelNo"] = myStaff.TelNo;
                    drStaff["Email"] = myStaff.email;
                    drStaff["EmergencyContact"] = myStaff.EmergencyContact;
                    drStaff["Speciality"] = myStaff.Speciality;

                    dsRunway.Tables["Customer"].Rows.Add(drStaff);
                    daStaff.Update(dsRunway, "Staff");
                    MessageBox.Show("Staff Added");

                    if (MessageBox.Show("Do you wish to add another Staff Member", "Add Staff Member", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsRunway.Tables["Staff"].Rows.Count);
                    }
                    else tabStaff.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                drStaff.Delete();
            }
        }

        void clearAddForm()
        {
            cmbAddTitle.SelectedIndex = -1;
            txtAddForename.Clear();
            txtAddSurename.Clear();
            dtpAdd.Value = DateTime.Now;
            txtAddStreet.Clear();
            txtAddCounty.Clear();
            txtAddCountry.Clear();
            txtAddPostcode.Clear();
            txtAddTelNo.Clear();
            txtAddEmail.Clear();
        }

        private void tabStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabStaff.SelectedIndex;
            tabStaff.TabPages[tabStaff.SelectedIndex].Focus();
            tabStaff.TabPages[tabStaff.SelectedIndex].CausesValidation = true;


            switch (tabStaff.SelectedIndex)
            {
                case 0: //displays tab index
                    {
                        dsRunway.Tables["Staff"].Clear();
                        daStaff.Fill(dsRunway, "Staff");
                        break;
                    }
                case 1: //add tab selected
                    {
                        int noRows = dsRunway.Tables["Staff"].Rows.Count;
                        if (noRows == 0)
                            lblAddStaffNo.Text = "1000";
                        else

                            getNumber(noRows);


                        errP.Clear();
                        clearAddForm();
                        break;
                    }
                case 2:// edit tab selected
                    {
                        if (staffNoSelected == 0)
                        {
                            tabStaff.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lblEditStaffNo.Text = staffNoSelected.ToString();

                            drStaff = dsRunway.Tables["Staff"].Rows.Find(lblEditStaffNo.Text);

                            if (drStaff["StaffTitle"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 0;
                            if (drStaff["StaffTitle"].ToString() == "Mrs")
                                cmbEditTitle.SelectedIndex = 1;
                            if (drStaff["StaffTitle"].ToString() == "Miss")
                                cmbEditTitle.SelectedIndex = 2;
                            if (drStaff["StaffTitle"].ToString() == "Ms")
                                cmbEditTitle.SelectedIndex = 3;
                            txtEditForename.Text = drStaff["StaffForename"].ToString();
                            txtEditSurname.Text = drStaff["StaffSurname"].ToString();
                            dtpEditDOB.Value = DateTime.Parse(drStaff["StaffDOB"].ToString());
                            txtEditStreet.Text = drStaff["StaffStreet"].ToString();
                            txtEditTown.Text = drStaff["StaffTown"].ToString();
                            txtEditCounty.Text = drStaff["StaffCounty"].ToString();
                            txtEditCountry.Text = drStaff["StaffCountry"].ToString();
                            txtEditPostcode.Text = drStaff["StaffPostcode"].ToString();
                            txtEditTelNo.Text = drStaff["StaffTelNo"].ToString();
                            txtEditEmail.Text = drStaff["StaffEmail"].ToString();


                            ChangeFormEnabled(false);
                            break;
                        }
                    }

            }
        }
        private void ChangeFormEnabled(bool enabled)
        {

            cmbEditTitle.Enabled = enabled;
            txtEditForename.Enabled = enabled;
            txtEditSurname.Enabled = enabled;
            dtpEditDOB.Enabled = enabled;
            txtEditStreet.Enabled = enabled;
            txtEditTown.Enabled = enabled;
            txtEditCounty.Enabled = enabled;
            txtEditCountry.Enabled = enabled;
            txtEditPostcode.Enabled = enabled;
            txtEditTelNo.Enabled = enabled;
            txtEditEmail.Enabled = enabled;
            if (enabled) btnEditEdit.Text = "Save";
            else btnEditEdit.Text = "Edit";
        }

        private void getNumber(int noRows)
        {
            drStaff = dsRunway.Tables["Staff"].Rows[noRows - 1];
            lblAddStaffNo.Text = (int.Parse(drStaff["StaffNo"].ToString()) + 1).ToString();
        }









        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
