<%@ Page Language="C#" AutoEventWireup="true" CodeFile="email_check.aspx.cs" Inherits="email_check" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Athletics Form</title>
    <link rel="Stylesheet" href="~/StyleSheet.css" />
    <script type="text/javascript" language="JavaScript">
    setTimeout("window.open('../timeout.htm','_timeout','height=300,width=300,statusbar=no,toolbar=no,navbar=no')",2100000);
    setTimeout("window.location.href='<%Response.Write(Utilities.SetParentLogoutUrl());%>'", 2400000);
    </script>
     <script type="text/javascript">
function SetFocus(thisobj, newobj)
{
    if (document.getElementById(thisobj).value.length == 3)
        document.getElementById(newobj).focus();
}
</script>
</head>
<body>
<form id="form1" runat="server">
	<div>
		<span>Enter an email below:<br /></span>
		<asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="btnCheckEmail" OnClick="btnCheckEmail_Click" runat="server" Text="Check Email" /><br />
		<asp:Label runat="server" ID="lblUniqueCount"></asp:Label>
	</div>
</form>
</body>
</html>
