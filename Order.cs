using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    public partial class Order : Form
    {
        OrderClass orderClass;
        public Order()
        {
            InitializeComponent();
            orderClass = new OrderClass(Order_NotextBox, Order_StatustextBox, Order_TimedateTimePicker, Order_DatedateTimePicker, PaymenttextBox, Dispat_TimedateTimePicker, Cus_IDcomboBox, Emp_IDcomboBox, Emp_NocomboBox, OrderdataGridView);
            orderClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            orderClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            orderClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            orderClass.delete();
            Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Order_NotextBox.Clear();
            Order_StatustextBox.Clear();
            PaymenttextBox.Clear();
        }
    }
}
