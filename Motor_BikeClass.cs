using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class Motor_BikeClass
    {
        TextBox Register_NotextBox, BrandtextBox, ModeltextBox, Engine_NotextBox, ColourtextBox;
        DateTimePicker Veg_Reg_DatedateTimePicker;
        ComboBox Theme_IDcomboBox;
        DataGridView Motor_BikedataGridView;

        public Motor_BikeClass(TextBox Register_NoBox, DateTimePicker Veg_Reg_DateBox, TextBox BrandBox, TextBox ModelBox, TextBox Engine_NoBox, TextBox ColourBox, ComboBox Theme_IDBox, DataGridView Motor_BikeGrid)
        {
            Register_NotextBox = Register_NoBox;
            Veg_Reg_DatedateTimePicker = Veg_Reg_DateBox;
            BrandtextBox = BrandBox;
            ModeltextBox = ModelBox;
            Engine_NotextBox = Engine_NoBox;
            ColourtextBox = ColourBox;
            Theme_IDcomboBox = Theme_IDBox;
            Motor_BikedataGridView = Motor_BikeGrid;

            Motor_BikedataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Motor_Bike";
            GeneralClass.loadGridView(sql, Motor_BikedataGridView);

            string item = "SELECT * from Theme;";
            GeneralClass.LoadComboBox(item, Theme_IDcomboBox, "Theme_ID", "Colour");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Motor_Bike (Veg_Reg_Date, Brand, Model, Engine_No, Colour, Theme_ID) VALUES ('{Veg_Reg_DatedateTimePicker.Value.ToString()}', '{BrandtextBox.Text}', '{ModeltextBox.Text}', {Engine_NotextBox.Text}, '{ColourtextBox.Text}', {Theme_IDcomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Motor_Bike SET Veg_Reg_Date = '{Veg_Reg_DatedateTimePicker.Value.ToString()}', Brand = '{BrandtextBox.Text}', Model = '{ModeltextBox.Text}', Engine_No = {Engine_NotextBox.Text}, Theme_ID = {Theme_IDcomboBox.SelectedValue.ToString()} WHERE Register_No = '{Register_NotextBox.Text}';";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Motor_Bike WHERE Register_No = '{Register_NotextBox.Text}';";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Register_NotextBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Veg_Reg_DatedateTimePicker.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            BrandtextBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            ModeltextBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Engine_NotextBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            ColourtextBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            Theme_IDcomboBox.Text = Motor_BikedataGridView.Rows[rowIndex].Cells[6].Value.ToString();
        }

    }
}
