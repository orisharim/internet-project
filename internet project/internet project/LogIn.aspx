<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="internet_project.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form method="post">
    <label for="username">Username:</label>
  <input type="text" id="username" name="username"><br><br>

  <label for="password">Password:</label>
  <input type="password" id="password" name="password"><br><br>
  
  <input type="submit" name="submit" id="submit" value="submit">
  <input type="submit" name="reset" value="reset" id="reset" />
  <h3><%= msg %></h3>
  
   </form>
</asp:Content>
