using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            dsUser dsUserLogin;

            string SecurityLevel;

            dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("FinalProject_DB.accdb"),
            Login1.UserName, Login1.Password);

            if (dsUserLogin.tblUserLogin.Count < 1)
            {
                e.Authenticated = false;
                if (clsBusinessLayer.SendEmail("benta_lem@yahoo.com",
    "benta.lem@gmail.com", "", "", "Login Incorrect",
    "The login failed for UserName: " + Login1.UserName +
    " Password: " + Login1.Password))
                {
                    Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to benta.lem@gmail.com";
                }
                return;
            }

            SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

            switch (SecurityLevel)
            {
                case "A":

                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "A";
                    break;

                case "U":

                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "U";
                    break;

                case "M":

                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "M";
                    break;

                case "S":

                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "S";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }
        }

        
    }
}