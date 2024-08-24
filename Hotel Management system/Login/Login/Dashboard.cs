using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRoomInterface_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnRoomInterface.Left + 18;

            m_L_H_RoomInterface1.Visible = true;
            m_L_H_RoomInterface1.BringToFront();
        }

        private void btnGuestInterface_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnGuestInterface.Left+18;
            m_L_H_GuestInterface1.Visible = true;
            m_L_H_GuestInterface1.BringToFront();
        }

        private void btnServiceInterface_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnServiceInterface.Left + 18;

            m_L_H_ServiceInterface1.Visible = true;
            m_L_H_ServiceInterface1.BringToFront();
        }

        private void btnReservatinDetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnReservationDetails.Left + 18;
            m_L_H_ReservationDetails1.Visible = true;
            m_L_H_ReservationDetails1.BringToFront();

        }

        private void btnBillInterface_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnBillInterface.Left + 18;
            m_L_H_BillInterface1.Visible = true;
            m_L_H_BillInterface1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            m_L_H_GuestInterface1.Visible = false;
            m_L_H_RoomInterface1.Visible = false;
            m_L_H_ServiceInterface1.Visible = false;
            m_L_H_ReservationDetails1.Visible = false;
            m_L_H_BillInterface1.Visible = false;
            btnGuestInterface.PerformClick();
        }
    }
}
