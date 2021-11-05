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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
