using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace BMSwebService
{
    public class DBconnect
    {
        //创建连接数据库的方法
        public MySqlConnection OpenConnection()
        {
            //创建连接
            MySqlConnectionStringBuilder scsb = new MySqlConnectionStringBuilder();
            scsb.Server = "";
            scsb.UserID = "root";
            scsb.Password = "0000";
            scsb.Database = "book_mark_system";

            //判断连接是否打开
            MySqlConnection Connection = new MySqlConnection(scsb.ToString());//参数是连接数据库的字符串
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();

            return Connection;
        }

            
    }
}