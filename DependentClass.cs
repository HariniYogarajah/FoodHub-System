using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class DependentClass
    {
        TextBox Dep_NametextBox, RelationshiptextBox;
        DateTimePicker DOBdateTimePicker;
        ComboBox Emp_NocomboBox;
        DataGridView DependentdataGridView;

        public DependentClass(TextBox Dep_NameBox, DateTimePicker DOBBox, TextBox RelationshipBox, ComboBox Emp_NoBox, DataGridView DependentGrid)
        {
            Dep_NametextBox = Dep_NameBox;
            DOBdateTimePicker = DOBBox;
            RelationshiptextBox = RelationshipBox;
            Emp_NocomboBox = Emp_NoBox;
            DependentdataGridView = DependentGrid;

            DependentdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Dependent";
            GeneralClass.loadGridView(sql, DependentdataGridView);

            string rider = "SELECT * from Rider;";
            GeneralClass.LoadComboBox(rider, Emp_NocomboBox, "Emp_No", "First_Name");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Dependent (Dep_Name, DOB, Relationship, Emp_No) VALUES ('{Dep_NametextBox.Text}', '{DOBdateTimePicker.Value.ToString()}', '{RelationshiptextBox.Text}', {Emp_NocomboBox.SelectedValue.ToString()});";
            GeneralClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Dependent set DOB = '{DOBdateTimePicker.Value.ToString()}', Relationship = '{RelationshiptextBox.Text}', Emp_No = {Emp_NocomboBox.SelectedValue.ToString()} WHERE Dep_Name = '{Dep_NametextBox.Text}';";
            GeneralClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE from Dependent  WHERE Dep_Name = '{Dep_NametextBox.Text}';";
            GeneralClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Dep_NametextBox.Text = DependentdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            DOBdateTimePicker.Text = DependentdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            RelationshiptextBox.Text = DependentdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Emp_NocomboBox.Text = DependentdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
