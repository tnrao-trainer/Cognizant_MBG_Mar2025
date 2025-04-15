using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication31
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uidStr = Request.QueryString["uid"];

            if (!string.IsNullOrEmpty(uidStr))
            {
                Label1.Text = $"Welcome, {uidStr}";
            }
            else
            {
                Label1.Text = $"Welcome, Guest User";
            }

        }
    }
}