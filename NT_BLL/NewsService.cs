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
   public class NewsService
    {
        public static SqlServerNewsinfo inewsinfo = new SqlServerNewsinfo();
        //后台删除
        public static int Delete(int News_ID)
        {
            return inewsinfo.Delete(News_ID);
        }

        //后台展现
        public static DataTable SelectAll()
        {
            return inewsinfo.SelectAll();
        }
        //根据ID展示
        public static DataTable SelectID(int News_ID)
        {
            return inewsinfo.SelectID(News_ID);
        }
        //前台展现前几
        public static DataTable SelectTop(int top)
        {
            return inewsinfo.SelectTop(top);
        }
    }
}
