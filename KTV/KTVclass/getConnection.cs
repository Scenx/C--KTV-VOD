using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace KTV.KTVclass
{
    public class getConnection
    {
        public SqlConnection OledCon()
        {
            //创建连接数据库的字符串
            string reportPath = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString.ToString();
           
            //创建OleDbConnection对象
            SqlConnection con = new SqlConnection(reportPath);
            //con.Open();
            return con;
        }//end if
    }
}