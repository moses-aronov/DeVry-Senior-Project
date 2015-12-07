using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    public static bool SendEmail(string Sender, string Recipient, string bcc, string cc, 
        string Subject, string Body)
    {
        try
        {
            
            MailMessage MyMailMessage = new MailMessage();
           
            MyMailMessage.From = new MailAddress(Sender);
            
            MyMailMessage.To.Add(new MailAddress(Recipient));
            
            if (bcc != null && bcc != string.Empty)
            {
                
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }
            
            if (cc != null && cc != string.Empty)
            {
                
                MyMailMessage.CC.Add(new MailAddress(cc));
            }
            
            MyMailMessage.Subject = Subject;
            
            MyMailMessage.Body = Body;
            
            MyMailMessage.IsBodyHtml = true;
          
            MyMailMessage.Priority = MailPriority.Normal;
            
            SmtpClient MySmtpClient = new SmtpClient("localhost");
            
            MySmtpClient.Send(MyMailMessage);
           
            return true;
        }
        catch (Exception ex)
        {
          
            return false;
        }
    } 
	public clsBusinessLayer()
	{
		
	}
}