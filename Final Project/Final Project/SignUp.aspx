<%@ Page Title="" Language="C#" MasterPageFile="~/TheMaster.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Final_Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form>
  <label for="username">Username:</label>
  <input type="text" id="username" name="username"><br><br>
  
  <label for="password">Password:</label>
  <input type="password" id="password" name="password"><br><br>
  
  <label for="confirmpassword">Confirm Password:</label>
  <input type="password" id="confirmpassword" name="confirmpassword"><br><br>
  
  <label for="name">Name:</label>
  <input type="text" id="name" name="name"><br><br>
  
  <label for="familyname">Family Name:</label>
  <input type="text" id="familyname" name="familyname"><br><br>
  
  <label for="dob">Year of Birth:</label>
  <input type="number" id="dob" name="dob"><br><br>
  
  <label for="city">City:</label>
  <input type="text" id="city" name="city"><br><br>
  
  <label for="phonenumber">Phone Number:</label>
  <select name="prefix" id="prefix">
    <option value="1">972</option>
    <option value="2">123</option>
    <option value="3">345</option>
    <option value="4">657</option>
  </select>
  <input type="text" id="phonenumber" name="phonenumber"><br><br>
  
  <label for="email">Email:</label>
  <input type="email" id="email" name="email"><br><br>
  
  <input type="radio" id="male" name="gender"/>
  <label for="male">male</label>
  <input type="radio" id="female" name="gender"/>
  <label for="male">female</label>
  <input type="radio" id="other" name="gender"/>
  <label for="male">other</label><br><br>
  
  <input type="submit" value="Submit">
</form> 




</asp:Content>
