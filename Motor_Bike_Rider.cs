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
    public partial class Motor_Bike_Rider : Form
    {
        MotorBike_RiderClass MotorBike_RiderClass;
        public Motor_Bike_Rider()
        {
            InitializeComponent();
            MotorBike_RiderClass = new MotorBike_RiderClass(MBR_IDtextBox, DatedateTimePicker, Start_MeterReadingtextBox, End_MeterReadingtextBox, Emp_NocomboBox, Register_NocomboBox, Motor_Bike_RiderdataGridView);
            MotorBike_RiderClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MotorBike_RiderClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            MotorBike_RiderClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MotorBike_RiderClass.delete();
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

        private void Motor_Bike_Rider_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            MBR_IDtextBox.Clear();
            Start_MeterReadingtextBox.Clear();
            End_MeterReadingtextBox.Clear();
        }
    }
}
