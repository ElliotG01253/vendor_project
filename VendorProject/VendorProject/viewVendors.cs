using System;
using System.Data;
using System.Windows.Forms;

namespace VendorProject
{
    public partial class viewVendors : Form
    {
        public viewVendors()
        {
            InitializeComponent();
            LoadVendorData();
        }

        private void LoadVendorData()
        {
            try
            {
                DataSet dataSet = DBConnection.GetDBConnection().GetDataSet("SELECT * FROM Vendor_Information"); // Adjust your table name as needed
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontPage f1 = new frontPage();
            f1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement this method if needed
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement this method if needed
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchTextBox.Text.Trim();

            // Adjust these column names according to your database schema
            string nameColumn = "Company_Name"; // Replace with your actual column name for 'Name'
            string idColumn = "ID"; // Replace with your actual column name for 'ID'

            // Building a SQL query - Use parameterized queries to prevent SQL injection
            string query = $"SELECT * FROM Vendor_Information WHERE {nameColumn} LIKE '%{searchValue}%' OR {idColumn} LIKE '%{searchValue}%'";

            try
            {
                var dbConnection = DBConnection.GetDBConnection();
                var dataSet = dbConnection.GetDataSet(query);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }
    }
}
