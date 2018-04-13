using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
using System.Data;
using System.Configuration;
using NT_DAL;
namespace NT_BLL
{
   public class CullService
    {
        public static SqlServerCulinfo icull = new SqlServerCulinfo();
        //后台插入
        public static int Insert(Culinfo Cull)
        {
            return icull.Insert(Cull);
        }
        //后台删除
        public static int Delete(int Cull_ID)
        {
            return icull.Delete(Cull_ID);
        }
        //后台展现
        public static DataTable SelectAll()
        {
            return icull.SelectAll();
        }
        //主页展现前几
        public static DataTable SelectTop6()
        {
            return icull.SelectTop6();
        }
    }
}
