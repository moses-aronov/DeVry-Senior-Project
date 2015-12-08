using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class master : System.Web.UI.MasterPage
    {
        //CSS Class Variable for Error AlertColor
        public string AlertColor = "";

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        
        //Set User Feedback using string as input
        public void setUserFeedback (string message, string alert)
        {
            try
            {
                //Set lblUserFeedback
                lblUserFeedback.Text = message;
                AlertColor = alert;
            }
            catch (Exception error)
            {
                //Create error message if there is a problem passing arguments.
                lblUserFeedback.Text = "Error: " + error.Message;
                AlertColor = "danger";
            }
        }
        
        //Set UserFeedBack Function using dictionary object
        public void setUserFeedback(Dictionary<string, string> userFeedback)
        {
            //Pass dictionary to setUserFeedback
            setUserFeedback(userFeedback["message"], userFeedback["alert"]);
        }
    }
}