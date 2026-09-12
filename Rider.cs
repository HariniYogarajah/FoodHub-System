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
    public partial class Rider : Form
    {
        RiderClass riderClass;
        public Rider()
        {
            InitializeComponent();
            riderClass = new RiderClass(Emp_IDtextBox, First_NametextBox, Middle_NametextBox, Last_NametextBox, DOBdateTimePicker, AgetextBox, NICtextBox, Contact_NotextBox, Lic_NotextBox, AddresstextBox, User_NametextBox, PasswordtextBox, RiderdataGridView);
            riderClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            riderClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            riderClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            riderClass.delete();
            Clear();
        }

        private void Rider_Load(object sender, EventArgs e)
        {

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

        public void Clear()
        {
            Emp_IDtextBox.Clear();
            First_NametextBox.Clear();
            Middle_NametextBox.Clear();
            Last_NametextBox.Clear();
            AgetextBox.Clear();
            NICtextBox.Clear();
            Contact_NotextBox.Clear();
            Lic_NotextBox.Clear();
            AddresstextBox.Clear();
            User_NametextBox.Clear();
            PasswordtextBox.Clear();
        }
    }
}
