using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication31
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32( ViewState["x"] );
            count++;
            ViewState["x"] = count;
            Label1.Text = $"Counter : {count}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    Response.Redirect("WebForm3.aspx");
            Response.Redirect($"WebForm3.aspx?uid={TextBox1.Text}");
        }
    }
}