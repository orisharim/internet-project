<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Internet_Project.aspx.adminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post">

        <input type="submit" id="cleanDB" name="cleanDB" value="cleanDB"/>
        <input type="submit" id="resetUsersCounter" name="resetUsersCounter" value="reset users counter"/>

    </form>
</asp:Content>
