using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication30
{
    public partial class ValidationsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                // Add database logic to store product details in database
            lblStatus.Text = "Prodduct details are added to Server";
            }
        }
    }
}