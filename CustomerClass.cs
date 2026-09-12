using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class CustomerClass
    {
        TextBox Cus_IDtextBox, Cus_NametextBox, NICtextBox, LanetextBox, CitytextBox, StreettextBox, Loc_NumbertextBox;
        DateTimePicker DOBdateTimePicker;
        DataGridView CustomerdataGridView;

        public CustomerClass(TextBox Cus_IDBox, TextBox Cus_NameBox, TextBox NICBox, DateTimePicker DOBBox, TextBox LaneBox, TextBox CityBox, TextBox StreetBox, TextBox Loc_NumberBox, DataGridView customerGrid)
        {
            Cus_IDtextBox = Cus_IDBox;
            Cus_NametextBox = Cus_NameBox;
            NICtextBox = NICBox;
            DOBdateTimePicker = DOBBox;
            LanetextBox = LaneBox;
            CitytextBox = CityBox;
            StreettextBox = StreetBox;
            Loc_NumbertextBox = Loc_NumberBox;
            CustomerdataGridView = customerGrid;

            CustomerdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Customer";
            GeneralClass.loadGridView(sql, CustomerdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Customer (Cus_Name,NIC,DOB,Loc_Number,Lane,City,Street) VALUES ('{Cus_NametextBox.Text}', {NICtextBox.Text}, '{DOBdateTimePicker.Value.ToString("yyyy/MM/dd")}', {Loc_NumbertextBox.Text}, '{LanetextBox.Text}', '{CitytextBox.Text}', '{StreettextBox.Text}');";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Customer set Cus_Name = '{Cus_NametextBox.Text}', NIC = {NICtextBox.Text}, DOB = '{DOBdateTimePicker.Value.ToString()}', Loc_Number = {Loc_NumbertextBox.Text}, Lane = '{LanetextBox.Text}', Street = '{StreettextBox.Text}', City = '{CitytextBox.Text}'WHERE Cus_ID = {Cus_IDtextBox.Text}; ";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Customer WHERE Cus_ID = {Cus_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Cus_IDtextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Cus_NametextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            NICtextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            DOBdateTimePicker.Text = CustomerdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            LanetextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            CitytextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            StreettextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            Loc_NumbertextBox.Text = CustomerdataGridView.Rows[rowIndex].Cells[7].Value.ToString();
        }
    }
}
