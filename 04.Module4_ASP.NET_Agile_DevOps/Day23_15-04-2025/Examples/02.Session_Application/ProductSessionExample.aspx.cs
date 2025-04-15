using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication31
{
    public partial class ProductSessionExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)  // First Request
            {
                InitializeSessionList();
                BindGrid();
                UpdateApplicationCountDisplay();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            InitializeSessionList();

            List<Product> productList = (List<Product>)Session["MyProducts"];

            Product p = new Product
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text)
            };

            productList.Add(p);

            // Save updated list in Session
            Session["MyProducts"] = productList;

            // Increment application-level counter
            Application.Lock();
            if (Application["ProductCount"] == null)
                Application["ProductCount"] = 0;

            int n = (int)Application["ProductCount"];
            n = n + 1;
            Application["ProductCount"] = n;
            Application.UnLock();

            BindGrid();
            UpdateApplicationCountDisplay();

            // Clear input
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
        }

        private void InitializeSessionList()
        {
            if (Session["MyProducts"] == null)
                Session["MyProducts"] = new List<Product>();
        }

        private void BindGrid()
        {
            gvProducts.DataSource = (List<Product>)Session["MyProducts"];
            gvProducts.DataBind();
        }

        private void UpdateApplicationCountDisplay()
        {
            int n = 0;
            if(Application["ProductCount"] != null )
            {
                n = (int)Application["ProductCount"];
            }

            lblProductCount.Text = "Total Products Added by All Users: " + n;
        }

      
    }

}