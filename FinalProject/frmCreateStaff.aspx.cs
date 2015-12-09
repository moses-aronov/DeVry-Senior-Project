using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class frmCreateStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != "S")
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                bool isValid = true;

                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtAddress"] = txtAddress.Text;
                Session["txtCity"] = txtCity.Text;
                Session["txtLocation"] = ddlLocation.SelectedValue;
                Session["txtZip"] = txtZip.Text;
                Session["txtPhone"] = txtPhone.Text;
                Session["txtEmail"] = txtEMail.Text;

                // Remove the previous yellow
                txtFirstName.BackColor = System.Drawing.Color.White;
                txtLastName.BackColor = System.Drawing.Color.White;
                txtAddress.BackColor = System.Drawing.Color.White;
                txtCity.BackColor = System.Drawing.Color.White;
                txtZip.BackColor = System.Drawing.Color.White;
                txtPhone.BackColor = System.Drawing.Color.White;
                txtEMail.BackColor = System.Drawing.Color.White;

                //Checking validation for the text boxes
                if (Request["txtFirstName"].ToString().Trim() == "")
                {
                    txtFirstName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter first name! <br />";
                    return;
                }

                if (Request["txtLastName"].ToString().Trim() == "")
                {
                    txtLastName.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter last name! <br />";
                    return;
                }
                if (Request["txtAddress"].ToString().Trim() == "")
                {
                    txtAddress.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter address! <br />";
                    return;
                }
                if (Request["txtCity"].ToString().Trim() == "")
                {
                    txtCity.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter city! <br />";
                    return;
                }
                if (Request["txtLocation"].ToString().Trim() == "")
                {
                    ddlLocation.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter state! <br />";
                    return;
                }
                if (Request["txtZip"].ToString().Trim() == "")
                {
                    txtZip.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter zip! <br />";
                    return;
                }
                if (Request["txtPhone"].ToString().Trim() == "")
                {
                    txtPhone.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter number! <br />";
                    return;
                }
                if (Request["txtEmail"].ToString().Trim() == "")
                {
                    txtEMail.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text += "Please enter email! <br />";
                    return;
                }

            }
            catch (Exception)
            {
            }
        }

        protected void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}