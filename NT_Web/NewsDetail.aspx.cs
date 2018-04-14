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
           static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                ViewState["News_ID"] = Convert.ToInt32(Request.QueryString["id"]);
                BindNews();
                BindMessage();
                visibleflag = true;
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
        //绑定留言信息
        private void BindMessage()
        {
            int id = Convert.ToInt32(ViewState["News_ID"]);
            //int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = LeavewordsService.SelectLeavewords(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageListView.DataSource = dt;
                MessageListView.DataBind();
            }
        }
        //找到回复按钮
        protected void lkbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel panelreply = bt.Parent.FindControl("ReplyPanel") as Panel;
            panelreply.Visible = true;
            visibleflag = !visibleflag;
        }

        //回复留言
        protected void btnRply_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["News_ID"]);
            if (Session["User_Name"] != null)
            {
                if (Page.IsValid)
                {
                    LinkButton btn = (LinkButton)sender;
                    int userid = Convert.ToInt32(Session["User_ID"]);
                    ReplyLeavewords Replywords = new ReplyLeavewords();
                    Replywords.Leavewords_ID = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    Replywords.User_ID= userid;
                    Replywords.ReplyLeavewords_Comment = ((TextBox)btn.Parent.FindControl("txtReplyContent")).Text;
                    Replywords.ReplyLeavewords_Time = DateTime.Now;
                    int result = ReplyLeavewordsService.InsertReplyLeavewords(Replywords);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复成功')", true);
                        visibleflag = true;
                        BindMessage();

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('回复失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(ReplyUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(ReplyUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
        //绑定回复留言
        protected void lvComments_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddenComID = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int LeaveID = int.Parse(hiddenComID.Value);
                Repeater rpt = e.Item.FindControl("ReplyRepeater") as Repeater;
                DataTable dt = ReplyLeavewordsService.SelectReplyLeavewords(LeaveID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }
        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            if (visibleflag == true)
            {
                BindMessage();
            }
        }

        protected void btnMessage_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["News_ID"]);
            if (Session["User_Name"] != null)
            {
                if (Page.IsValid)
                {
                    int userid = Convert.ToInt32(Session["User_ID"]);
                    int newsid = Convert.ToInt32(Request.QueryString["News_ID"]);
                    Leavewords leavewords = new Leavewords();
                    leavewords.Leavewords_ID = userid;
                    leavewords.News_ID = newsid;
                    leavewords.Leavewords_Content = txtMessage.Text.Trim();
                    leavewords.Leavewords_Time = DateTime.Now;
                    int result = LeavewordsService.InsertLeavewords(leavewords);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言成功')", true);
                        BindMessage();
                        txtMessage.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('留言失败')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(MessageUpdatePanel, this.GetType(), "click", "alert('您必须先登录才能发表评论');", true);
                ScriptManager.RegisterStartupScript(MessageUpdatePanel, MessageUpdatePanel.GetType(), "updateScript", "window.location.href='Login.aspx'", true);
            }
        }
    }
}