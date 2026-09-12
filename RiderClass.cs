using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class RiderClass
    {
        TextBox Emp_IDtextBox, First_NametextBox, Middle_NametextBox, Last_NametextBox, AgetextBox, NICtextBox, Contact_NotextBox, Lic_NotextBox, AddresstextBox, User_NametextBox, PasswordtextBox;
        DateTimePicker DOBdateTimePicker;
        DataGridView RiderdataGridView;

        public RiderClass(TextBox Emp_IDBox, TextBox First_NameBox, TextBox Middle_NameBox, TextBox Last_NameBox, DateTimePicker DOBBox, TextBox AgeBox, TextBox NICBox, TextBox Contact_NoBox, TextBox Lic_NoBox, TextBox AddressBox, TextBox User_NameBox, TextBox PasswordBox, DataGridView RiderGrid)
        {
            Emp_IDtextBox = Emp_IDBox;
            First_NametextBox = First_NameBox;
            Middle_NametextBox = Middle_NameBox;
            Last_NametextBox = Last_NameBox;
            DOBdateTimePicker = DOBBox;
            AgetextBox = AgeBox;
            NICtextBox = NICBox;
            Contact_NotextBox = Contact_NoBox;
            Lic_NotextBox = Lic_NoBox;
            AddresstextBox = AddressBox;
            User_NametextBox = User_NameBox;
            PasswordtextBox = PasswordBox;
            RiderdataGridView = RiderGrid;

            RiderdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Rider";
            GeneralClass.loadGridView(sql, RiderdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Rider (First_Name, Middle_Name, Last_Name, DOB, Age, NIC, Contact_No, Lic_No, Address, User_Name, Password) VALUES ('{First_NametextBox.Text}', '{Middle_NametextBox.Text}', '{Last_NametextBox.Text}', '{DOBdateTimePicker.Value.ToString()}', {AgetextBox.Text}, {NICtextBox.Text}, {Contact_NotextBox.Text}, '{Lic_NotextBox.Text}', '{AddresstextBox.Text}', '{User_NametextBox.Text}', '{PasswordtextBox.Text}');";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Rider SET First_Name = '{First_NametextBox.Text}', Middle_Name = '{Middle_NametextBox.Text}', Last_Name = '{Last_NametextBox.Text}', DOB = '{DOBdateTimePicker.Value.ToString()}', Age = {AgetextBox.Text}, NIC = {NICtextBox.Text}, Contact_No = {Contact_NotextBox.Text}, Lic_No = '{Lic_NotextBox.Text}', Address = '{AddresstextBox.Text}', User_Name = '{User_NametextBox.Text}', Password = '{PasswordtextBox.Text}' WHERE Emp_ID = {Emp_IDtextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Rider WHERE Emp_ID = {Emp_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Emp_IDtextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            First_NametextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Middle_NametextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Last_NametextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            DOBdateTimePicker.Text = RiderdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            AgetextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            NICtextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            Contact_NotextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            Lic_NotextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[8].Value.ToString();
            AddresstextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[9].Value.ToString();
            User_NametextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[10].Value.ToString();
            PasswordtextBox.Text = RiderdataGridView.Rows[rowIndex].Cells[11].Value.ToString();
        }
    }
}
