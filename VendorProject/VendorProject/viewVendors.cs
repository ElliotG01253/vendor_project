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
                var dbConnection = DBConnection.GetDBConnection();
                var dataSet = dbConnection.GetDataSet("SELECT * FROM Vendor_Information"); // Replace 'Vendors' with your actual table name
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
    }
}
