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
    public partial class PreferenceForm : Form
    {
        public PreferenceForm()
        {
            InitializeComponent();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffRegister reg = new StaffRegister();
            reg.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PreferenceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
