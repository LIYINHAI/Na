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
    public partial class News : System.Web.UI.Page
    {
        bool isDataPager = true;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (isDataPager)
            {
                BindNews();
            }
        }
        private void BindNews()
        {
            DataTable dt = NewsService.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
    }
}