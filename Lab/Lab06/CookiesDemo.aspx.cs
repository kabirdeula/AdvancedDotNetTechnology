using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab06
{
    public partial class CookiesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["anime"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            if (naruto.Checked)
            {
                Response.Cookies["anime"]["naruto"] = "naruto";
            }
            if(one_piece.Checked)
            {
                Response.Cookies["anime"]["one_piece"] = "one_piece";
            }
            if (bleach.Checked)
            {
                Response.Cookies["anime"]["bleach"] = "bleach";
            }
            if (dragonball.Checked)
            {
                Response.Cookies["anime"]["dragonball"] = "dragonball";
            }

            if (Request.Cookies["anime"].Values.ToString() != null)
            {
                if (Request.Cookies["anime"]["naruto"] != null)
                {
                    Label2.Text += Request.Cookies["anime"]["naruto"] + " ";
                }
                if(Request.Cookies["anime"]["one_piece"] != null)
                {
                    Label2.Text += Request.Cookies["anime"]["one_piece"] + " ";
                }
                if (Request.Cookies["anime"]["bleach"] != null)
                {
                    Label2.Text += Request.Cookies["anime"]["bleach"] + " ";
                }
                if (Request.Cookies["anime"]["dragonball"] != null)
                {
                    Label2.Text += Request.Cookies["anime"]["dragonball"] + " ";
                }
            }
            else
            {
                Label2.Text = "Please select your choice";
            }
            Response.Cookies["anime"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}