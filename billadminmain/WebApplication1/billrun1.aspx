<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="billrun1.aspx.cs" Inherits="WebApplication1.billrun1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" class="vztable" 
     
        HorizontalAlign="Center" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="BILL_CYCLE_NUMBER" 
                DataNavigateUrlFormatString="billrun2.aspx?V={0}" DataTextField="BILL_CYCLE_NUMBER" 
                HeaderText="BILL_CYCLE_NUMBER" />
            <asp:BoundField DataField="NOOFCUSTOMERS" HeaderText="NO_OF_CUSTOMERS" />
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
