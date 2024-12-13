using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Searchcs : Form
    {
        public Searchcs()
        {
            InitializeComponent();
            DisplayDataInDataGridView();
        }
        string connectionString = "Data Source=DESKTOP-HOHAL5K;Initial Catalog=Registration db;Integrated Security=True";
        //string connectionString = ConfigurationManager.AppSettings["Chineye"];
        
        private void Searchcs_Load(object sender, EventArgs e)
        {

        }

        private void DisplayDataInDataGridView()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
                try
                {
                    string selectQuery = "SELECT * FROM Register_dt";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying data: " + ex.Message);
                }

        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();/*txtSearch.Text.Trim();*/

            if (!string.IsNullOrEmpty(searchText))
            {
                SearchData(searchText);
                
            }
            else
            {
                MessageBox.Show("Please enter a search query.");
            }
        }




        private void SearchData(string searchText)
        {
            // Create a SQL query to search for data based on your criteria
            //string query = "SELECT * FROM Register_dt WHERE Username LIKE @SearchText";
            string query = "SELECT * FROM Register_dt WHERE Username LIkE @SearchText"; //+ searchText + "%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView to display search results
                    dataGridView1.DataSource = dataTable;
                   
                }

                
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            // Get the DataTable bound to the DataGridView
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Create a SQL command to update the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM Register_dt", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    // Update the database with changes made in the DataTable
                    adapter.Update(dataTable);
                    DisplayDataInDataGridView();
                }
            }

            MessageBox.Show("Changes saved successfully.");
        }

        private void DeleteRecordFromDataSource(int studentID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string deleteQuery = "DELETE FROM Register_dt WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", studentID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted. Make sure the StudentID exists.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value in the StudentID column (assuming StudentID is a unique identifier)
                int studentID = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Confirm the deletion with a message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Delete the row from the DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Delete the row from the data source (e.g., database)
                    DeleteRecordFromDataSource(studentID); // Implement this method to delete from your data source
                    DisplayDataInDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formregister frm1 = new Formregister();
            frm1.Show();
            this.Hide();
        }
    }
}
