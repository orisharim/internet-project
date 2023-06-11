using internet_project.App_Start;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace internet_project
{
    public partial class users : System.Web.UI.Page
    {
        public string str = "";
        public string msg = "";
        public string sqlSelect = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "users.mdf";
            string tableName = "usersTBL";

            sqlSelect = $"Select * From {tableName}";

            DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

            int length = table.Rows.Count;
            if(length == 0)
            {
                msg = "db is empty(no users)";
            }
            else
            {
                str += "<tr>";
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

                for(int i = 0; i < length; i++)
                {
                    str += "<tr>";
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