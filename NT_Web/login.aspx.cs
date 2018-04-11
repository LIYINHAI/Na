using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NT_Models;
using NT_BLL;
using System.Data.SqlClient;
namespace NT_Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            string Name = UserName.Text.Trim();
            string paw = Password.Text.Trim();
            try
            {
                SqlDataReader UserDr = UserInfoService.Login(Name, paw);
                if (UserDr.Read())
                {
                    Session["User_Name"] = UserName.Text;
                    Session["User_ID"] = UserDr["User_ID"].ToString();
                    Session["User_Img"] = UserDr[3].ToString();
                    Label1.Text = "登陆成功";
                    Response.Redirect("~/User_Index.aspx");
                }
                else
                {
                    Label1.Text = "用户名或密码错误";
                    Password.Text = "";
                    Password.Focus();
                }

            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex);
            }
        }
    }
}