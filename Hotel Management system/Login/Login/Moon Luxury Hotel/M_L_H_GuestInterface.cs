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
    public partial class M_L_H_GuestInterface : UserControl
    {
        function fn = new function();
        String query;

        public M_L_H_GuestInterface()
        {
            InitializeComponent();
        }

        private void M_L_H_GuestInterface_Load(object sender, EventArgs e)
        {
            query = "SELECT \r\n    g.Guest_ID, \r\n    g.First_Name, \r\n    g.Last_Name, \r\n    g.Address, \r\n    g.NIC_No, \r\n    g.Email, \r\n    g.Bed_type,\r\n    pn.Phone_No,\r\n    pr.Room_view\r\nFROM Guest g\r\nLEFT JOIN Guest_Phone_No pn\r\n    ON g.Guest_ID = pn.Guest_ID\r\nLEFT JOIN Preferences pr\r\n    ON g.Guest_ID = pr.Guest_ID;";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" && txtPhoneNo.Text != "" && txtNICNo.Text != "" && txtEmail.Text != "" && txtBedType.Text != "" && txtRoomView.Text != "")
            {
                String firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string address = txtAddress.Text;
                string nicno = txtNICNo.Text;
                string email = txtEmail.Text;
                string bedtype = txtBedType.Text;
                string roomview = txtRoomView.Text;

                query = "insert into Guest (First_Name,Last_Name,Address,NIC_No,Email,Bed_Type) values ('" + firstname + "','" + lastname + "','" + address + "','" + nicno + "','" + email + "','"+bedtype+"')";
                fn.setData(query, "Guest Interface");

                string phoneno = txtPhoneNo.Text;
                query = "insert into Guest_Phone_No (Phone_No) values ('" + phoneno + "')";
                fn.setData(query, "Guest Interface");


                query = "insert into Preferences (Bed_type,Room_View) values ('" + bedtype + "','" + roomview + "')";
                fn.setData(query, "Guest Interface");

                M_L_H_GuestInterface_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
