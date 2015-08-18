<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="forcerun2.aspx.cs" Inherits="WebApplication1.forcerun2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" class="vztable" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="cust_id" HeaderText="Customer ID" />
            <asp:BoundField DataField="invoice_id" HeaderText="Invoice ID" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:BoundField DataField="bill_gen_date" HeaderText="Bill_gen_date" />
            <asp:HyperLinkField DataNavigateUrlFields="cust_id,invoice_id" 
                DataNavigateUrlFormatString="http://192.168.0.16:8085/billing/BillController?V1={0}&amp;V2={1}" 
                HeaderText="View Details" Text="View Details" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Back" class="vzbtnmedium" align="center"
        Width="88px" Height="34px" onclick="Button1_Click"/>
</asp:Content>
