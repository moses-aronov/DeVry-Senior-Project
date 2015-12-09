using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsDataLayer.SaveUserActivity(Server.MapPath("FinalProject_DB.accdb"), "frmPersonnel");
            if (Session["SecurityLevel"] == "A")
            {
                imbtnStaff.Visible = false;
                LinkButtonStaff.Visible = false;


            }

            if (Session["SecurityLevel"] == "S")
            {
                LinkButtonManage.Visible = false;
                imgbtnManage.Visible = false;

            }



        }



        protected void LinkButtonManage_Click(object sender, EventArgs e)
        {

        }
    }
}