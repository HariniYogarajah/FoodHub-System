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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cust = new Customer();
            cust.Show();
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order ord = new Order();
            ord.Show();
        }

        private void Food_Itembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Food_Item fooditem = new Food_Item();
            fooditem.Show();
        }

        private void Order_Food_Itembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_FoodItem ordfooditem = new Order_FoodItem();
            ordfooditem.Show();
        }

        private void Ingredientbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingredient ing = new Ingredient();
            ing.Show();
        }

        private void FoodItem_Ingbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodItem_Ing fooditeming = new FoodItem_Ing();
            fooditeming.Show();
        }

        private void Staffbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staffs = new Staff();
            staffs.Show();
        }

        private void Riderbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rider riders = new Rider();
            riders.Show();
        }

        private void Motor_Bikebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Motor_Bike mb = new Motor_Bike();
            mb.Show();
        }

        private void Motor_Bike_Riderbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void Themebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theme themes = new Theme();
            themes.Show();
        }

        private void Contactbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cust_Contact custcont = new Cust_Contact();
            custcont.Show();
        }

        private void Dependentbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dependent dep = new Dependent();
            dep.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You have logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
