<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="Stack.aspx.cs" Inherits="Internet_Project.aspx.Stack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="../photos/stack.png" /><br />
     <u><b>Stack Representation:</b></u>
    <p>A stack is a linear data structure that follows the principle of Last In First Out. This means the last element inserted inside the stack is removed first.</p>
    <u><b>Stack struct:</b></u>
    <p>in order to use a stack in c we must first create a struct to represent a stack</p>
    <img src="../photos/stackStruct.png" /><br />
    <u><b>pushing and poping values</b></u>
    <p>in order to push and pop values we use a function</p>
    <img src="../photos/poppush.png" /><br />
    <u><b>Side functions</b></u>
    <p>we use these functions for initalizing the stack and in the pop and push function</p>
    <img src="../photos/sideFunctions.png" /><br />
    <u><b>Using the Stack:</b></u>
    <p>And thats it our stack is ready for use</p>
    <img src="../photos/smain.png" align="center"/><br />
</asp:Content>
