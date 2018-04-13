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
    public partial class NewsDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["News_ID"] = Convert.ToInt32(Request.QueryString["id"]);
                BindNews();

            }
            BindNewsID();
            BindElseNews();
        }
        private void BindNewsID()
        {
            //传入数据
            int nid = Convert.ToInt32(Request.QueryString["id"]);
            //实现功能
            DataTable dt = NewsService.SelectID(nid);
            if (dt != null && dt.Rows.Count > 0)
            {
                NewsContentRepeater.DataSource = dt;
                NewsContentRepeater.DataBind();
            }
        }
        private void BindNews()
        {

            DataTable dt = NewsService.SelectTop(1);
            if (dt != null && dt.Rows.Count > 0)
            {
                NewsContentRepeater.DataSource = dt;
                NewsContentRepeater.DataBind();
            }
        }
        private void BindElseNews()
        {
            DataTable dt = NewsService.SelectTop(5);
            if (dt != null && dt.Rows.Count != 0)
            {
                ElseNewsListView.DataSource = dt;
                ElseNewsListView.DataBind();
            }
        }
    }
}