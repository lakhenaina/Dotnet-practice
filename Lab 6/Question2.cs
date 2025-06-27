// Form.cs

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace studentFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM students";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("ID: " + reader["Id"] + "\nName: " + reader["Name"] +
                                    "\nAddress: " + reader["Address"] + "\nFaculty: " + reader["Faculty"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
