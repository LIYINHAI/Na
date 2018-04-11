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
   public class ReplyCommentsService
    {
        private static SqlServerReplyComments ireplycomments = new SqlServerReplyComments();
        //删除
        public static int Delete(int ReplyComments_ID)
        {
            return ireplycomments.Delete(ReplyComments_ID);
        }
        //展现
        public static DataTable SelectAll()
        {
            return ireplycomments.SelectAll();
        }
    }
}
