using Internet_Project.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class editProfile : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "guest")
            {
                Response.Redirect("Home.aspx");
            }

            string tableName = "usersTBL";
            string fileName = "users.mdf";

            if (Request.Form["passwordSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET password = '{Request.Form["password"]}' WHERE username = '{Session["username"].ToString()}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["nameSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET name = '{Request.Form["name"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["familyNameSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET familyName = '{Request.Form["familyName"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["dobSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET year = '{Request.Form["dob"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["citySubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET city = '{Request.Form["city"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["phoneSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET phone = '{Request.Form["prefix"] + Request.Form["phonenumber"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
                

            }

            if (Request.Form["emailSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET email = '{Request.Form["email"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }

            if (Request.Form["genderSubmit"] != null)
            {
                string sql = $"UPDATE {tableName} SET gender = '{Request.Form["gender"]}' WHERE username = '{Session["username"]}'";
                Helper.DoQuery(fileName, sql);
            }
        }
    }
}