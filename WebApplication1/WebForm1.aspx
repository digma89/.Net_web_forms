<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div><h1> text 
        
        
        </h1> </div>
    <asp:Label ID="label1" Text="text" runat="server" />


   
    <div>
      <h3>Simple Button Example</h3>

      <asp:Button id="Button2" Text="Click here for greeting..."  OnClick="GreetingBtn_Click"   runat="server"/>
 
       <input runat="server" name="first" type="text" placeholder="First Name"  />
      <br />
      <br />
      <asp:Label ID="GreetingLabel" runat="server" 
                 Visible="false" Text="Hello World!" />
    </div>
    
</asp:Content>
