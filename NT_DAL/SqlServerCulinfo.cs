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
   public class SqlServerCulinfo
    {
        //后台增加
        public int Insert(Culinfo Cull)
        {
            string sql = "insert into Cull values(@Cull_Name,@Cull_Img,@Cull_Content,@Cull_Dyn,@Cull_Class)";
            SqlParameter[] sp = new SqlParameter[] {
                                                 new SqlParameter("@Cull_Name",Cull.Cull_Name),
                                                 new SqlParameter("@Cull_Img",Cull.Cull_Img),
                                                 new SqlParameter("@Cull_Content",Cull.Cull_Content),
                                                 new SqlParameter("@Cull_Dyn",Cull.Cull_Dyn),
                                                 new SqlParameter("@Cull_Class",Cull.Cull_Class)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        //后台删除
        public int Delete(int Cull_ID)
        {
            string sql = "delete from Cull where Cull_ID=@Cull_ID";
            SqlParameter[] sp = { new SqlParameter("@Cull_ID",Cull_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //后台展现
        public DataTable SelectAll()
        {
            string sql = "select * from Cull";
            return DBHelper.GetFillData(sql);
        }
        //主页展示前几的
        public DataTable SelectTop6()
        {
            string sql = "select top 6 * from Cull order by Cull_Content desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
