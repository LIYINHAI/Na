using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace NT_DAL
{
   public  class SqlServerAcg
    {
        //查找某用户创建的ACG&文物内容
        public DataTable UserAcg(int User_ID)
        {
            string sql= "select * from ACG where User_ID='"+User_ID+"'";
          
            return DBHelper.GetFillData(sql);
        }
        //根据作品ID进行删除操作
        public int delete(int Pro_ID)
        {
            string sql= "delete from ACG where News_ID = '" + Pro_ID + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
       //用户发表ACG作品
       public int addAcg(ACG acg)
        {
            string sql = "insert into ACG values(@User_ID, @Pro_Class, @Pro_Title, @Pro_Time, @Pro_Content, @Cull_Name, @Pro_Img)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@User_ID",acg.User_ID),
                new SqlParameter("@Pro_Class",acg.Pro_Class),
                new SqlParameter("@Pro_Title",acg.Pro_Title),
                new SqlParameter("@Pro_Time",acg.Pro_Time),
                new SqlParameter("@Pro_Content",acg.Pro_Content),
                new SqlParameter("@Cull_Name",acg.Cull_Name),
                new SqlParameter("@Pro_Img",acg.Pro_Img)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
            
        }
    }
}
