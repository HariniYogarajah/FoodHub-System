using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class StaffClass
    {
        TextBox Emp_IDtextBox, Emp_NametextBox, NICtextBox, AgetextBox, Contact_NotextBox, User_NametextBox, PasswordtextBox;
        DateTimePicker DOBdateTimePicker;
        DataGridView StaffdataGridView;

        public StaffClass(TextBox Emp_IDBox, TextBox Emp_NameBox, TextBox NICBox, DateTimePicker DOBBox, TextBox AgeBox, TextBox Contact_NoBox, TextBox User_NameBox, TextBox PasswordBox, DataGridView StaffGrid)
        {
            Emp_IDtextBox = Emp_IDBox;
            Emp_NametextBox = Emp_NameBox;
            NICtextBox = NICBox;
            DOBdateTimePicker = DOBBox;
            AgetextBox = AgeBox;
            Contact_NotextBox = Contact_NoBox;
            User_NametextBox = User_NameBox;
            PasswordtextBox = PasswordBox;
            StaffdataGridView = StaffGrid;

            StaffdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Staff";
            GeneralClass.loadGridView(sql, StaffdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Staff (Empt_Name, DOB, Age, NIC, Contact_No, User_Name, Password) VALUES ('{Emp_NametextBox.Text}', '{DOBdateTimePicker.Value.ToString()}', {AgetextBox.Text}, {NICtextBox.Text}, {Contact_NotextBox.Text}, '{User_NametextBox.Text}', '{PasswordtextBox.Text}');";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Staff SET Empt_Name = '{Emp_NametextBox.Text}', DOB = '{DOBdateTimePicker.Value.ToString()}', Age = {AgetextBox.Text}, NIC = {NICtextBox.Text}, Contact_No = {Contact_NotextBox.Text}, User_Name = '{User_NametextBox.Text}', Password = '{PasswordtextBox.Text}' WHERE Emp_ID = {Emp_IDtextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Staff WHERE  Emp_ID = {Emp_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Emp_IDtextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Emp_NametextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            NICtextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            DOBdateTimePicker.Text = StaffdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            AgetextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            Contact_NotextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            User_NametextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            PasswordtextBox.Text = StaffdataGridView.Rows[rowIndex].Cells[7].Value.ToString();

        }
    }
}
