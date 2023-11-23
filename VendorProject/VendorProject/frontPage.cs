using System.Data;

namespace VendorProject
{
    public partial class frontPage : Form
    {
        formChanger formChanger = new formChanger();

        public frontPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void updateGridView()
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet("SELECT * FROM loginInfo");
            DataTable dt = ds.Tables[0];
            tempDataGrid.DataSource = dt;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            formChanger.changeForm("viewVendors");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formChanger.changeForm("createVendors");
        }
    }
}