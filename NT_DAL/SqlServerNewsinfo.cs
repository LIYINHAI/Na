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
   public  class SqlServerNewsinfo
    {
        //根据ID展现
        public DataTable SelectID(int News_ID)
        {
            string sql = "select  * from News where News_ID=@News_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@News_ID",News_ID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        //删除
        public int Delete(int News_ID)
        {
            string sql = "delete from News where News_ID=@News_ID";
            SqlParameter[] sp = { new SqlParameter("@News_ID", News_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        //展现
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.Cull_Name from News a,Cull b where a.Cull_ID=b.Cull_ID ";
            return DBHelper.GetFillData(sql);
        }
        //展现前几
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " * from News order by News_Time desc";

            return DBHelper.GetFillData(sql);
        }
    }
}
