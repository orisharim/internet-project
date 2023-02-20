using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// מחלקה המהווה ממשק בין האפליקציה לבסיס הנתונים
/// DataBase Type: Microsoft SQL Server Database File (SqlClient)
/// The Database file should be located in the folder: App_Data
/// </summary>
namespace internet_project.App_Start
{
    public class Helper
    {

        public static SqlConnection ConnectToDb(string fileName)
        {
            /// <summary>
            /// הפעולה מקבלת שם קובץ.
            /// הפעולה מייצרת ומחזירה אוביקט קישור לבסיס הנתונים
            /// </summary>

            string path = HttpContext.Current.Server.MapPath("App_Data/"); //מיקום מסד הפרוייקט
            path += fileName;

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }


        /// <summary>
        /// To Execute Update / Insert / Delete queries
        /// הפעולה מקבלת שם קובץ ושאילתה לביצוע.
        /// הפעולה מפעילה את השאילתה על בסיס הנתונים
        /// </summary>
        public static void DoQuery(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }


        /// <summary>
        /// הפעולה מקבלת שם קובץ ושאילתה לחיפוש ערך.
        /// הפעולה מחזירה אמת אם הערך נמצא ושקר אחרת
        /// </summary>
        public static bool IsExist(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader data = com.ExecuteReader();

            bool found = Convert.ToBoolean(data.Read());
            conn.Close();
            return found;
        }


        /// <summary>
        /// הפעולה מקבלת שם קובץ ושאילתת שליפה. 
        /// הפעולה ממירה את הרשומות שהוחזרו לתוך אובייקט מסוג DataTable  
        /// </summary>
        public static DataTable ExecuteDataTable(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);

            tableAdapter.Fill(dt);

            return dt;
        }

    }
}