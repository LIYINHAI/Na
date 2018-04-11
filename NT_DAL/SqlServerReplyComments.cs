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
   public  class SqlServerReplyComments
    {
        //删除
        public int Delete(int ReplyComments_ID)
        {
            SqlParameter[] sp = { new SqlParameter("@ReplyComments_ID", ReplyComments_ID) };
            return DBHelper.GetExcuteNonQuery("ReplyComments_ID", System.Data.CommandType.StoredProcedure, sp);
        }
        
        //展现
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.User_Name,c.Comments_Content from ReplyComments a,UserInfo b,Comments c where a.User_ID=b.User_ID and a.Comments_ID=c.Comments_ID";
            return DBHelper.GetFillData(sql);
        }
    }
}
