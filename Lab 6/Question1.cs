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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO students (Id, Name, Address, Faculty) VALUES (@id, @name, @address, @faculty)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Replace these with your actual textbox names
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox3.Text);
                cmd.Parameters.AddWithValue("@faculty", textBox4.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
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
