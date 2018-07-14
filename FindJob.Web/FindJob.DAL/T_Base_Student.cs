using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace FindJob.DAL
{
    public class T_Base_Student
    {
        /// <summary>
        /// 读取数据库连接字符串
        /// </summary>
        public string sqlstr = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
    }
}
