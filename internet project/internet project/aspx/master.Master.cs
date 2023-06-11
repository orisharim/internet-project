using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class master : System.Web.UI.MasterPage
    {
        public string name;
        public string adminPages;
        public string userPages;
        public string usersCounter;
        public string guestPages;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Session["username"].ToString();
            usersCounter = Application["usersCounter"].ToString();
            if(name != "guest")
            {
                userPages = " <a href=\"Tree.aspx\">Tree</a> \r\n <a href=\"LinkedList.aspx\">Linked List</a> \r\n <a href=\"Stack.aspx\">Stack</a> \r\n <a href=\"editProfile.aspx\">edit profile</a>\r\n <a style=\"float: right;\" href=\"LogOut.aspx\">Log Out</a>\n ";
                guestPages = "";
            }
            else
            {
                guestPages = "<a href=\"SignUp.aspx\">Sign Up</a>\r\n <a href=\"LogIn.aspx\">Log In</a>";
                userPages = "";
            }
            
            if (Session["admin"].ToString() == "True" || Session["admin"].ToString() == "true")
            {
                adminPages = "<a href=\"adminPage.aspx\">adminPage</a>\n<a href=\"users.aspx\">users</a>"; //the \ is used to cancel the "" similar to what it does in bash(linux)
            }
            else
            {
                adminPages = "";
            }
        }
    }
}