using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class frmManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != "A")
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (clsDataLayer.SaveUser(Server.MapPath("FinalProject_DB.accdb"), txtUserName.Text, txtPassword.Text, ddlSecurityLevel.SelectedValue))
            {
                lblDisplay.Text = " The user was successfully added!";
                grdVUsers.DataBind();
            }
            else
            {
                lblDisplay.Text = "The user was not added!";
            }
        }

        protected void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}