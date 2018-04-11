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
   public class SqlServerComments
    {
        //查询某用户的所有评论
        public DataTable usersSellect(int User_ID)
        {

            string sql = "select * from Comments where User_ID='"+User_ID+"'";
            return DBHelper.GetFillData(sql);
        }
        //用户删除自己的某个评论
        public int usersDelete(int Comments_ID)
        {
            string sql= "delete from Comments where Comments_ID='" + Comments_ID + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
        //后台删除评论
        public int DeleteComments(int Comments_ID)
        {
            SqlParameter[] sp = { new SqlParameter("@Comments_ID", Comments_ID) };
            return DBHelper.GetExcuteNonQuery("DeleteComments", System.Data.CommandType.StoredProcedure, sp);
        }
        //后台展现评论

        public DataTable SelectAllpinlun()
        {
            string sql = "select a.*,b.User_Name,c.Pro_Title from Comments a,UserInfo b,ACG c where a.User_ID=b.User_ID and a.Pro_ID=c.Pro_ID";
            return DBHelper.GetFillData(sql);
        }
    }
}
