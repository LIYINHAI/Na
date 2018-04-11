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
   public class AcgService
    {
        private static SqlServerAcg iacg = new SqlServerAcg();
        //查找某用户创建的ACG&文物内容
        public static DataTable UserAcg(int User_ID)
        {
            return iacg.UserAcg(User_ID);
        }
        //根据作品ID进行删除操作
        public static int delete(int Pro_ID)
        {
            return iacg.delete(Pro_ID);
        }
        //用户发表ACG作品
        public static int addAcg(ACG acg)
        {
            return iacg.addAcg(acg);
        }
     }
}
