using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class StaffRegisterClass
    {
        TextBox Emp_NametextBox, NICtextBox, AgetextBox, Contact_NotextBox, User_NametextBox, PasswordtextBox;
        DateTimePicker DOBdateTimePicker;

        public StaffRegisterClass(TextBox Emp_NameBox, TextBox NICBox, DateTimePicker DOBBox, TextBox AgeBox, TextBox Contact_NoBox, TextBox User_NameBox, TextBox PasswordBox)
        {
            Emp_NametextBox = Emp_NameBox;
            NICtextBox = NICBox;
            DOBdateTimePicker = DOBBox;
            AgetextBox = AgeBox;
            Contact_NotextBox = Contact_NoBox;
            User_NametextBox = User_NameBox;
            PasswordtextBox = PasswordBox;

        }


        public void save()
        {
            string saveSql = $"INSERT INTO Staff (Empt_Name, DOB, Age, NIC, Contact_No, User_Name, Password) VALUES ('{Emp_NametextBox.Text}', '{DOBdateTimePicker.Value.ToString()}', {AgetextBox.Text}, {NICtextBox.Text}, {Contact_NotextBox.Text}, '{User_NametextBox.Text}', '{PasswordtextBox.Text}');";
            GeneralClass.Save(saveSql);
        }

    }
}
