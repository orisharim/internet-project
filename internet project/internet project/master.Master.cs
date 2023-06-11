using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace internet_project
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string name;
        public string adminPage;
        public string usersCounter;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Session["username"].ToString();
            usersCounter = Application["usersCounter"].ToString();
            if (Session["admin"].ToString() == "True" || Session["admin"].ToString() == "true")
            {
                adminPage = "<a href=\"adminPage.aspx\">adminPage</a>"; //the \ is used to cancel the "" similar to what it does in bash(linux)
            }
            else
            {
                adminPage = "";
            }
        }
    }
}