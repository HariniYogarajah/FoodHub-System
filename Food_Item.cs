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
    public partial class Food_Item : Form
    {
        FooditemClass fooditemClass;
        public Food_Item()
        {
            InitializeComponent();
            fooditemClass = new FooditemClass(Item_NumbertextBox, Item_NametextBox, Item_CategorytextBox, PricetextBox, Food_ItemdataGridView);
            fooditemClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            fooditemClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            fooditemClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            fooditemClass.delete();
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

        private void Food_Item_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Item_NumbertextBox.Clear();
            Item_NametextBox.Clear();
            Item_CategorytextBox.Clear();
            PricetextBox.Clear();
        }
    }
}
