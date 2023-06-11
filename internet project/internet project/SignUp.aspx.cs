using internet_project.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace internet_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string st;
        public string msg;
        public string sqlMsg;


        public static bool IsValidEmailAddress(string email)
        {  
            //regex for email address
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(email);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
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
                else if (!password.Equals(Request.Form["confirmpassword"]))
                {
                    msg = "password doesnt match confirm password";
                }
                else if (!IsValidEmailAddress(Request.Form["email"]))
                {
                    msg = "email is not valid";
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