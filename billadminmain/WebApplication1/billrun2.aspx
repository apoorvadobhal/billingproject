<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="billrun2.aspx.cs" Inherits="WebApplication1.billrun2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" class="vztable">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" style="margin-left: 257px" Text="Finalize" 
        class="vzbtn1medium" onclick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" style="margin-left: 60px" class="vzbtnmedium"
        Text="Back" onclick="Button2_Click" />
    <div>
    
    </div>
    </form>
</body>
</html>
