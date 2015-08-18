<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="billrun.aspx.cs" Inherits="billingapp.billrun" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 165px"><img src="Images/Logo.jpg" style="height: 150px; width: 162px" />
       </div>
       <div style="width:249px; height: 45px; margin-left: 197px; margin-top: 0px; position: fixed; top: 112px; left: 342px;">
    <asp:Label ID="Label1" runat="server" Text="Label" class="vzh1">Bill Admin Home</asp:Label> </div>
    
    <div style="height: 231px; margin-top: 10px">
    
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" class="vzh4"
            Orientation="Horizontal" BackColor="White" ForeColor="#666666">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="False"/>
       
    <asp:GridView ID="GridView1" runat="server" class="vztable" 
        HorizontalAlign="Center" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="instance_create_date" 
                DataNavigateUrlFormatString="WebForm1.aspx?V={0}" DataTextField="instance_create_date" 
                HeaderText="Bill_Cycle_No" />
            <asp:BoundField DataField="cust_id" HeaderText="No_Of_Customers" />
        </Columns>
    </asp:GridView>

    
    </div>
    </form>
</body>
</html>
