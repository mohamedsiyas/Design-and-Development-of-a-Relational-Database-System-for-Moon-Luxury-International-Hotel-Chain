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
    public partial class M_L_H_RoomInterface : UserControl
    {
        function fn = new function();
        String query;

        public M_L_H_RoomInterface()
        {
            InitializeComponent();
        }

        private void M_L_H_RoomInterface_Load(object sender, EventArgs e)
        {
            query = "SELECT R.Room_ID, R.Room_type, R.Room_availability, P.Price\r\nFROM Room R\r\nJOIN Room_Price P ON R.Room_type = P.Room_type";
            DataSet ds = fn.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomtype.Text != "" && txtPrice.Text != "" && txtRoomavailability.Text != "")
            {
                String Roomtype = txtRoomtype.Text;
                String Rooavailability = txtRoomavailability.Text;
                String Price = txtPrice.Text;
                query = "insert into Room (Room_type,Room_availability) values ('" + Roomtype + "','" + Rooavailability + "')";
                fn.setData(query, "Room Interface");

                query = "SELECT COUNT(*) FROM Room_Price WHERE Room_type = '" + Roomtype + "'";
                int count = Convert.ToInt32(fn.getData(query).Tables[0].Rows[0][0]);

                if (count == 0)
                {
                    query = "INSERT INTO Room_Price (Room_type, Price) VALUES ('" + Roomtype + "', " + Price + ")";
                    fn.setData(query, "Guest Interface");
                }
                else
                {


                    query = "UPDATE Room_Price SET Price = " + Price + " WHERE Room_type = '" + Roomtype + "'";
                    fn.setData(query, "Guest Interface");
                }
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshDataGridView()
        {
            query = "SELECT R.Room_ID, R.Room_type, R.Room_availability, P.Price\r\nFROM Room R\r\nJOIN Room_Price P ON R.Room_type = P.Room_type";
            DataSet ds = fn.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }
    }
}
