using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using NT_DAL;
namespace NT_BLL
{
   public class UserInfoService
    {
        private static SqlServerUserInfo iuserinfo = new SqlServerUserInfo();
        //删除用户信息
        public static int DeleteAct(int User_ID)
        {
            return iuserinfo.DeleteAct(User_ID);
        }
        //展现用户信息
        public static DataTable SelectTextAll()
        {
            return iuserinfo.SelectTextAll();
        }
        //登陆
        public static SqlDataReader Login(string Name, string paw)
        {
            return iuserinfo.Login(Name, paw);
        }
        //注册
        public static int Insert(UserInfo userinfo)
        {
            return iuserinfo.Insert(userinfo);
        }
        //查询某位用户具体信息
        public static SqlDataReader users(int User_ID)
        {
            return iuserinfo.users(User_ID);
        }

        //用户修改自己的信息
        public static int usersupdate(UserInfo userinfo)
        {
            return iuserinfo.usersupdate(userinfo);
        }
    }
}
