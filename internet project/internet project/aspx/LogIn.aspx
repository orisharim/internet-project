<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Internet_Project.aspx.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <script src="../js/LogInValidation.js"></script>
   <link rel="stylesheet" type="text/css" href="../css/SignUpCss.css?version=1" media="screen"/>
    <form method="post">
    <label for="username">Username:</label>
   <br />
  <input type="text" id="username" name="username"><br><br>

  <label for="password">Password:</label>
    <br />
  <input type="password" id="password" name="password"><br><br>
  
  <input type="submit" name="submit" id="submit" value="submit" onclick="return validateForm()"/>
  <input type="submit" name="reset" value="reset" id="reset" />
  <h3><%= msg %></h3>
  
   </form>
</asp:Content>
