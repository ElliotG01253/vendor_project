using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorProject
{
    public partial class changeRightsForm : Form
    {
        public changeRightsForm()
        {
            InitializeComponent();
        }
        private void changeRightsForm_Load(object sender, EventArgs e)
        {
            updateGridView();
        }
        private void updateGridView()
        {
            DataSet dsUsers = DBConnection.GetDBConnection().GetDataSet("A", "SELECT UserName, name from Users u, Groups g, Groups_Users gu Where g.Id = gu.Groups_Id and u.Id = gu.Users_Id");
            DataTable tableUsers = dsUsers.Tables[0];
            dgvUsers.DataSource = tableUsers;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontPage f1 = new frontPage();
            f1.ShowDialog();
            this.Close();
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string search = textBox1.Text;
                DataSet dsUsers = DBConnection.GetDBConnection().GetDataSet("A", $"SELECT UserName, name from Users u, Groups g, Groups_Users gu Where g.Id = gu.Groups_Id and u.Id = gu.Users_Id and (userName = '{search}' or name = '{search}')");
                DataTable tableUsers = dsUsers.Tables[0];
                dgvUsers.DataSource = tableUsers;
            }
            else
            {
                updateGridView();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search")
            {
                textBox1.Text = "";
            }
            updateGridView();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Username")
            {
                textBox2.Text = "";
            }
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string group = Groups.Text;
            string username = textBox2.Text;

            DataSet ds = DBConnection.GetDBConnection().GetDataSet("A", $"select Id From Groups where name = '{group}'");
            int group_Id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
            ds = DBConnection.GetDBConnection().GetDataSet("A", $"select Id From Users where UserName = '{username}'");
            DBConnection.GetDBConnection().RightsChanger(int.Parse(ds.Tables[0].Rows[0]["id"].ToString()), group_Id);
            updateGridView();
        }
    }
}
