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
   public class CommentService
    {
        private static SqlServerComments icomments = new SqlServerComments();
        public static DataTable usersSellect(int User_ID)
        {
            return icomments.usersSellect(User_ID);
        }
        //用户删除自己的某个评论
        public static int usersDelete(int Comments_ID)
        {
            return icomments.usersDelete(Comments_ID);
        }
        //后台删除评论
        public static int DeleteComments(int Comments_ID)
        {
            return icomments.DeleteComments(Comments_ID);
        }
        //后台展现评论

        public DataTable SelectAllpinlun()
        {
            return icomments.SelectAllpinlun();
        }
    }
}
