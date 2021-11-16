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

    }
}