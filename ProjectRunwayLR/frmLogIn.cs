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
    public partial class frmLogIn : Form
    {
       public static String username;
        SqlDataAdapter daLogin;
        String connStr, sqlLogin;
        DataSet dsRunway = new DataSet(); //create new instance of a dataset- call dsRunway
       
        //SqlCommandBuilder cmdBLogin;
        //DataRow drCustomer;
        public frmLogIn()
        {
            InitializeComponent();
       }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {


            //.local host , initial catalog-DS name
           

           
            //cmdBCustomer = new SqlCommandBuilder(daCustomer);//builds structure of table
            //daCustomer.FillSchema(dsRunway, SchemaType.Source, "Customer");
            //daCustomer.Fill(dsRunway, "Customer");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            connStr = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";

            sqlLogin = @"select * from Login where UserName= '" + txtUsername.Text.Trim()
                + "' and UserPassword= '" + txtPassword.Text.Trim() + "'";

            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            daLogin.FillSchema(dsRunway, SchemaType.Source, "Login");
            daLogin.Fill(dsRunway, "Login");


            //frmMainMenu mainMenu = new frmMainMenu();
            if (dsRunway.Tables["Login"].Rows.Count == 1)
            {
                

              username = txtUsername.Text;
                Close(); 
            }
            else
            {
                MessageBox.Show("Invalid Credientials");
            }
           
        
            //mainMenu.Show();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb (255,250,237,174);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 250, 237, 174);

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Standard;

        }

        private void ckbShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow_Hide.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar =true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}