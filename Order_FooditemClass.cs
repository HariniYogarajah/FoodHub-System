using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class Order_FooditemClass
    {
        TextBox OFI_NotextBox;
        ComboBox Item_NumbercomboBox, Order_NocomboBox;
        DataGridView Order_Food_ItemdataGridView;

        public Order_FooditemClass(TextBox OFI_NoBox, ComboBox Item_NumberBox, ComboBox Order_NoBox, DataGridView Order_Food_ItemGrid)
        {
            OFI_NotextBox = OFI_NoBox;
            Item_NumbercomboBox = Item_NumberBox;
            Order_NocomboBox = Order_NoBox;
            Order_Food_ItemdataGridView = Order_Food_ItemGrid;

            Order_Food_ItemdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Order_Food_Item ";
            GeneralClass.loadGridView(sql, Order_Food_ItemdataGridView);

            string item = "select * from Food_Item;";
            GeneralClass.LoadComboBox(item, Item_NumbercomboBox, "Item_Number", "Item_Name");

            string orders = "SELECT * from Orders;";
            GeneralClass.LoadComboBox(orders, Order_NocomboBox, "Order_No", "Order_No");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Order_Food_Item (Item_Number, Order_No) VALUES ({Item_NumbercomboBox.SelectedValue.ToString()}, {Order_NocomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Order_Food_Item SET Item_Number = {Item_NumbercomboBox.SelectedValue.ToString()}, Order_No = {Order_NocomboBox.SelectedValue.ToString()} WHERE OFI_No = {OFI_NotextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"delete from student_table WHERE OFI_No = {OFI_NotextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            OFI_NotextBox.Text = Order_Food_ItemdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Item_NumbercomboBox.Text = Order_Food_ItemdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Order_NocomboBox.Text = Order_Food_ItemdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }
    }
}
