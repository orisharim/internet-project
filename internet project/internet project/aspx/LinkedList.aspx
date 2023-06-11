<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="LinkedList.aspx.cs" Inherits="Internet_Project.aspx.LinkedList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="../photos/LinkedList.png" /><br />
    <u><b>Linked List Representation:</b></u>
    <p> a linked list consists of nodes where each node contains a data field and a pointer to the next node in the list.</p>
    <u><b>Linked List struct:</b></u>
    <p>in order to use a linked list in c we must first create a struct to represent a linked list</p>
    <img src="../photos/lStruct.png" /><br />
    <u><b>Insert values</b></u>
    <p>in order to add values to the list we use 2 functions for inserting at the end and at the start please notice that use the function <b>malloc</b> in order to save the data in the heap and not the stack so it wont disapear when it gets out of the function</p>
    <img src="../photos/insert.png" /><br />
    <u><b>Displaying the List</b></u>
    <p>in order to display the content the content of the list we use a function</p>
    <img src="../photos/displayList.png" /><br />
    <u><b>Using the Linked List:</b></u>
    <p>And thats it our list is ready for use</p>
    <img src="../photos/lmain.png" align="center"/><br />
</asp:Content>
