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
    public partial class Staff : Form
    {
        StaffClass StaffClass;
        public Staff()
        {
            InitializeComponent();
            StaffClass = new StaffClass(Emp_IDtextBox, Emp_NametextBox, NICtextBox, DOBdateTimePicker, AgetextBox, Contact_NotextBox, User_NametextBox, PasswordtextBox, StaffdataGridView);
            StaffClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StaffClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            StaffClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            StaffClass.delete();
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

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Emp_IDtextBox.Clear();
            Emp_NametextBox.Clear();
            NICtextBox.Clear();
            AgetextBox.Clear();
            Contact_NotextBox.Clear();
            User_NametextBox.Clear();
            PasswordtextBox.Clear();
        }
    }
}
