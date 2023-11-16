using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    public class formChanger
    {
        public void changeForm(string formName)
        {
            //add multiple if statements (view vendors front page create vendors ect.)
            Form currentForm = Form.ActiveForm;
            currentForm.Hide();
            viewVendors f2 = new viewVendors();
            f2.ShowDialog();
            currentForm.Close();
        }
    }
}
