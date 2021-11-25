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

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
