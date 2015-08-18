<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login11.aspx.cs" Inherits="WebApplication1.login11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    
    <title></title>
   <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="Styles/progress.css" rel="stylesheet" type="text/css" />
    <link href="Styles/select.css" rel="stylesheet" type="text/css" />
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
    <link href="Styles/theme.css" rel="stylesheet" type="text/css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <script type = "text/javascript" >
        history.pushState(null, null, 'login11.aspx');
        window.addEventListener('popstate', function (event) {
            history.pushState(null, null, 'login11.aspx');
        });
  </script>
</head>
<body style= "background-color:#ecedee;">
<div  style="   
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    width: 50%;
    height: 50%;
    margin: auto;">
<div class="container-fluid"> 
	<div class="well well-lg">
	<div class="vzlogoContainer" >  <img src='Images/logo.png' alt=''/></div>
  <h2><center><strong>Bill Admin Login</center></strong></h2>
    <form id="form1" runat="server">
    
       <div class="form-group">
       <asp:Label class="vzh4" ID="Label1" runat="server" Text="User Name"></asp:Label>
      <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Dont Leave Blank"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
       <asp:Label class="vzh4" ID="Label2" runat="server" Text="Password"></asp:Label>
     <asp:TextBox class="form-control" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Dont Leave Blank"></asp:RequiredFieldValidator>
    </div>
    <div class="checkbox">
      <input type="checkbox" id="cb1" name="cb" value="">
	<label for="cb1">Remember me</label>
	<a href="" class="vzlink" style="float:right">Forgot Password</a>
    </div>
    <asp:Button class="vzbtnmedium" ID="Button1" runat="server" Text="Ok" onclick="Button1_Click" />
	  <asp:Button class="vzbtn1medium" ID="Button2" runat="server" Text="Cancel" 
                    onclick="Button2_Click" />
	
	    <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
	</form>
</div>
</div>
</div>

</body>
</html>
