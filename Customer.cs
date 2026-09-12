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
    public partial class Customer : Form
    {
        CustomerClass CustomerClass;
        public Customer()
        {
            InitializeComponent();
            CustomerClass = new CustomerClass(Cus_IDtextBox, Cus_NametextBox, NICtextBox, DOBdateTimePicker, LanetextBox, CitytextBox, StreettextBox, Loc_NumbertextBox, CustomerdataGridView);
            CustomerClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CustomerClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            CustomerClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            CustomerClass.delete();
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

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Cus_IDtextBox.Clear();
            Cus_NametextBox.Clear();
            NICtextBox.Clear();
            LanetextBox.Clear();
            CitytextBox.Clear();
            StreettextBox.Clear();
            Loc_NumbertextBox.Clear();
        }
    }
}
