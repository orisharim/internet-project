using Internet_Project.App_Start;
using System;
using System.Data;

namespace Internet_Project.aspx
{
    public partial class users : System.Web.UI.Page
    {
        public string str = "";
        public string msg = "";
        public string sqlSelect = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "False")
            {
                Response.Redirect("Home.aspx");
            }

            string fileName = "users.mdf";
            string tableName = "usersTBL";

            if (Request.Form["searchUser"] == null)
            {
                sqlSelect = $"Select * From {tableName}";
            }
            else
            {
                sqlSelect = $"Select * From {tableName} Where username Like '%{Request.Form["searchUser"]}%'";
            }
                

            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int length = table.Rows.Count;
            if (length == 0)
            {
                msg = "db is empty(no users)";
            }
            else
            {
                str += "<tr>";
                str += "<td>delete user</td>";
                str += "<td>username</td>";
                str += "<td>password</td>";
                str += "<td>name</td>";
                str += "<td>familyName</td>";
                str += "<td>year</td>";
                str += "<td>city</td>";
                str += "<td>phone</td>";
                str += "<td>email</td>";
                str += "<td>gender</td>";
                str += "<td>admin</td>";
                str += "</tr>";

                for (int i = 0; i < length; i++)
                {                   
                        str += "<tr>";
                        str += $"<td><a href=\"deleteUser.aspx?userToDelete=" + table.Rows[i]["username"].ToString() + "\">deleteUser</a></td>";
                        str += $"<td>{table.Rows[i]["username"]}</td>";
                        str += $"<td>{table.Rows[i]["password"]}</td>";
                        str += $"<td>{table.Rows[i]["name"]}</td>";
                        str += $"<td>{table.Rows[i]["familyName"]}</td>";
                        str += $"<td>{table.Rows[i]["year"]}</td>";
                        str += $"<td>{table.Rows[i]["city"]}</td>";
                        str += $"<td>{table.Rows[i]["phone"]}</td>";
                        str += $"<td>{table.Rows[i]["email"]}</td>";
                        str += $"<td>{table.Rows[i]["gender"]}</td>";
                        str += $"<td>{table.Rows[i]["admin"]}</td>";
                        str += "</tr>";

                }

            }



        }
    }
}