using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class OrderClass
    {
        TextBox Order_NotextBox, Order_StatustextBox, PaymenttextBox;
        DateTimePicker Order_TimedateTimePicker, Order_DatedateTimePicker, Dispat_TimedateTimePicker;
        ComboBox Cus_IDcomboBox, Emp_IDcomboBox, Emp_NocomboBox;
        DataGridView OrderdataGridView;

        public OrderClass(TextBox Order_NoBox, TextBox Order_StatusBox, DateTimePicker Order_TimeBox, DateTimePicker Order_DatedateBox, TextBox PaymentBox, DateTimePicker Dispat_TimeBox, ComboBox Cus_IDBox, ComboBox Emp_IDBox, ComboBox Emp_NoBox, DataGridView OrderGrid)
        {
            Order_NotextBox = Order_NoBox;
            Order_StatustextBox = Order_StatusBox;
            Order_TimedateTimePicker = Order_TimeBox;
            Order_DatedateTimePicker = Order_DatedateBox;
            PaymenttextBox = PaymentBox;
            Dispat_TimedateTimePicker = Dispat_TimeBox;
            Cus_IDcomboBox = Cus_IDBox;
            Emp_IDcomboBox = Emp_IDBox;
            Emp_NocomboBox = Emp_NoBox;
            OrderdataGridView = OrderGrid;

            OrderdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Orders";
            GeneralClass.loadGridView(sql, OrderdataGridView);

            string customer = "SELECT * from Customer;";
            GeneralClass.LoadComboBox(customer, Cus_IDcomboBox, "Cus_Name", "Cus_ID");

            string staff = "SELECT * from Staff;";
            GeneralClass.LoadComboBox(staff, Emp_IDcomboBox, "Empt_Name", "Emp_ID");

            string rider = "SELECT * from Rider;";
            GeneralClass.LoadComboBox(rider, Emp_NocomboBox, "First_Name", "Emp_No");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Orders (Order_Status, Order_Time, Order_Date, Payment, Dispat_Time, Cus_ID, Emp_ID, Emp_No) VALUES ('{Order_StatustextBox.Text}', '{Order_TimedateTimePicker.Value.ToString()}', '{Order_DatedateTimePicker.Value.ToString()}', '{PaymenttextBox.Text}', '{Dispat_TimedateTimePicker.Value.ToString()}', {Cus_IDcomboBox.SelectedValue.ToString()}, {Emp_IDcomboBox.SelectedValue.ToString()}, {Emp_NocomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Orders SET Order_Status = '{Order_StatustextBox.Text}', Order_Time = '{Order_TimedateTimePicker.Value.ToString()}', Order_Date = '{Order_DatedateTimePicker.Value.ToString()}', Payment = '{PaymenttextBox.Text}', Dispat_Time = '{Dispat_TimedateTimePicker.Value.ToString()}', Cus_ID = {Cus_IDcomboBox.SelectedValue.ToString()}, Emp_ID = {Emp_IDcomboBox.SelectedValue.ToString()}, Emp_No = {Emp_NocomboBox.SelectedValue.ToString()} WHERE Order_No = {Order_NotextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Orders WHERE Order_No = {Order_NotextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Order_NotextBox.Text = OrderdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Order_StatustextBox.Text = OrderdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Order_TimedateTimePicker.Text = OrderdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Order_DatedateTimePicker.Text = OrderdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            PaymenttextBox.Text = OrderdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            Dispat_TimedateTimePicker.Text = OrderdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            Cus_IDcomboBox.Text = OrderdataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            Emp_IDcomboBox.Text = OrderdataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            Emp_NocomboBox.Text = OrderdataGridView.Rows[rowIndex].Cells[8].Value.ToString();
        }
    }
}
