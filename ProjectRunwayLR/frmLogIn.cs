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
    public partial class frmLogIn : Form
    {
       public static String username;
        public frmLogIn()
        {
            InitializeComponent();
       }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frmMainMenu mainMenu = new frmMainMenu();
            username = txtUsername.Text;
            Close();
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
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar =false;
            }
        }

    }
}