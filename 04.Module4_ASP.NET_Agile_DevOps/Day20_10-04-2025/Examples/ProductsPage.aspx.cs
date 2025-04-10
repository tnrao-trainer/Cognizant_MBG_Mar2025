using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication30
{
    public partial class ProductsPage : System.Web.UI.Page
    {
       static  List<Product> productList = new List<Product>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
           Product obj = new Product();

           obj.ProductId   = int.Parse( txtProductId.Text );
           obj.ProductName = txtProductName.Text;
           obj.UnitPrice =   decimal.Parse( txtUnitPrice.Text);
            obj.Quantity =  Convert.ToInt32(txtQuantity.Text);  

            productList.Add(obj);
            BindGrid();

            lblStatus.Text = $"No. of products in List : {productList.Count}";
        }

        private void BindGrid()
        {
            gvProducts.DataSource = productList;
            gvProducts.DataBind();
        }
    }
}