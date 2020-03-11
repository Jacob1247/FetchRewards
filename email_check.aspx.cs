using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class email_check : System.Web.UI.Page
{
	List<string> emailList = new List<string>();
	List<string> remList = new List<string>();
	List<string> igList = new List<string>();
	protected void Page_Load(object sender, EventArgs e)
	{
		//load characters to remove
		remList.Add(".");
		//load characters to ignore after
		igList.Add("+");
	}
	private void btnCheckEmail_Click(string email)
	{
        foreach (string str in remList)
        {
            email.Replace(str, "");
        }
        foreach (string str in igList)
        {
            email = email.Remove(email.IndexOf(str));
        }
        bool unique = true;
        foreach (string str in emailList)
        {
            if (str == email)
            {
                unique = false;
            }
        }
        if (unique)
        {
            emailList.Add(email);
        }
		this.lblUniqueCount = emailList.Count;
	}
}
