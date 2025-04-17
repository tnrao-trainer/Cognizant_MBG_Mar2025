using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

 

namespace WebApplication34
{
    public partial class Default : Page
    {
        EmployeeBLL  bll = new EmployeeBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        private void BindGrid()
        {
            GridView1.DataSource = bll.GetEmployees();
            GridView1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bll.AddEmployee(
                    int.Parse(txtEmpno.Text),
                    txtEname.Text,
                    txtJob.Text,
                    decimal.Parse(txtSal.Text),
                    int.Parse(txtDeptno.Text)
                );
                lblMessage.Text = "Employee Added Successfully!";
                BindGrid();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int empno = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string ename = ((TextBox)row.Cells[1].Controls[0]).Text;
            string job = ((TextBox)row.Cells[2].Controls[0]).Text;
            decimal sal = Convert.ToDecimal(((TextBox)row.Cells[3].Controls[0]).Text);
            int deptno = Convert.ToInt32(((TextBox)row.Cells[4].Controls[0]).Text);

            bll.ModifyEmployee(empno, ename, job, sal, deptno);
            GridView1.EditIndex = -1;
            BindGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int empno = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            bll.RemoveEmployee(empno);
            BindGrid();
        }
    }

}