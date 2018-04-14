using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NT_Models;
using NT_BLL;
using System.Data.SqlClient;
using System.Data;
namespace NT_Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAcg();
                BindNews();
                BindCull();
            }
        }
        //主页Acg
        private void BindAcg()
        {
            DataTable dt = AcgService.SelectTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void BindNews()
        {
            DataTable dt = NewsService.SelectTop(6);
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        //主页文物宝鉴
        private void BindCull()
        {
            DataTable dt = CullService.SelectTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
    }
}