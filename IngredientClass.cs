using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class IngredientClass
    {
        TextBox Ing_IDtextBox, Ing_NametextBox, QuantitytextBox;
        DataGridView IngredientdataGridView;

        public IngredientClass(TextBox Ing_IDBox, TextBox Ing_NameBox, TextBox QuantityBox, DataGridView IngredientGrid)
        {
            Ing_IDtextBox = Ing_IDBox;
            Ing_NametextBox = Ing_NameBox;
            QuantitytextBox = QuantityBox;
            IngredientdataGridView = IngredientGrid;

            IngredientdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Ingredient";
            GeneralClass.loadGridView(sql, IngredientdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Ingredient (Ing_Name, Quantity) VALUES ('{Ing_NametextBox.Text}', {QuantitytextBox.Text});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Ingredient SET Ing_Name = '{Ing_NametextBox.Text}', Quantity = {QuantitytextBox.Text} WHERE Ing_ID = {Ing_IDtextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Ingredient WHERE Ing_ID = {Ing_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Ing_IDtextBox.Text = IngredientdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Ing_NametextBox.Text = IngredientdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            QuantitytextBox.Text = IngredientdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }
    }
}
