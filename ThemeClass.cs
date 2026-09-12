using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class ThemeClass
    {
        TextBox Theme_IDtextBox, ColourtextBox;
        DataGridView ThemedataGridView;

        public ThemeClass(TextBox Theme_IDBox, TextBox ColourBox, DataGridView ThemeGrid)
        {
            Theme_IDtextBox = Theme_IDBox;
            ColourtextBox = ColourBox;
            ThemedataGridView = ThemeGrid;

            ThemedataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Theme";
            GeneralClass.loadGridView(sql, ThemedataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Theme (Colour) VALUES ('{ColourtextBox.Text}');";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Theme SET Colour = '{ColourtextBox.Text}' WHERE Theme_ID = {Theme_IDtextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Theme WHERE Theme_ID = {Theme_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Theme_IDtextBox.Text = ThemedataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            ColourtextBox.Text = ThemedataGridView.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
