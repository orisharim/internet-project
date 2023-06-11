using Internet_Project.App_Start;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class LogIn : System.Web.UI.Page
    {
        public string msg;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() != "guest")
            {
                Response.Redirect("Home.aspx");
            }
            if (Request.Form["reset"] != null)
            {
                msg = "";
            }
            if (Request.Form["submit"] != null)
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];


                string tableName = "usersTBL";
                string fileName = "users.mdf";

                string sqlSelect = $"SELECT * FROM {tableName} WHERE username = '{username}' and password = '{password}'";

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int length = table.Rows.Count;
                if (length == 0)
                {
                    msg = "not found";
                }
                else
                {
                    Session["username"] = table.Rows[0]["username"];
                    Session["admin"] = table.Rows[0]["admin"] + "";
                    msg = "found";

                    //update users count
                    Application.Lock();
                    Application["usersCounter"] = (int)Application["usersCounter"] + 1;
                    Application.UnLock();
                }
            }
        }
    }
}