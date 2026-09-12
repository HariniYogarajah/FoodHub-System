using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub_System
{
    internal class GeneralClass
    {
        private static SqlConnection DB = new SqlConnection(@"Data Source=DESKTOP-IBQEIJQ\SQLEXPRESS;Initial Catalog=FoodHub;Integrated Security=True;Encrypt=False");
        public static void Save(string sql)
        {
            try
            {
                DB.Open();
                SqlCommand cmd = new SqlCommand(sql, DB);
                int insertedRows = cmd.ExecuteNonQuery();
                if (insertedRows > 0)
                {
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    MessageBox.Show("Try again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Save!");
            }
            finally
            {
                DB.Close();
            }

        }
        public static void Update(string sql)
        {
            try
            {
                if (MessageBox.Show("Do you want to update?", "Update Confirmation ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DB.Open();
                    SqlCommand cmd = new SqlCommand(sql, DB);
                    int insertedRows = cmd.ExecuteNonQuery();
                    if (insertedRows > 0)
                    {
                        MessageBox.Show("Updated Succesfully");

                    }
                    else
                    {
                        MessageBox.Show("Failed to Save!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex);
            }
            finally
            {
                DB.Close();
            }

        }

        public static void Delete(string sql)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "Delete Confirmation ", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DB.Open();
                    SqlCommand cmd = new SqlCommand(sql, DB);
                    int insertedRows = cmd.ExecuteNonQuery();
                    if (insertedRows > 0)
                    {
                        MessageBox.Show("Deleted Succesfully");

                    }
                    else
                    {
                        MessageBox.Show("Failed to Save!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred" + ex);
            }
            finally
            {
                DB.Close();
            }
        }

        public static void loadGridView(string sql, DataGridView loadTable)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, DB);
            DataTable dt = new DataTable();
            da.Fill(dt);
            loadTable.DataSource = dt;
        }

        public static void LoadComboBox(string sql, ComboBox mybox, string idColumname, string nameCloumeName)
        {
            SqlDataAdapter Da = new SqlDataAdapter(sql, DB);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            mybox.DataSource = dt;
            mybox.DisplayMember = nameCloumeName;
            mybox.ValueMember = idColumname;
        }

        public static DataTable login_data(string Sql)
        {
            SqlDataAdapter Food_Hub_sql_adapter = new SqlDataAdapter(Sql, DB);
            DataTable system_table = new DataTable();
            Food_Hub_sql_adapter.Fill(system_table);
            return system_table;
        }
    }
}
