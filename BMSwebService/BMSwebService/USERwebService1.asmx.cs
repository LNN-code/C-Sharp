using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BMSwebService
{
    /// <summary>
    /// USERwebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class USERwebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool Login(string user_id,string passward)
        {
            //拼接sql语句
            string strMySQL = "select * from USER where user_id = '"+user_id+"' and passward = '"+passward+"' ";
            //执行MySQL语句
            DBconnect DBconnection =new DBconnect();//实例化连接数据库的类的对象
            MySqlConnection conn = DBconnection.OpenConnection();//调用对象中的打开数据库的方法
            MySqlCommand comm = new MySqlCommand(strMySQL, conn);//实例化sqlcommand的对象
            int row_count = comm.ExecuteNonQuery();//执行SQL语句，并接收返回的受影响的行数
            if (row_count > 0)//如果行数大于0，则说明用户名和密码没问题
                return true;

            return false;
        }
    }
}
