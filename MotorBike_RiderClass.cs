using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class MotorBike_RiderClass
    {
        TextBox MBR_IDtextBox, Start_MeterReadingtextBox, End_MeterReadingtextBox;
        DateTimePicker DatedateTimePicker;
        ComboBox Emp_NocomboBox, Register_NocomboBox;
        DataGridView Motor_Bike_RiderdataGridView;

        public MotorBike_RiderClass(TextBox MBR_IDBox, DateTimePicker DateBox, TextBox Start_MeterReadingBox, TextBox End_MeterReadingBox, ComboBox Emp_NoBox, ComboBox Register_No, DataGridView Motor_Bike_RiderGrid)
        {
            MBR_IDtextBox = MBR_IDBox;
            DatedateTimePicker = DateBox;
            Start_MeterReadingtextBox = Start_MeterReadingBox;
            End_MeterReadingtextBox = End_MeterReadingBox;
            Emp_NocomboBox = Emp_NoBox;
            Register_NocomboBox = Register_No;
            Motor_Bike_RiderdataGridView = Motor_Bike_RiderGrid;

            Motor_Bike_RiderdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Motor_Bike_Rider";
            GeneralClass.loadGridView(sql, Motor_Bike_RiderdataGridView);

            string rider = "SELECT * from Rider;";
            GeneralClass.LoadComboBox(rider, Emp_NocomboBox, "Emp_No", "First_Name");

            string motorbike = "SELECT * from Motor_Bike;";
            GeneralClass.LoadComboBox(motorbike, Register_NocomboBox, "Register_No", "Brand");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Motor_Bike_Rider (Date, Start_MeterReading, End_MeterReading, Emp_No, Register_No) VALUES ('{DatedateTimePicker.Value.ToString()}', {Start_MeterReadingtextBox.Text}, {End_MeterReadingtextBox.Text}, {Emp_NocomboBox.SelectedValue.ToString()}, {Register_NocomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Motor_Bike_Rider SET Date = '{DatedateTimePicker.Value.ToString()}', Start_MeterReading = {Start_MeterReadingtextBox.Text}, End_MeterReading = {End_MeterReadingtextBox.Text}, Emp_No = {Emp_NocomboBox.SelectedValue.ToString()}, Register_No = {Register_NocomboBox.SelectedValue.ToString()} WHERE MBR_ID = {MBR_IDtextBox.Text};";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Motor_Bike_Rider WHERE MBR_ID = {MBR_IDtextBox.Text};";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            MBR_IDtextBox.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            DatedateTimePicker.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Start_MeterReadingtextBox.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            End_MeterReadingtextBox.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Emp_NocomboBox.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            Register_NocomboBox.Text = Motor_Bike_RiderdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
        }
    }
}
