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
    public partial class M_L_H_ServiceInterface : UserControl
    {
        function fn = new function();
        String query;

        public M_L_H_ServiceInterface()
        {
            InitializeComponent();
        }

        private void M_L_H_ServiceInterface_Load(object sender, EventArgs e)
        {
            query = "select * from Services";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if(txtServiceName.Text != "" && txtPrice.Text != "")
            {
                String servicename = txtServiceName.Text;
                String Price = txtPrice.Text;

                query = "insert into Services (Service_Name,Price) values ('" + servicename + "','" + Price + "')";
                fn.setData(query, "Service Interface");

                M_L_H_ServiceInterface_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
