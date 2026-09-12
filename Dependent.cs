using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    public partial class Dependent : Form
    {
        DependentClass dependentClass;
        public Dependent()
        {
            InitializeComponent();
            dependentClass = new DependentClass(Dep_NametextBox, DOBdateTimePicker, RelationshiptextBox, Emp_NocomboBox, DependentdataGridView);
            dependentClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dependentClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            dependentClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            dependentClass.delete();
            Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dependent_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Dep_NametextBox.Clear();
            RelationshiptextBox.Clear();
        }
    }
}
