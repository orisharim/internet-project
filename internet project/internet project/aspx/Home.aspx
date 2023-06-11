<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Internet_Project.aspx.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
body {
  background-color: #f1f1f1;
  font-family: Arial, sans-serif;
}

h1 {
  text-align: center;
  color: #333;
  margin-top: 30px;
}

.gallery {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
}
    
.duck {
  width: 200px;
  height: 200px;
  margin: 10px;
  border-radius: 50%;
  background-color: #f8c291;
  display: flex;
  align-items: center;
  justify-content: center;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  overflow: hidden; 
  transition: transform 0.3s;

}

.duck img {
  max-width: 100%; 
  max-height: 100%; 
  border-radius: 50%;
}

    
.duck:hover {
    transform: scale(1.1);
}
    
   
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>hello <%=Session["username"] %></h1>

     <h1> in order to access the rest of the website's content<br /> you must log in</h1> 
  <h1>Our Duck Gallery:</h1>
   <br />
    
  <div class="gallery">
    <div class="duck">
      <img src="../photos/duck1.jpg" alt="Rubber Duck 1">
    </div>
    <div class="duck">
      <img src="../photos/duck2.jpg" alt="Rubber Duck 2">
    </div>
    <div class="duck">
      <img src="../photos/duck3.jpg" alt="Rubber Duck 3">
    </div>
    <div class="duck">
      <img src="../photos/duck4.jpg" alt="Rubber Duck 4">
    </div>
    <div class="duck">
      <img src="../photos/duck5.jpg" alt="Rubber Duck 5">
    </div>
    <div class="duck">
      <img src="../photos/duck6.jpg" alt="Rubber Duck 6">
    </div>
  </div>

</asp:Content>
