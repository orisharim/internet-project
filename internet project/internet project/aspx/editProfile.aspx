<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="editProfile.aspx.cs" Inherits="Internet_Project.aspx.editProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../css/SignUpCss.css" />
    <script src="../js/EditProfile.js"></script>
  <form method="post">   

  <label for="password">New Password:</label>
  <br />
  <input type="password" id="password" name="password">
  <input type="submit" id="passwordSubmit" name ="passwordSubmit" onclick="return validatePassword();"/><br><br>

  <label for="name">New Name:</label>
  <br />
  <input type="text" id="name" name="name">
  <input type="submit" id="nameSubmit" name ="nameSubmit" onclick="return validateName();"/><br><br>

  <label for="familyname">New Family Name:</label>
  <br />
  <input type="text" id="familyname" name="familyname">
  <input type="submit" id="familyNameSubmit" name ="familyNameSubmit" onclick="return validateFamilyName();"/><br><br>  

  <label for="dob">New Year of Birth:</label>
  <br />
  <input type="number" id="dob" name="dob">
  <input type="submit" id="dobSubmit" name ="dobSubmit" /><br><br>

  <label for="city">New City:</label>
  <br />
  <input type="text" id="city" name="city">
  <input type="submit" id="citySubmit" name ="citySubmit" /><br><br>

  <label for="phonenumber">New Phone Number:</label>
  <br />
  <select name="prefix" id="prefix">
    <option value="972">972</option>
    <option value="123">123</option>
    <option value="345">345</option>
    <option value="657">657</option>
  </select>
  <input type="text" id="phonenumber" name="phonenumber">
  <input type="submit" id="phoneSubmit" name ="phoneSubmit" onclick="return validatePhoneNumber();"/><br><br> 

  <label for="email">Email:</label>
  <br />
  <input type="text" id="email" name="email">
  <input type="submit" id="emailSubmit" name ="emailSubmit" onclick="return validateEmail();"/><br><br> 

    
  <input type="radio" id="male" name="gender" value="male"/>
  <label for="male">male</label>
  <input type="radio" id="female" name="gender" value="female"/>
  <label for="male">female</label>
  <input type="radio" id="other" name="gender" value="other"/>
  <label for="male">other</label>
  <input type="submit" id="genderSubmit" name ="genderSubmit" /><br><br> 


</form>

</asp:Content>
