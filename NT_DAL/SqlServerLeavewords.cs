using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NT_Models;

using System.Data;
namespace NT_DAL
{
   public  class SqlServerLeavewords
    {
        public DataTable userSellect(int User_ID)
        {
            string sql = "select * from Leavewords where User_ID='" + User_ID + "'";
            return DBHelper.GetFillData(sql);
        }
        //用户删除自己的某个留言
        public int usersDelete(int Leavewords_ID)
        {
            string sql = "delete from Leavewords where Leavewords_ID='" + Leavewords_ID + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
        //删除留言
        public int Deleteliuyan(int Leavewords_ID)
        {
            SqlParameter[] sp = { new SqlParameter("@Leavewords_ID", Leavewords_ID) };
            return DBHelper.GetExcuteNonQuery("DeleteComments", System.Data.CommandType.StoredProcedure, sp);
        }
        //展现留言

        public DataTable SelectAllliuyan()
        {
            string sql = "select a.*,b.User_Name,c.News_Title from Leavewords a,UserInfo b,NewsInfo c where a.User_ID=b.User_ID and a.News_ID=c.News_ID";
            return DBHelper.GetFillData(sql);
        }
    }
}
