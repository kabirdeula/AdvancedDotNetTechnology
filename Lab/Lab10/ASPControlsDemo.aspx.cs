using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab10
{
    public partial class ASPControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate GridView with dummy data
                gvData.DataSource = new[] { new { ColumnName = "Data 1" }, new { ColumnName = "Data 2" } };
                gvData.DataBind();
            }


        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Display submitted name in the label
            lblMessage.Text = "Hello, " + txtName.Text;
        }
    }
}