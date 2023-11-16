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
    public partial class viewVendors : Form
    {
        public viewVendors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontPage f1 = new frontPage();
            f1.ShowDialog();
            this.Close();
        }
    }
}
