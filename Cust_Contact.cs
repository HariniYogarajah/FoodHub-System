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
    public partial class Cust_Contact : Form
    {
        CustContactClass custContactClass;
        public Cust_Contact()
        {
            InitializeComponent();
            custContactClass = new CustContactClass(Contact_IDtextBox, Phone_NotextBox, Cus_IDcomboBox, CustContactdataGridView);
            custContactClass.load();
        }

        private void Cust_Contact_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            custContactClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            custContactClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            custContactClass.delete();
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

        public void Clear()
        {
            Contact_IDtextBox.Clear();
            Phone_NotextBox.Clear();
        }
    }
}
