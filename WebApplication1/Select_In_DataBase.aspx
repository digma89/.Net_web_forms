<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Select_In_DataBase.aspx.cs" Inherits="WebApplication1.Select_In_DataBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
<h1>*************************************************************************************</h1>
  <h1>List view</h1>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="studentid" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            Student id:
            <asp:Label ID="studentidLabel" runat="server" Text='<%# Eval("studentid") %>' />
            <br />
            Student Name:
            <asp:Label ID="studentnameLabel" runat="server" Text='<%# Eval("studentname") %>' />
            <br />
            Student Grade:
            <asp:Label ID="studentgradeLabel" runat="server" Text='<%# Eval("studentgrade") %>' />
            <br />
<br />
        </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" SelectCommand="SELECT [studentid], [studentname], [studentgrade] FROM [students]"></asp:SqlDataSource>
<asp:EntityDataSource ID="EntityDataSource1" runat="server">
</asp:EntityDataSource>

    <h1>*************************************************************************************</h1>
  <h1>Grid View</h1>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1" AllowSorting="True">
    </asp:GridView>


        <h1>*************************************************************************************</h1>
  <h1>Create table with query</h1>
    <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
</asp:Content>




