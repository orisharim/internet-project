<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="Tree.aspx.cs" Inherits="Internet_Project.aspx.BinaryTree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="../photos/tree.png" align="center"/>
    <u ><br /><b>Binary Tree Representation:</b></u>
    <p>
        A Binary Tree is represented by a pointer to the topmost node (commonly known as the “root”) of the tree. If the tree is empty, then the value of the root is NULL. Each node of a Tree contains the following parts:<br />

        1.Data<br />
        2.Pointer to left child<br />
        3.Pointer to right child<br />

    </p>
    <u><b>Binary Tree Node:</b></u>
    <p>In order to use tree in c we must first create a struct to represent a tree node:</p>
    <img src="../photos/struct.png" align="center"/><br />
    <u><b>Creating a new tree node</b></u>
    <p>Now that we got a struct to represent a binary tree node we need to create a function in order create a new node <br />
        be aware that we must use the <b>malloc</b> function in order to create the data in the heap and not in the stack so it wont get lost when we finish the function 
    </p>
    <img src="../photos/func.png" align="center"/><br />
    <u><b>Using binary tree:</b></u>
    <p>And thats it now we have a binary tree that is ready for use. please notice that this is a <b>binary tree</b> and not a <b> binary search tree</b> remember to use the <b>free</b> function in order to delete the tree data from the heap</p>
    <img src="../photos/main.png" align="center"/><br />
</asp:Content>
