using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab13
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Process registration logic here
                lblMessage.Text = "Registration successful!";
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Text = "Please fix the validation errors.";
                lblMessage.Visible = true;
            }
        }
    }
}