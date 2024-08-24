namespace Login
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBillInterface = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservationDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnServiceInterface = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomInterface = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuestInterface = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.m_L_H_ReservationDetails1 = new Login.Moon_Luxury_Hotel.M_L_H_ReservationDetails();
            this.m_L_H_ServiceInterface1 = new Login.Moon_Luxury_Hotel.M_L_H_ServiceInterface();
            this.m_L_H_RoomInterface1 = new Login.Moon_Luxury_Hotel.M_L_H_RoomInterface();
            this.m_L_H_GuestInterface1 = new Login.Moon_Luxury_Hotel.M_L_H_GuestInterface();
            this.m_L_H_BillInterface1 = new Login.Moon_Luxury_Hotel.M_L_H_BillInterface();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnBillInterface);
            this.panel1.Controls.Add(this.btnReservationDetails);
            this.panel1.Controls.Add(this.btnServiceInterface);
            this.panel1.Controls.Add(this.btnRoomInterface);
            this.panel1.Controls.Add(this.btnGuestInterface);
            this.panel1.Location = new System.Drawing.Point(42, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MovingPanel.Location = new System.Drawing.Point(24, 95);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(199, 5);
            this.MovingPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(180, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 5;
            // 
            // btnBillInterface
            // 
            this.btnBillInterface.BorderRadius = 26;
            this.btnBillInterface.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBillInterface.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnBillInterface.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBillInterface.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillInterface.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillInterface.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillInterface.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillInterface.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnBillInterface.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillInterface.ForeColor = System.Drawing.Color.White;
            this.btnBillInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnBillInterface.Image")));
            this.btnBillInterface.Location = new System.Drawing.Point(1003, 15);
            this.btnBillInterface.Name = "btnBillInterface";
            this.btnBillInterface.Size = new System.Drawing.Size(231, 85);
            this.btnBillInterface.TabIndex = 4;
            this.btnBillInterface.Text = "Bill Interface  ";
            this.btnBillInterface.Click += new System.EventHandler(this.btnBillInterface_Click);
            // 
            // btnReservationDetails
            // 
            this.btnReservationDetails.BorderRadius = 26;
            this.btnReservationDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReservationDetails.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnReservationDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnReservationDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservationDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservationDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservationDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservationDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnReservationDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationDetails.ForeColor = System.Drawing.Color.White;
            this.btnReservationDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationDetails.Image")));
            this.btnReservationDetails.Location = new System.Drawing.Point(754, 15);
            this.btnReservationDetails.Name = "btnReservationDetails";
            this.btnReservationDetails.Size = new System.Drawing.Size(232, 85);
            this.btnReservationDetails.TabIndex = 3;
            this.btnReservationDetails.Text = "Reservation Details  ";
            this.btnReservationDetails.Click += new System.EventHandler(this.btnReservatinDetails_Click);
            // 
            // btnServiceInterface
            // 
            this.btnServiceInterface.BorderRadius = 26;
            this.btnServiceInterface.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnServiceInterface.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnServiceInterface.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnServiceInterface.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServiceInterface.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServiceInterface.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServiceInterface.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServiceInterface.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnServiceInterface.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceInterface.ForeColor = System.Drawing.Color.White;
            this.btnServiceInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceInterface.Image")));
            this.btnServiceInterface.Location = new System.Drawing.Point(502, 15);
            this.btnServiceInterface.Name = "btnServiceInterface";
            this.btnServiceInterface.Size = new System.Drawing.Size(234, 85);
            this.btnServiceInterface.TabIndex = 2;
            this.btnServiceInterface.Text = " Service Interface ";
            this.btnServiceInterface.Click += new System.EventHandler(this.btnServiceInterface_Click);
            // 
            // btnRoomInterface
            // 
            this.btnRoomInterface.BorderRadius = 26;
            this.btnRoomInterface.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoomInterface.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnRoomInterface.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnRoomInterface.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomInterface.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomInterface.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomInterface.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomInterface.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnRoomInterface.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomInterface.ForeColor = System.Drawing.Color.White;
            this.btnRoomInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomInterface.Image")));
            this.btnRoomInterface.Location = new System.Drawing.Point(255, 15);
            this.btnRoomInterface.Name = "btnRoomInterface";
            this.btnRoomInterface.Size = new System.Drawing.Size(231, 85);
            this.btnRoomInterface.TabIndex = 1;
            this.btnRoomInterface.Text = "Room Interface ";
            this.btnRoomInterface.Click += new System.EventHandler(this.btnRoomInterface_Click);
            // 
            // btnGuestInterface
            // 
            this.btnGuestInterface.BorderRadius = 26;
            this.btnGuestInterface.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuestInterface.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnGuestInterface.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnGuestInterface.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuestInterface.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuestInterface.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuestInterface.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuestInterface.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnGuestInterface.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestInterface.ForeColor = System.Drawing.Color.White;
            this.btnGuestInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestInterface.Image")));
            this.btnGuestInterface.Location = new System.Drawing.Point(3, 15);
            this.btnGuestInterface.Name = "btnGuestInterface";
            this.btnGuestInterface.Size = new System.Drawing.Size(234, 85);
            this.btnGuestInterface.TabIndex = 0;
            this.btnGuestInterface.Text = "Guest Interface ";
            this.btnGuestInterface.Click += new System.EventHandler(this.btnGuestInterface_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.m_L_H_BillInterface1);
            this.panel2.Controls.Add(this.m_L_H_ReservationDetails1);
            this.panel2.Controls.Add(this.m_L_H_ServiceInterface1);
            this.panel2.Controls.Add(this.m_L_H_RoomInterface1);
            this.panel2.Controls.Add(this.m_L_H_GuestInterface1);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 609);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(-2, -5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(38, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(-2, 36);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(38, 45);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // m_L_H_ReservationDetails1
            // 
            this.m_L_H_ReservationDetails1.BackColor = System.Drawing.Color.White;
            this.m_L_H_ReservationDetails1.Location = new System.Drawing.Point(-2, -2);
            this.m_L_H_ReservationDetails1.Name = "m_L_H_ReservationDetails1";
            this.m_L_H_ReservationDetails1.Size = new System.Drawing.Size(1290, 609);
            this.m_L_H_ReservationDetails1.TabIndex = 3;
            // 
            // m_L_H_ServiceInterface1
            // 
            this.m_L_H_ServiceInterface1.BackColor = System.Drawing.Color.White;
            this.m_L_H_ServiceInterface1.Location = new System.Drawing.Point(3, -2);
            this.m_L_H_ServiceInterface1.Name = "m_L_H_ServiceInterface1";
            this.m_L_H_ServiceInterface1.Size = new System.Drawing.Size(1300, 609);
            this.m_L_H_ServiceInterface1.TabIndex = 2;
            // 
            // m_L_H_RoomInterface1
            // 
            this.m_L_H_RoomInterface1.BackColor = System.Drawing.Color.White;
            this.m_L_H_RoomInterface1.Location = new System.Drawing.Point(-2, -2);
            this.m_L_H_RoomInterface1.Name = "m_L_H_RoomInterface1";
            this.m_L_H_RoomInterface1.Size = new System.Drawing.Size(1290, 609);
            this.m_L_H_RoomInterface1.TabIndex = 1;
            // 
            // m_L_H_GuestInterface1
            // 
            this.m_L_H_GuestInterface1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_L_H_GuestInterface1.Location = new System.Drawing.Point(-2, -2);
            this.m_L_H_GuestInterface1.Name = "m_L_H_GuestInterface1";
            this.m_L_H_GuestInterface1.Size = new System.Drawing.Size(1290, 609);
            this.m_L_H_GuestInterface1.TabIndex = 0;
            // 
            // m_L_H_BillInterface1
            // 
            this.m_L_H_BillInterface1.BackColor = System.Drawing.Color.White;
            this.m_L_H_BillInterface1.Location = new System.Drawing.Point(-2, -2);
            this.m_L_H_BillInterface1.Name = "m_L_H_BillInterface1";
            this.m_L_H_BillInterface1.Size = new System.Drawing.Size(1290, 609);
            this.m_L_H_BillInterface1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1329, 788);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnGuestInterface;
        private Guna.UI2.WinForms.Guna2Button btnBillInterface;
        private Guna.UI2.WinForms.Guna2Button btnReservationDetails;
        private Guna.UI2.WinForms.Guna2Button btnServiceInterface;
        private Guna.UI2.WinForms.Guna2Button btnRoomInterface;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MovingPanel;
        private Moon_Luxury_Hotel.M_L_H_GuestInterface m_L_H_GuestInterface1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Moon_Luxury_Hotel.M_L_H_RoomInterface m_L_H_RoomInterface1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Moon_Luxury_Hotel.M_L_H_ServiceInterface m_L_H_ServiceInterface1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Moon_Luxury_Hotel.M_L_H_ReservationDetails m_L_H_ReservationDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Moon_Luxury_Hotel.M_L_H_BillInterface m_L_H_BillInterface1;
    }
}