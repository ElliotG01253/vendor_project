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
            Form currentForm = Form.ActiveForm; //set current form variable to the active form
            currentForm.Hide();
            if (formName == "frontPage")//if statements show the given form
            {
                frontPage frontPage = new frontPage();
                frontPage.ShowDialog();
            }
            if (formName == "viewVendors")
            {
                viewVendors viewVendors = new viewVendors();
                viewVendors.ShowDialog();
            }
            if (formName == "createVendors")
            {
                createVendors createVendors = new createVendors();
                createVendors.ShowDialog();
            }
            currentForm.Close();//closes the previous form
        }
    }
}
