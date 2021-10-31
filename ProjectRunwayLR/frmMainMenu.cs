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
    public partial class frmMainMenu : Form
    {
        bool menuOpen = true;
        bool menuChanging = false;
        int menuWidth = 0;
        int menuSpeed = 10;
        Form currentForm = null;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!menuChanging)
            {
                menuChanging = true;
                menuWidth = tlpMenu.Width;
                menuSpeed = 10 + menuWidth / 100;
                menuTimer.Start();
            }
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuOpen)
            {
                if (tlpMenu.Left != -menuWidth)
                {
                    tlpMenu.Left -= menuSpeed;
                    if (tlpMenu.Left < -menuWidth)
                    {
                        tlpMenu.Left = -menuWidth;
                    }
                }
                else
                {
                    if (pnlContent.Top > 60)
                    {
                        pnlContent.Top -= menuSpeed / 2;
                        pnlContent.Height += menuSpeed / 2;
                        if (pnlContent.Top < 60)
                        {
                            pnlContent.Height -= 60 - pnlContent.Top;
                            pnlContent.Top = 60;
                        }
                    }
                    else
                    {
                        menuOpen = false;
                        menuChanging = false;
                        menuTimer.Stop();
                    }
                }
            }
            else
            {
                if (pnlContent.Top < 110)
                {
                    pnlContent.Top += menuSpeed / 2;
                    pnlContent.Height -= menuSpeed / 2;
                    if (pnlContent.Top > 120)
                    {
                        pnlContent.Height += pnlContent.Top - 120;
                        pnlContent.Top = 120;
                    }


                }
                else
                {
                    if (tlpMenu.Left != 10)
                    {
                        tlpMenu.Left += menuSpeed;
                        if (tlpMenu.Left > 10) tlpMenu.Left = 10;
                    }
                    else
                    {
                        menuOpen = true;
                        menuChanging = false;
                        menuTimer.Stop();
                    }
                }
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
