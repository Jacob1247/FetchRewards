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
	protected void btnCheckEmail_Click(object sender EventArgs e)
	{
		//checking if there is a list, if so it splits based on the comma. otherwise just checks the entire string
		if (this.txtEmail.Text.Contains(",")
		{
			string[] newEmails = this.txtEmail.Text.Split(",");
			foreach (string email in newEmails)
			{
				checkEmail(email);
			}
		}
		else
		{
			checkEmail(this.txtEmail.Text);
		}
	}
	private void checkEmail(string email)
	{
		//remove each character in the list
		foreach (string str in remList)
		{
			email.Replace(str, "");
		}
		//remove any text after one of the ignore characters
		foreach (string str in igList)
		{
			email = email.Remove(email.IndexOf(str));
		}
		bool unique = true;
		//checking if the current list of emails contains the new email
		foreach (string str in emailList)
		{
			if (str == email)
			{
				unique = false;
			}
		}
		//if the email isn't in the list, add it to the list
		if (unique)
		{
			emailList.Add(email);
		}
		//display the current count of unique emails
		this.lblUniqueCount = emailList.Count;
	}
}
