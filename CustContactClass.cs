using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class CustContactClass
    {
        TextBox Contact_IDtextBox, Phone_NotextBox;
        ComboBox Cus_IDcomboBox;
        DataGridView CustContactdataGridView;

        public CustContactClass(TextBox Contact_IDBox, TextBox Phone_NoBox, ComboBox Cus_IDBox, DataGridView CustContactGrid)
        {
            Contact_IDtextBox = Contact_IDBox;
            Phone_NotextBox = Phone_NoBox;
            Cus_IDcomboBox = Cus_IDBox;
            CustContactdataGridView = CustContactGrid;

            CustContactdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Contact";
            GeneralClass.loadGridView(sql, CustContactdataGridView);

            string customer = "SELECT * from Customer;";
            GeneralClass.LoadComboBox(customer, Cus_IDcomboBox, "Cus_ID", "Cus_Name");

           

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Contact (Phone_No, Cus_ID) VALUES ({Phone_NotextBox.Text}, {Cus_IDcomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Contact set Phone_No = {Phone_NotextBox.Text} WHERE Contact_ID = {Contact_IDtextBox.Text};";

            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Contact where Contact_ID = {Contact_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Contact_IDtextBox.Text = CustContactdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Phone_NotextBox.Text = CustContactdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Cus_IDcomboBox.Text = CustContactdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }
    }
}
