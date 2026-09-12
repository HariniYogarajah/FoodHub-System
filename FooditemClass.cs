using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class FooditemClass
    {
        TextBox Item_NumbertextBox, Item_NametextBox, Item_CategorytextBox, PricetextBox;
        DataGridView Food_ItemdataGridView;

        public FooditemClass(TextBox Item_NumberBox, TextBox Item_NameBox, TextBox Item_CategoryBox, TextBox PriceBox, DataGridView Food_ItemGrid)
        {
            Item_NumbertextBox = Item_NumberBox;
            Item_NametextBox = Item_NameBox;
            Item_CategorytextBox = Item_CategoryBox;
            PricetextBox = PriceBox;
            Food_ItemdataGridView = Food_ItemGrid;

            Food_ItemdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Food_Item";
            GeneralClass.loadGridView(sql, Food_ItemdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Food_Item (Item_Name, Item_Category, Price) VALUES ('{Item_NametextBox.Text}', '{Item_CategorytextBox.Text}', {PricetextBox.Text});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Food_Item set Item_Name = '{Item_NametextBox.Text}', Item_Category = '{Item_CategorytextBox.Text}', Price = {PricetextBox.Text} WHERE Item_Number = {Item_NumbertextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Food_Item WHERE Item_Number = {Item_NumbertextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Item_NumbertextBox.Text = Food_ItemdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Item_NametextBox.Text = Food_ItemdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Item_CategorytextBox.Text = Food_ItemdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            PricetextBox.Text = Food_ItemdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
