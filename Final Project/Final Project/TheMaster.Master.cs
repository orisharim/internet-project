using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public String name;
        public String userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Session["name"].ToString();
            name = Session["username"].ToString();
        }
    }
}