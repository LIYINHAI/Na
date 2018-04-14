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
   public class ReplyLeavewordsService
    {
        private static SqlServerReplyLeavewords ireplyleavewords = new SqlServerReplyLeavewords();
        public static int Delete(int ReplyLeavewords_ID)
        {
            return ireplyleavewords.Delete(ReplyLeavewords_ID);
        }

        //展现
        public static DataTable SelectAll()
        {
            return ireplyleavewords.SelectAll();
        }
        //回复留言
        public static int InsertReplyLeavewords(ReplyLeavewords Replywords)
        {
            return ireplyleavewords.InsertReplyLeavewords(Replywords);
        }
        //展现留言
        public static DataTable SelectReplyLeavewords(int Leavewords_ID)
        {
            return ireplyleavewords.SelectReplyLeavewords(Leavewords_ID);
        }
    }
}
