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
            frontPage frontPage = new frontPage();
            viewVendors viewVendors = new viewVendors();
            createVendors createVendors = new createVendors();

            Form currentForm = Form.ActiveForm; //set current form variable to the active form
            currentForm.Hide();
            if(formName == "frontPage")//if statements show the given form
            {
                frontPage.ShowDialog();
            }
            if (formName == "viewVendors")
            {
                viewVendors.ShowDialog();
            }
            if (formName == "createVendors")
            {
                createVendors.showDialog();
            }
            currentForm.Close();//closes the previous form

        }
        
    }
}
