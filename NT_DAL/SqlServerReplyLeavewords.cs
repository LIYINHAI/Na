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
   public  class SqlServerReplyLeavewords
    {
        //删除
        public int Delete(int ReplyLeavewords_ID)
        {
            string sql = "delete from ReplyLeavewords where ReplyLeavewords_ID=@ReplyLeavewords_ID";
            SqlParameter[] sp = { new SqlParameter("@ReplyLeavewords_ID", ReplyLeavewords_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.User_Name,c.Leavewords_Content from ReplyLeavewords a,UserInfo b,Leavewords c where a.User_ID=b.User_ID and a.Leavewords_ID=c.Leavewords_ID";
            return DBHelper.GetFillData(sql);
        }
        //回复留言
        public int InsertReplyLeavewords(ReplyLeavewords Replywords)
        {
            string sql = "insert into ReplyLeavewords(Leavewords_ID,User_ID,ReplyLeavewords_Comment,ReplyLeavewords_Time) values(@LeaveID,@UserID,@ReplyContent,@ReplyTime)";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@LeaveID",Replywords.Leavewords_ID),
                    new SqlParameter("@UserID",Replywords.User_ID),
                    new SqlParameter("@ReplyContent",Replywords.ReplyLeavewords_Comment),
                    new SqlParameter("@ReplyTime",Replywords.ReplyLeavewords_Time)
                };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectReplyLeavewords(int Leavewords_ID)
        {
            string sql = "select ReplyLeavewords.*,a.User_Name as 回复人,b.User_Name as 被回复人 from UserInfo a,UserInfo b,ReplyLeavewords,Leavewords where a.User_ID=ReplyLeavewords.User_ID and b.User_ID=Leavewords.User_ID and ReplyLeavewords.Leavewords_ID=Leavewords.Leavewords_ID and Leavewords.Leavewords_ID=@Leavewords_ID";
            SqlParameter[] para = { new SqlParameter("@Leavewords_ID", Leavewords_ID) };
            return DBHelper.GetFillData(sql, para);
        }
    }
}
