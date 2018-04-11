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
   public class LeavewordsService
    {
        private static SqlServerLeavewords ileavewords = new SqlServerLeavewords();
        public static DataTable usersSellect(int User_ID)
        {
            return ileavewords.userSellect(User_ID);
        }
        //用户删除自己的某个留言
        public static int usersDelete(int Leavewords_ID)
        {
            return ileavewords.usersDelete(Leavewords_ID);
        }
        //后台删除留言
        public static int Deleteliuyan(int Leavewords_ID)
        {
            return ileavewords.Deleteliuyan(Leavewords_ID);
        }
        //后台展现留言

        public static DataTable SelectAllliuyan()
        {
            return ileavewords.SelectAllliuyan();
        }
    }
}
