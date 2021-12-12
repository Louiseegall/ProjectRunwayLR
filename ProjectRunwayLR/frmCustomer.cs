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
    public partial class frmCustomer : Form
    {

        //creates all objects needed for connecting to Database, where to connect to the ds
        SqlDataAdapter daCustomer;
        DataSet dsRunway = new DataSet(); //create new instance of a dataset- call dsRunway
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        // DataGridView dgvCustomers;

        public frmCustomer()
        {
            InitializeComponent();
        }


        private void frmCustomer_SizeChanged(object sender, EventArgs e)
        {
            //tabCustomer.ItemSize = new Size((tabCustomer.Width - 45) / 3, tabCustomer.ItemSize.Height);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // tabCustomer.ItemSize = new Size((tabCustomer.Width - 45) / 3, tabCustomer.ItemSize.Height);


            //.local host , initial catalog-DS name
            connStr = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";

            //makes a copy of customer table 
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);//builds structure of table
            daCustomer.FillSchema(dsRunway, SchemaType.Source, "Customer");
            daCustomer.Fill(dsRunway, "Customer");

            dgvCustomers.DataSource = dsRunway.Tables["Customer"]; //dataset assigned to customer table

            //resize the datagrid view columns to fit the newly loaded content
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //resize all columns

            //flips to generte specific piece of code
            tabCustomer.SelectedIndex = 1;
            tabCustomer.SelectedIndex = 0;
            dtpAddDOB.MaxDate = DateTime.Now.Date.AddYears(-18);
            dtpEditDOB.MaxDate = DateTime.Now.Date.AddYears(-18);
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

        private void btnDisplayAdd_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedIndex = 1;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Edit Of The Customer No: " + lblEditCustomerNo.Text + "?", "Edit Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabCustomer.SelectedIndex = 0;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel The Addition Of The Customer No: " + lblAddCustomerNo.Text + "?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabCustomer.SelectedIndex = 0;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedIndex = 2;
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {//reset
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }

        private void frmCustomer_Shown(object sender, EventArgs e) //throws events, calls& creates
        {
            tabCustomer.TabPages[0].CausesValidation = true;
            tabCustomer.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabCustomer.TabPages[2].CausesValidation = true;
            tabCustomer.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }


        void EditTabValidate(object sender, EventArgs e)
        {
            if (custSelected == false && custNoSelected == 0)
            { //Reset
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
            
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();

            try
            {
                myCustomer.IDNo = Convert.ToInt32(lblAddCustomerNo.Text.Trim());
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(lblAddCustomerNo, MyException.toString());
            }

            try
            {
                myCustomer.Title = cmbAddTitle.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(cmbAddTitle, MyException.toString());
            }

            try
            {
                myCustomer.Surname = txtAddSurname.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddSurname, MyException.toString());
            }

            try
            {
                myCustomer.Forename = txtAddForename.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddForename, MyException.toString());
            }
            try
            {
                myCustomer.DOB= dtpAddDOB.Value;
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(dtpAddDOB, MyException.toString());
            }
            try
            {
                myCustomer.Street = txtAddStreet.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyException.toString());
            }

            try
            {
                myCustomer.Town = txtAddTown.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddTown, MyException.toString());
            }

            try
            {
                myCustomer.County = txtAddCounty.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyException.toString());
            }
            try
            {
                myCustomer.Country = txtAddCountry.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddCountry, MyException.toString());
            }
            try
            {
                myCustomer.Postcode = txtAddPostcode.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyException.toString());
            }

            try
            {
                myCustomer.TelNo = txtAddTelNo.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddTelNo, MyException.toString());
            }
            try
            {
                myCustomer.Email = txtAddEmail.Text.Trim();
            }
            catch (MyException MyException)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyException.toString());
            }
            try
            {
                if (ok)
                {
                    drCustomer = dsRunway.Tables["Customer"].NewRow();
                    drCustomer["CustomerNo"] = myCustomer.IDNo;
                    drCustomer["CustomerTitle"] = myCustomer.Title;
                    drCustomer["CustomerForename"] = myCustomer.Forename;
                    drCustomer["CustomerDOB"] = myCustomer.DOB;
                    drCustomer["CustomerSurname"] = myCustomer.Surname;
                    drCustomer["CustomerStreet"] = myCustomer.Street;
                    drCustomer["CustomerTown"] = myCustomer.Town;
                    drCustomer["CustomerCounty"] = myCustomer.County;
                    drCustomer["CustomerCountry"] = myCustomer.Country;
                    drCustomer["CustomerPostcode"] = myCustomer.Postcode;
                    drCustomer["CustomerTelNo"] = myCustomer.TelNo;
                    drCustomer["CustomerEmail"] = myCustomer.Email;
                

                    dsRunway.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsRunway, "Customer");
                    MessageBox.Show("Customer Added");

                    if (MessageBox.Show("Do you wish to add another customer?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsRunway.Tables["Customer"].Rows.Count);
                    }
                    else tabCustomer.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                drCustomer.Delete();// deletes data row as two rows selected, must be identical
            }
        }
        void clearAddForm()
        {
            cmbAddTitle.SelectedIndex = -1;
            txtAddForename.Clear();
            txtAddSurname.Clear();
          //  dtpAddDOB.Value = DateTime.Now;
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddCountry.Clear();
            txtEditPostcode.Clear();
            txtAddTelNo.Clear();
            txtAddEmail.Clear();
         
        }

        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabCustomer.SelectedIndex;
            tabCustomer.TabPages[tabCustomer.SelectedIndex].Focus();
            tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;


            switch (tabCustomer.SelectedIndex)
            {
                case 0: //displays tab index
                    {
                        dsRunway.Tables["Customer"].Clear();
                        daCustomer.Fill(dsRunway, "Customer");
                        break;
                    }
                case 1: //add tab selected
                    {
                        int noRows = dsRunway.Tables["Customer"].Rows.Count;
                        if (noRows == 0)
                            lblAddCustomerNo.Text = "1000";
                        else

                            getNumber(noRows);


                        errP.Clear();
                        clearAddForm();
                        break;
                    }
                case 2:// edit tab selected
                    {
                        if (custNoSelected == 0)
                        {
                            tabCustomer.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lblEditCustomerNo.Text = custNoSelected.ToString();

                            drCustomer = dsRunway.Tables["Customer"].Rows.Find(lblEditCustomerNo.Text);

                            if (drCustomer["CustomerTitle"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 0;
                            if (drCustomer["CustomerTitle"].ToString() == "Mrs")
                                cmbEditTitle.SelectedIndex = 1;
                            if (drCustomer["CustomerTitle"].ToString() == "Miss")
                                cmbEditTitle.SelectedIndex = 2;
                            if (drCustomer["CustomerTitle"].ToString() == "Ms")
                                cmbEditTitle.SelectedIndex = 3;
                            txtEditForename.Text = drCustomer["CustomerForename"].ToString();
                            txtEditSurname.Text = drCustomer["CustomerSurname"].ToString();
                            dtpEditDOB.Value = DateTime.Parse( drCustomer["CustomerDOB"].ToString());
                            txtEditStreet.Text = drCustomer["CustomerStreet"].ToString();
                            txtEditTown.Text = drCustomer["CustomerTown"].ToString();
                            txtEditCounty.Text = drCustomer["CustomerCounty"].ToString();
                            txtEditCountry.Text = drCustomer["CustomerCountry"].ToString();
                            txtEditPostcode.Text = drCustomer["CustomerPostcode"].ToString();
                            txtEditTelNo.Text = drCustomer["CustomerTelNo"].ToString();
                            txtEditEmail.Text = drCustomer["CustomerEmail"].ToString();
                        

                            ChangeFormEnabled(false);
                            break;
                        }
                    }
            }
        }

 
        private void getNumber(int noRows)
        {
            drCustomer = dsRunway.Tables["Customer"].Rows[noRows - 1];
            lblAddCustomerNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }

        private void btnAddDelete_Click(object sender, EventArgs e)
        {

            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drCustomer = dsRunway.Tables["Customer"].Rows.Find(dgvCustomers.SelectedRows[0].Cells[0].Value);
                String tempName = drCustomer["CustomerForename"].ToString() + "" + drCustomer["CustomerSurname"].ToString() + "\'s";
                if (MessageBox.Show("Are you sure your want to delete " + tempName + " details?", " Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(dsRunway, "Customer");
                }
            }
        }

        private void dtpAddDOB_ValueChanged(object sender, EventArgs e)
        {

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
            //nudEditDiscount.Enabled = enabled;
            if (enabled) btnEditEdit.Text = "Save";
            else btnEditEdit.Text = "Edit";
        }
        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (btnEditEdit.Text == "Edit")
            {
                ChangeFormEnabled(true);
            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errP.Clear();


                try
                {
                    myCustomer.IDNo = Convert.ToInt32(lblEditCustomerNo.Text.Trim());
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(lblEditCustomerNo, MyException.toString());
                }

                try
                {
                    myCustomer.Title = cmbEditTitle.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(cmbEditTitle, MyException.toString());
                }

                try
                {
                    myCustomer.Surname = txtEditSurname.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyException.toString());
                }

                try
                {
                    myCustomer.Forename = txtEditForename.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditForename, MyException.toString());
                }

                try
                {
                    myCustomer.Street = txtEditStreet.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditStreet, MyException.toString());
                }

                try
                {
                    myCustomer.Town = txtEditTown.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditTown, MyException.toString());
                }

                try
                {
                    myCustomer.County = txtEditCounty.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditCounty, MyException.toString());
                }

                try
                {
                    myCustomer.Country = txtEditCountry.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditCountry, MyException.toString());
                }

                try
                {
                    myCustomer.Postcode = txtEditPostcode.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditPostcode, MyException.toString());
                }

                try
                {
                    myCustomer.TelNo = txtEditTelNo.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditTelNo, MyException.toString());
                }
                try
                {
                    myCustomer.Email = txtEditEmail.Text.Trim();
                }
                catch (MyException MyException)
                {
                    ok = false;
                    errP.SetError(txtEditEmail, MyException.toString());
                }
            
                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();
                        drCustomer["CustomerNo"] = myCustomer.IDNo;
                        drCustomer["CustomerTitle"] = myCustomer.Title;
                        drCustomer["CustomerForename"] = myCustomer.Forename;
                        drCustomer["CustomerSurname"] = myCustomer.Surname;
                        drCustomer["CustomerStreet"] = myCustomer.Street;
                        drCustomer["CustomerTown"] = myCustomer.Town;
                        drCustomer["CustomerCounty"] = myCustomer.County;
                        drCustomer["CustomerCountry"] = myCustomer.Country;
                        drCustomer["CustomerPostcode"] = myCustomer.Postcode;
                        drCustomer["CustomerTelNo"] = myCustomer.TelNo;
                        drCustomer["CustomerEmail"] = myCustomer.Email;
                     
                        drCustomer.EndEdit();
                        daCustomer.Update(dsRunway, "Customer");
                        MessageBox.Show("Customer Details Updated", "Customer");

                        ChangeFormEnabled(false);
                        tabCustomer.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
    }
}
   