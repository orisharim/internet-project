using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class Stack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "guest")
            {
                Response.Redirect("home.aspx");
            }
        }
    }
}