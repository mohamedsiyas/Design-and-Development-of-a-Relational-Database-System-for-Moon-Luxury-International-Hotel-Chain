using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Moon_Luxury_Hotel
{
    public partial class M_L_H_ReservationDetails : UserControl
    {
        function fn = new function();
        String query;


        public M_L_H_ReservationDetails()
        {
            InitializeComponent();
        }

        private void M_L_H_ReservationDetails_Load(object sender, EventArgs e)
        {
            LoadReservationData();
            
        }

        private void LoadReservationData()
        {
            query = "SELECT R.Reservation_ID, R.Guest_ID, R.Room_ID, R.Service_ID, R.Check_in_Date, R.Check_out_Date, R.Booking_Date, R.Payment_status, " +
                   "G.First_Name + ' ' + G.Last_Name as GuestName, " +
                   "Ro.Room_type, " +
                   "S.Service_Name " +
                   "FROM Reservation R " +
                   "JOIN Guest G ON R.Guest_ID = G.Guest_ID " +
                   "JOIN Room Ro ON R.Room_ID = Ro.Room_ID " +
                   "JOIN Services S ON R.Service_ID = S.Service_ID";

            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(intGuestID.Text, out int guestID) &&
                int.TryParse(intRoomID.Text, out int roomID) &&
                int.TryParse(intServiceID.Text, out int serviceID))
            {
                DateTime checkInDate = DatetimeCheckinDate.Value;
                DateTime checkOutDate = DatetimeCheckOutDate.Value;
                DateTime bookingDate = DatetimeBookingDate.Value;
                string paymentStatus = txtPaymentstatus.Text;

                query = "INSERT INTO Reservation (Guest_ID, Room_ID, Service_ID, Check_in_Date, Check_out_Date, Booking_Date, Payment_status) " +
                        $"VALUES ({guestID}, {roomID}, {serviceID}, '{checkInDate.ToString("yyyy-MM-dd")}', " +
                        $"'{checkOutDate.ToString("yyyy-MM-dd")}', '{bookingDate.ToString("yyyy-MM-dd")}', '{paymentStatus}')";


                fn.setData(query, "Reservation Interface");
                LoadReservationData();

            }
            else
            {
                MessageBox.Show("Invalid input for Guest ID, Room ID, or Service ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
