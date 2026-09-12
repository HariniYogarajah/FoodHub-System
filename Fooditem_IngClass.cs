using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class Fooditem_IngClass
    {
        TextBox FiI_NotextBox;
        ComboBox Item_NumbercomboBox, Ing_IDcomboBox;
        DataGridView FoodItem_IngdataGridView;

        public Fooditem_IngClass(TextBox FiI_NoBox, ComboBox Item_NumberBox, ComboBox Ing_IDBox, DataGridView FoodItem_IngGrid)
        {
            FiI_NotextBox = FiI_NoBox;
            Item_NumbercomboBox = Item_NumberBox;
            Ing_IDcomboBox = Ing_IDBox;
            FoodItem_IngdataGridView = FoodItem_IngGrid;

            FoodItem_IngdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Fooditem_Ing";
            GeneralClass.loadGridView(sql, FoodItem_IngdataGridView);

            string item = "select * from Food_Item;";
            GeneralClass.LoadComboBox(item, Item_NumbercomboBox, "Item_Number", "Item_Name" );

            string Ing = "select * from Ingredient;";
            GeneralClass.LoadComboBox(Ing, Ing_IDcomboBox, "Ing_ID", "Ing_Name");


        }
        public void save()
        {
            string saveSql = $"INSERT INTO Fooditem_Ing (Ing_ID, Item_Number) VALUES ({Ing_IDcomboBox.SelectedValue.ToString()}, {Item_NumbercomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE  Fooditem_Ing SET Ing_ID = {Ing_IDcomboBox.SelectedValue.ToString()}, Item_Number = {Item_NumbercomboBox.SelectedValue.ToString()} WHERE FiI_No = {FiI_NotextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Fooditem_Ing WHERE FiI_No = {FiI_NotextBox.Text};";

            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            FiI_NotextBox.Text = FoodItem_IngdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Item_NumbercomboBox.Text = FoodItem_IngdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Ing_IDcomboBox.Text = FoodItem_IngdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }
    }
}
