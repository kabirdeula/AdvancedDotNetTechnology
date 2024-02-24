using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12
{
    public partial class ASPDropDownDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate ListBox with initial data
                lbSelections.Items.Add(new ListItem("Apple", "1"));
                lbSelections.Items.Add(new ListItem("Banana", "2"));
                lbSelections.Items.Add(new ListItem("Orange", "3"));
            }
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add selected item from DropDownList to ListBox
            lbSelections.Items.Add(new ListItem(ddlOptions.SelectedItem.Text, ddlOptions.SelectedItem.Value));
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lbSelections.Items.Add(new ListItem("New Item", "4"));
        }
    }
}