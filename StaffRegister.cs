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
    public partial class StaffRegister : Form
    {
        StaffRegisterClass staffRegisterClass;
        public StaffRegister()
        {
            InitializeComponent();
            staffRegisterClass = new StaffRegisterClass(Emp_NametextBox, NICtextBox, DOBdateTimePicker, AgetextBox, Contact_NotextBox, User_NametextBox, PasswordtextBox);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            staffRegisterClass.save();
            Clear();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void StaffRegister_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Emp_NametextBox.Clear();
            NICtextBox.Clear();
            AgetextBox.Clear();
            Contact_NotextBox.Clear();
            User_NametextBox.Clear();
            PasswordtextBox.Clear();
        }
    }
}
