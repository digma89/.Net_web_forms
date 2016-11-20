<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insert_In_DB.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div><h1>Insert records in DB</h1></div>

    <h3>Input</h3>
    <input runat="server" id="Text1" name="FirstName" type="text" placeholder="First Name"  />

    <h3>Text Box</h3>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <h3>Checkbox list</h3>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
         <asp:ListItem Text="Alabama" Value="Alabama"></asp:ListItem>
         <asp:ListItem Text="Alaska" Value="Alaska"></asp:ListItem>
         <asp:ListItem  Value="Arizona">Arizona</asp:ListItem>
    </asp:CheckBoxList>

    <h3>Checkbox</h3>
    <asp:CheckBox runat="server" Text="One CheckBox" ID="oneCheckBox"></asp:CheckBox>
    
    <h3>DropDownList</h3>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Text="Florida" Value="Florida"></asp:ListItem>
        <asp:ListItem Text="Delaware" Value="Delaware"></asp:ListItem>
        <asp:ListItem Text="Hawaii" Value="Hawaii"></asp:ListItem>
    </asp:DropDownList>

    <h3>Radio Buttons</h3>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Text="Maryland" Value="Maryland"></asp:ListItem>
        <asp:ListItem Text="New Jersey" Value="New Jersey"></asp:ListItem>
        <asp:ListItem  Value="New York">New York</asp:ListItem>
    </asp:RadioButtonList>

    <h3>Simple Button Example</h3>      
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    
    <h1>************************************************************************************************************************</h1>

    <h3>Display input</h3>  
    <asp:label id="LabelInput" runat="server" />

    <h3>Display Textbox</h3>  
    <asp:label id="LabelTextbox" runat="server" />

    <h3>Display Checkbox Items Selected</h3>  
    <asp:label id="LabelCheckBoxItems" runat="server" />

    <h3>Display Checkbox Selected</h3>  
    <asp:label id="LabelCheckBox" runat="server"/>

    <h3>Display Dropdown Item Selected</h3>  
    <asp:label id="LabelDropDown" runat="server" />

    <h3>Display Radio Button</h3>  
    <asp:label id="LabelRadioButton" runat="server" />

    <h1>************************************************************************************************************************</h1>
    <h3>Grid view with object</h3>  
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        <h1>************************************************************************************************************************</h1>
    <asp:label id="numerOfElements" runat="server" />
    <h3>Grid view 2 with object</h3>  
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    
    
</asp:Content>
