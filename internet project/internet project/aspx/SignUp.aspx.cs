using Internet_Project.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Project.aspx
{
    public partial class SignUp : System.Web.UI.Page
    {
        public string st;
        public string msg;
        public string sqlMsg;


        
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
                string name = Request.Form["name"];
                string familyName = Request.Form["familyName"];
                string dob = Request.Form["dob"];
                string city = Request.Form["city"];
                string phone = Request.Form["prefix"] + Request.Form["phonenumber"];
                string email = Request.Form["email"];
                string gender = Request.Form["gender"];


                string tableName = "usersTBL";
                string fileName = "users.mdf";

                string sqlSelect = $"SELECT * FROM {tableName} WHERE username = '{username}'";

                if (Helper.IsExist(fileName, sqlSelect))
                {
                    msg = "username already exists";
                    sqlMsg = sqlSelect;

                }
                else
                {
                    string sqlInsert = "INSERT INTO " + tableName;
                    sqlInsert += $" VALUES ('{username}','{password}','{name}','{familyName}','{dob}','{city}','{phone}','{email}','{gender}','false')";
                    sqlMsg = sqlInsert;
                    Helper.DoQuery(fileName, sqlInsert);
                    msg = "success";
                }

            }


        }
    }
}