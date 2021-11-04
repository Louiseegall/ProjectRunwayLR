﻿using System;
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
        int menuSpeed = 20;
        Form currentForm = null;
        public frmMainMenu()
        {
            InitializeComponent();
        }

      

        private void btnMenu_Click(object sender, EventArgs e)
        {

            if (!menuChanging)
            {
                menuChanging = true;
                menuWidth = tlpMenu.Width;
                menuSpeed = 20 + menuWidth / 100;
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
                    if (splitContent.Top > 120)
                    {
                        splitContent.Top -= menuSpeed / 2;
                        splitContent.Height += menuSpeed / 2;
                        if (splitContent.Top < 120)
                        {
                            splitContent.Height -= 120 - splitContent.Top;
                            splitContent.Top = 120;
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
                if (splitContent.Top < 185)
                {
                    splitContent.Top += menuSpeed / 2;
                    splitContent.Height -= menuSpeed / 2;
                    if (splitContent.Top > 185)
                    {
                        splitContent.Height += splitContent.Top - 185;
                        splitContent.Top = 185;
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


        private void frmMainMenu_SizeChanged(object sender, EventArgs e)
        {
            if (menuOpen)
            {
                tlpMenu.Left = 10;
            }
            else
            {
                tlpMenu.Left = -tlpMenu.Width;
            }
        }


        private void openForm(Form form)
        {

            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(form);
            form.ShowInTaskbar = false;
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmBooking))
            {
                currentForm = new frmBooking();
                openForm(currentForm);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmCustomer))
            {
                currentForm = new frmCustomer();
                openForm(currentForm);
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmStaff))
            {
                currentForm = new frmStaff();
                openForm(currentForm);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmTreatment))
            {
                currentForm = new frmTreatment();
                openForm(currentForm);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmSchedule))
            {
                currentForm = new frmSchedule();
                openForm(currentForm);
            }
        }

 
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmRoom))
            {
                currentForm = new frmRoom();
                openForm(currentForm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(currentForm is frmPayment))
            {
                currentForm = new frmPayment();
                openForm(currentForm);
            }
        }
    }
}