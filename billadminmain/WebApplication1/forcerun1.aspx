<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="forcerun1.aspx.cs" Inherits="WebApplication1.forcerun1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Date" class="vzh3"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" 
        style="margin-left: 56px; margin-top: 18px;" class="vztext"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" style="margin-left: 125px" class="vzbtn1small"
        Text="ForceRun" onclick="Button1_Click" 
             />
    <asp:Button ID="Button2" runat="server" style="margin-left: 36px" class="vzbtn1small"
        Text="Finalize" onclick="Button2_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" class="vztable">
    </asp:GridView>
    <br />
    <br />
</asp:Content>
