using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using NT_Models;

using System.Data;

namespace NT_DAL
{
    public class SqlServerUserInfo 
    {
        public int DeleteAct(int User_ID)
        {
            string sql = "delete from UserInfo where  User_ID=@User_ID";
            SqlParameter[] sp = { new SqlParameter("@User_ID",User_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //登陆
        public SqlDataReader Login(string Name, string paw)
        {

            string sql = "select * from UserInfo where  User_Name=@UserName and User_Password=@Password";
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@UserName",Name),
                new SqlParameter("@Password",paw)
        };
            return DBHelper.GetDataReader(sql, sp);
        }

        public DataTable SelectTextAll()
        {
            string sql = "select * from UserInfo";
            return DBHelper.GetFillData(sql);
        }
        //注册
        public int Insert(UserInfo userinfo)
        {
            string sql = "insert into UserInfo values (@User_Name,@User_Img,@User_Password,@User_Email,@User_Phone)";
            SqlParameter[] sp = new SqlParameter[]{
                                                 new SqlParameter("@User_Name",userinfo.User_Name),
                                                 new SqlParameter("@User_Img",userinfo.User_Img),
                                                 new SqlParameter("User_Password",userinfo.User_Password),
                                                 new SqlParameter("User_Email",userinfo.User_Email),
                                                 new SqlParameter("User_Phone",userinfo.User_Phone)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //查询某位用户具体信息
        public SqlDataReader users(int User_ID)
        {
            string sql = "select * from UserInfo where User_ID=@User_ID";
            SqlParameter[] sp =
            {
                new SqlParameter("@User_ID",User_ID)
            };
            return DBHelper.GetDataReader(sql, sp);
        }
        //用户修改自己的信息
        public int usersupdate(UserInfo userInfo)
        {
            string sql = "update UserInfo set User_Password=@User_Password,User_Img=@User_Img,User_Email=@User_Email,User_Phone=@User_Phone where User_ID=@User_ID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@User_ID",userInfo.User_ID),
                new SqlParameter("@User_Name",userInfo.User_Name),
                new SqlParameter("@User_Password",userInfo.User_Password),
                new SqlParameter("@User_Img",userInfo.User_Img),
                new SqlParameter("@User_Phone",userInfo.User_Phone),
                new SqlParameter("@User_Email",userInfo.User_Email)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
