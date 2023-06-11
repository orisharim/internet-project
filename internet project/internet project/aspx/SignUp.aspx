<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Internet_Project.aspx.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" type="text/css" href="../css/SignUpCss.css?version=1" />
<script src="../js/SignUpValidation.js"></script>    

  <form method="post">   

  <label for="username">Username:</label>
  <br />
  <input type="text" id="username" name="username"><br><br>

  <label for="password">Password:</label>
  <br />
  <input type="password" id="password" name="password"><br><br>

  <label for="confirmpassword">Confirm Password:</label>
  <br />
  <input type="password" id="confirmpassword" name="confirmpassword"><br><br>

  <label for="name">Name:</label>
  <br />
  <input type="text" id="name" name="name"><br><br>

  <label for="familyname">Family Name:</label>
  <br />
  <input type="text" id="familyname" name="familyname"><br><br>

  <label for="dob">Year of Birth:</label>
  <br />
  <input type="number" id="dob" name="dob"><br><br>

  <label for="city">City:</label>
  <br />
  <input type="text" id="city" name="city"><br><br>

  <label for="phonenumber">Phone Number:</label>
  <br />
  <select name="prefix" id="prefix">
    <option value="972">972</option>
    <option value="123">123</option>
    <option value="345">345</option>
    <option value="657">657</option>
  </select>
  <input style="width:10.6%;" type="text" id="phonenumber" name="phonenumber"><br><br>

  <label for="email">Email:</label>
  <br />
  <input type="text" id="email" name="email"><br><br>

  <input type="radio" id="male" name="gender" value="male"/>
  <label for="male">male</label>
  <input type="radio" id="female" name="gender" value="female"/>
  <label for="male">female</label>
  <input type="radio" id="other" name="gender" value="other"/>
  <label for="male">other</label><br><br>

  <input type="submit" name="submit" id="submit" value="submit" onclick="return validateForm();"/>

  <input type="submit" name="reset" id="reset" value="reset"/>
  
      
   

    <h3><%= msg %></h3>
</form>
</asp:Content>
