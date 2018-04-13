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
    public partial class AddCull : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ViewState["AssID"] = Convert.ToInt32(Request.QueryString["id2"]);
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "ckfinder";  //CKFinder路径  
            fileBrowser.SetupCKEditor(CKEditorControl1);
        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)//判断上传框是否有文件
            {
                bool FileOK = false;//初始化文件格式是否正确
                string FileExtension = System.IO.Path.GetExtension(FileUpload.FileName.ToLower());
                string[] allowedExtension = { ".jpg", ".jpeg", ".gif", ".png", ".bmp" };//设置允许上传的文件类型
                for (int i = 0; i < allowedExtension.Length; i++)
                {
                    if (FileExtension == allowedExtension[i])
                    {
                        FileOK = true;
                    }
                }
                if (FileOK)//文件类型正确
                {
                    try
                    {
                        string SavePath = Server.MapPath("~/Img/CullImg/");//指定上传文件在服务器上的保存路径
                        if (!System.IO.Directory.Exists(SavePath))//检查服务器上是否存在这个物理路径，如果不存在则创建
                        {
                            System.IO.Directory.CreateDirectory(SavePath);
                        }
                        SavePath = SavePath + "\\" + FileUpload.FileName;
                        FileUpload.SaveAs(SavePath);
                        Session["DocAddr"] = "UploadFiles\\Documents\\" + Session["UserName"] + "\\" + FileUpload.FileName;
                        Response.Write("<script>alert('上传成功');</script>");
                        Label2.Text = "Img\\CullImg\\" + FileUpload.FileName;
                        this.btnUpload.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('上传失败');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('上传的文件格式不正确，请重新选择！');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请选择需要上传的文件！');</script>");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (Label2.Text.Trim() == "")
                {
                    Response.Write("<script>alert('照片不能为空!')</script>");
                }
                else
                {
                    Culinfo Cull = new Culinfo();
                    Cull.Cull_Name= txtTitle.Text.Trim();
                    Cull.Cull_Content = CKEditorControl1.Text.Trim();
                    Cull.Cull_Img= Label2.Text;
                    Cull.Cull_Dyn = TextBox1.Text.Trim();
                    Cull.Cull_Class = TextBox2.Text.Trim();
                    int result =CullService.Insert(Cull);
                    if (result >= 1)
                    {
                        Response.Write("<script>alert('发布成功!')</script>");
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('上传失败');</script> 原因是：" + ex);
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}