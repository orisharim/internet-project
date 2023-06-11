using internet_project.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace internet_project
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (Session["admin"].ToString() != "True")
            {
                Response.Redirect("Home.aspx");
            }
            //remove all users from DB that are not the admin
            if (Request.Form["cleanDB"] != null)
            {
                Console.WriteLine("hello");
                Helper.DoQuery("users.mdf", "DELETE FROM usersTBL WHERE admin = 'False'");
                
            }
            //reset users counter
            if (Request.Form["resetUsersCounter"] != null)
            {
                Application["usersCounter"] = 0;
            }
        }
    }
}