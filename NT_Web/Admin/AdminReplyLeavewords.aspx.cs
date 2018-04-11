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
namespace NT_Web.Admin
{
    public partial class AdminReplyLeavewords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAct();
            }
        }
        //截断
        protected string SplitChar(string sObj, int intLen)
        {
            if (sObj.Length > intLen)
            {
                return sObj.Substring(0, intLen) + "…";
            }
            return sObj;
        }
        //数据绑定
        private void BindAct()
        {

            DataTable dt = ReplyLeavewordsService.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        //删除事件
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int id = Convert.ToInt32(((HiddenField)(bt.Parent.FindControl("HiddenField1"))).Value);
            if (ReplyLeavewordsService.Delete(id) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "message", "<script language='javascript' >alert('删除成功！');</script>");
                BindAct();
            }
        }
    }
}