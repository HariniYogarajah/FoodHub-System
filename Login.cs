using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
           
           
        }

        public void lLogin()
        {
            string Username = User_NametextBox.Text;
            string Upassword = PasswordtextBox.Text;

            if (Username != null && Upassword != null)
            {
                string sql = $"select User_Name , Password from Staff Where User_Name = '{Username}' and Password = '{Upassword}';";
                DataTable dt = GeneralClass.login_data(sql);
                if (dt.Rows.Count > 0)
                {
                    string Dusername = dt.Rows[0]["User_Name"].ToString();
                    string Dpassword = dt.Rows[0]["Password"].ToString();

                    if (Username == Dusername && Upassword == Dpassword)
                    {
                        MessageBox.Show("Login Succsess");
                        this.Hide();
                        StaffRegister Dashboard = new StaffRegister();
                        Dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invelide Username And Password !!");
                    }

                }
                else
                {
                    MessageBox.Show("Invelide Username And Password");
                }


            }
            else
            {
                MessageBox.Show("Fill the Every Box !!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            lLogin();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void User_NametextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            User_NametextBox.Clear();
            PasswordtextBox.Clear();
           
        }
    }
}
