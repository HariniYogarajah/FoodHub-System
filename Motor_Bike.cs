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
    public partial class Motor_Bike : Form
    {
        Motor_BikeClass mbClass;

        public Motor_Bike()
        {
            InitializeComponent();
            mbClass = new Motor_BikeClass(Register_NotextBox, Veg_Reg_DatedateTimePicker, BrandtextBox, ModeltextBox, Engine_NotextBox, ColourtextBox, Theme_IDcomboBox, Motor_BikedataGridView);
            mbClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            mbClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            mbClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            mbClass.delete();
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

        private void Motor_Bike_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Register_NotextBox.Clear();
            BrandtextBox.Clear();
            ModeltextBox.Clear();
            Engine_NotextBox.Clear();
            ColourtextBox.Clear();
        }
    }
}
