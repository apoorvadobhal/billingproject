<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" style="margin-left: 2px" 
        class="vztable" Width="700px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="cust_id" HeaderText="Customer ID" />
            <asp:BoundField DataField="invoice_id" HeaderText="Invoice ID" />
            <asp:BoundField DataField="bill_cycle_number" HeaderText="BillCycleNumber" />
            <asp:BoundField DataField="last_billed_date" HeaderText="Last Billed Date" />
            <asp:HyperLinkField DataNavigateUrlFields="cust_id,Invoice_Id" 
                DataNavigateUrlFormatString="http://192.168.0.16:8085/billing/BillController?V1={0}&V2={1}" 
                HeaderText="View details" Text="View details" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="Button2" runat="server" style="margin-left: 299px" 
        Text="Back" class="vzbtn" Width="95px" 
            Font-Size="Medium" Height="44px" onclick="Button2_Click" />
    <br />
</asp:Content>
