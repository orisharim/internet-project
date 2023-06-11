using Internet_Project.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class deleteUser : System.Web.UI.Page
    {
        //public string userToDelete = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "False")
            {
                Response.Redirect("Home.aspx");
            }
            string sqlDelete = $"DELETE FROM usersTBL WHERE username = \'{Request.QueryString["userToDelete"].ToString()}\'";
            Helper.DoQuery("users.mdf", sqlDelete);
            Response.Redirect("users.aspx");
        }
    }
}