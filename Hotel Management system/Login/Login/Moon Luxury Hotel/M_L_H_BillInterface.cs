using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Moon_Luxury_Hotel
{
    public partial class M_L_H_BillInterface : UserControl
    {

        function fn = new function();
        String query;

        public M_L_H_BillInterface()
        {
            InitializeComponent();
        }

        private void M_L_H_BillInterface_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }

        private void LoadBillData()
        {
            query = "SELECT B.Bill_ID, B.Reservation_ID, R.Service_ID, R.Room_ID, RD.No_of_Days, RD.Room_charges, RD.Service_charges, RD.Taxes, B.Total_Payment " +
                   "FROM Bill B " +
                   "JOIN Reservation_Details RD ON B.Reservation_ID = RD.Reservation_ID " +
                   "JOIN Reservation R ON B.Reservation_ID = R.Reservation_ID";

            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(intReservationID.Text, out int reservationID) &&
                int.TryParse(intServiceID.Text, out int serviceID) &&
                int.TryParse(intRoomID.Text, out int roomID) &&
                int.TryParse(intNoofDays.Text, out int noOfDays) &&
                decimal.TryParse(txtRoomCharges.Text, out decimal roomCharges) &&
                decimal.TryParse(txtServiceCharges.Text, out decimal serviceCharges))
                

            {

                // Fixed tax rate (10%)
                decimal taxes = 0.1m;

                decimal totalPayment = CalculateTotalPayment( roomCharges, serviceCharges, taxes);

                txtTotalPayment.Text = totalPayment.ToString();



                query = "INSERT INTO Reservation_Details (Reservation_ID, Service_ID, Room_ID, No_of_Days, Room_charges, Service_charges, Taxes) " +
                        $"VALUES ({reservationID}, {serviceID}, {roomID}, {noOfDays}, {roomCharges}, {serviceCharges}, {taxes})";
                fn.setData(query, "Bill Interface");

                query = "INSERT INTO Bill (Reservation_ID, Total_Payment) " +
                        $"VALUES ({reservationID}, {totalPayment})";
                fn.setData(query, "Bill Interface");

                LoadBillData();


            }
            else
            {
                MessageBox.Show("Invalid input. Please check the entered values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculateTotalPayment(decimal roomCharges, decimal serviceCharges, decimal taxes)
        {
            decimal totalPayment = roomCharges + serviceCharges;
            totalPayment += totalPayment * taxes;  // adding taxes
            return totalPayment;

        }
    }
}
