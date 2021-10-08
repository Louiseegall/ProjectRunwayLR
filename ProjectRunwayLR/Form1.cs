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
    public partial class Form1 : Form
    {
        Boolean vis;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrMenu.Enabled = true;
            timer1.Enabled = true;
            vis = !vis;
           

        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (vis)
            {
                if (pnlMenu.Left > -160)
                {
                    pnlMenu.Left -= 50;

                }
                else
                {
                    tmrMenu.Enabled = false;
                }
   
              
            }
            else
            {
                if (pnlMenu.Left < 0)
                {
                    pnlMenu.Left += 50;

                }
                else
                {
                    tmrMenu.Enabled = false;
                }
                      
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vis)
            {
                if (pictureBox1.Left < 0)
                {
                    pictureBox1.Left += 60;

                }
                else
                {
                    timer1.Enabled = false;
                }

                
            }
            else
            {
               
                
                if (pictureBox1.Left > -360)
                {
                    pictureBox1.Left -= 60;

                }
                else
                {
                    timer1.Enabled = false;
                }
            }
        }
    }
}
