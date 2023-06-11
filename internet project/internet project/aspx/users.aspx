<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="Internet_Project.aspx.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
        <form align="center" method="post">
            <label  >search by user:</label><br />
            <input type ="text" id="searchUser" name="searchUser"/>
            <input type="submit" id="submitSearchUser" name="submitSearchUser"/>
        </form><br />

    <table border="1" align="center">
 
        <%= str %>
    </table>
    
</asp:Content>
