namespace VendorProject
{
    public partial class frontPage : Form
    {
        public frontPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
           /* this.Hide();
            viewVendors f2 = new viewVendors();
            f2.ShowDialog();
            this.Close();
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            createVendors f3 = new createVendors();
            f3.ShowDialog();
            this.Close();
        }
    }
}