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
    public partial class Theme : Form
    {
        ThemeClass themeClass;
        public Theme()
        {
            InitializeComponent();
            themeClass = new ThemeClass(Theme_IDtextBox, ColourtextBox, ThemedataGridView);
            themeClass.load();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            themeClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            themeClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            themeClass.delete();
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

        private void Theme_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            Theme_IDtextBox.Clear();
            ColourtextBox.Clear();
        }
    }
}
