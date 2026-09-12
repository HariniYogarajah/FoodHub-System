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
    public partial class FoodItem_Ing : Form
    {
        Fooditem_IngClass fooditem_IngClass;
        public FoodItem_Ing()
        {
            InitializeComponent();
            fooditem_IngClass = new Fooditem_IngClass(FiI_NotextBox, Item_NumbercomboBox, Ing_IDcomboBox, FoodItem_IngdataGridView);
            fooditem_IngClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            fooditem_IngClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            fooditem_IngClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            fooditem_IngClass.delete();
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

        private void FoodItem_Ing_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            FiI_NotextBox.Clear();
        }
    }
}
