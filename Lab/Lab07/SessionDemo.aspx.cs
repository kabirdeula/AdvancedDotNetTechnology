using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab07
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if(password.Text == "password123")
            {
                Session["email"] = email.Text;
            }
            if (Session["email"] != null)
            {
                Label1.Text = "This email is stored to the session.";
                Label2.Text = Session["email"].ToString();
                
            }
        }
    }
}