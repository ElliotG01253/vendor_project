using System.Data;

namespace VendorProject
{
    /*
     * todo:
     * update other forms (proper coding practice)
     * 
     * 
     *
     * 
     */
    public partial class frontPage : Form
    {
        formChanger formChanger = new formChanger();
        loginVerify loginVerify = new loginVerify();
        public frontPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Access Level: " + User.GetGroup();
            if (User.GetGroup() != "System admin")
            {
                button4.Visible = false;
                button4.Enabled = false;
            }
        }
        /// <summary>
        /// takes username and password inputs to validate
        /// </summary>
        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;
            userNameBox.Text = "";
            passwordBox.Text = "";
            loginVerify.LoginVerification(username.ToLower(), password);
            label3.Text = "Access Level: " + User.GetGroup();
            if (User.GetGroup() == "System admin")
            {
                button4.Visible = true;
                button4.Enabled = true;
            }
        }
        private void Reg_Button_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;
            userNameBox.Text = "";
            passwordBox.Text = "";
            loginVerify.RegisterUser(username.ToLower(), password);
        }
        private void View_Vendors_Button_Click(object sender, EventArgs e)
        {
            string username = User.GetGroup();
            if (User.GetGroup() == "Standard User" || User.GetGroup() == "System admin" || User.GetGroup() == "Directing Manager")
            {
                formChanger.changeForm("viewVendors");
            }
        }
        private void Edit_Vendors_Button_Click(object sender, EventArgs e)
        {
            if (User.GetGroup() == "Directing Manager")
            {
                formChanger.changeForm("createVendors");

            }
        }

        private void Change_Rights_Button_Click(object sender, EventArgs e)
        {
            if (User.GetGroup() == "System admin")
            {
                formChanger.changeForm("changeRights");

            }
        }
    }
}