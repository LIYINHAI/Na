<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Index.aspx.cs" Inherits="NT_Web.User_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户主页</title>

    <link href="CSS/User_IndexCSS1.css" rel="stylesheet" />
    <link href="CSS/User_IndexCSS2.css" rel="stylesheet" />
    <link href="CSS/User_IndexCSS3.css" rel="stylesheet" />
    <%--个人中心导航页鼠标经过 --%>
    <%--<script type="text/javascript">
        function message() {
            document.getElementById("acg").style.display == 'none';
            document.getElementById("comments").style.display == 'none';
            document.getElementById("leavwords").style.display == 'none';
            if (document.getElementById("userinfo").style.display == 'none') {
                
                document.getElementById("userinfo").style.display = 'block';  //触动的ul如果处于显示状态，即隐藏
            }
            else {
                document.getElementById("userinfo").style.display = 'none';  //触动的ul如果处于隐藏状态，即显示
            }
        }
        function Acg() {
            document.getElementById("userinfo").style.display == 'none';
            document.getElementById("comments").style.display == 'none';
            document.getElementById("leavwords").style.display == 'none';
            if (document.getElementById("acg").style.display == 'none') {
               
                document.getElementById("acg").style.display = 'block';  //触动的ul如果处于显示状态，即隐藏
            }
            else {
                document.getElementById("acg").style.display = 'none';  //触动的ul如果处于隐藏状态，即显示
            }
        }
        function Comments() {
            document.getElementById("userinfo").style.display == 'none';
            document.getElementById("leavwords").style.display == 'none';
            document.getElementById("acg").style.display = 'none';
            if (document.getElementById("comments").style.display == 'none') {
               
                document.getElementById("comments").style.display == 'block';
               //触动的ul如果处于显示状态，即隐藏
            }
            else {
                document.getElementById("comments").style.display = 'none';  //触动的ul如果处于隐藏状态，即显示
            }
        }
        function Leavewords() {
            document.getElementById("userinfo").style.display == 'none';
            document.getElementById("comments").style.display == 'none';
            document.getElementById("acg").style.display = 'none';
            if (document.getElementById("leavwords").style.display == 'none') {
               
                document.getElementById("leavwords").style.display == 'block';
                 //触动的ul如果处于显示状态，即隐藏
            }
            else {
                document.getElementById("leavwords").style.display = 'none';  //触动的ul如果处于隐藏状态，即显示
            }
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          
            <article class="mainContent">
                  <%-- 用户主页导航--%>
                <div class="order_left">
                    <%--用户头像--%>
                    <div class="tit" style="margin-bottom: 22px;">
                        <asp:Image ID="UserImg" runat="server" CssClass="img-circle" Height="100px" Width="100px" />
                    </div>
                    <%--用户信息修改--%>
                    <div class="my_xx">
                        <div class="c" style="margin-bottom: 1px;" onmouseover="message()">
                            <asp:Label ID="UserInfo" runat="server" Text="用户信息" ></asp:Label>
                        </div>
                        <p class="hr"></p>
                    </div>
                    <%-- 投稿管理--%>
                    <div class="my_srdz">
                        <div class="c" style="margin-bottom: 1px;" onmouseover="Acg()">
                            <asp:Label ID="Acg" runat="server" Text="投稿管理" ></asp:Label>
                            <p class="hr"></p>
                        </div>
                    </div>
                    <%--评论--%>
                    <div class="my_jxfx">
                        <div class="c" style="margin-bottom: 1px;"onmouseover="Comments()">
                            <asp:Label ID="Comments" runat="server" Text="评论" ></asp:Label>
                            <p class="hr"></p>
                        </div>
                    </div>
                    <%-- 回复--%>
                    <div class="my_jxfx">
                        <div class="c" style="margin-bottom: 1px;"onmouseover="Leavewords()">
                            <asp:Label ID="Leavewords" runat="server" Text="回复" ></asp:Label>
                            <p class="hr"></p>
                        </div>
                    </div>



                </div>
                <%--数据内容--%>
                <div class="grzx_content">
                    <%-- 修改个人信息--%>
                    <div class="right_side" id="userinfo">
                        <h3>个人资料</h3>
                        <div id="contentInfo" class="c_conInfo">
                            <div class="person_info">
                                <div id="nicImage">
                                    <label class="label">
                                        <span class="light_space light">*头&nbsp;&nbsp;像：</span>
                                        <span class="space"></span>
                                    </label>
                                    <asp:Image ID="User_Img" runat="server" CssClass="img-circle" Height="62px" Width="64px" />
                                    <asp:FileUpload ID="FileUpload_img" runat="server" Visible="false" />
                                </div>
                                <br />
                                <div id="nickname">
                                    <label class="label">
                                        <span class="light_space light">* 姓&nbsp;&nbsp;名：</span>
                                        <span class="space"></span>
                                    </label>

                                    <asp:TextBox ID="User_Name" runat="server" MaxLength="40"  CssClass="txt"></asp:TextBox>
                                </div>
                                <br />
                                <div id="pass">
                                    <label class="label">
                                        <span class="light_space light">* 密&nbsp;&nbsp;码：</span>
                                        <span class="space"></span>
                                    </label>

                                    <asp:TextBox ID="User_Password" runat="server" MaxLength="40"  CssClass="txt"></asp:TextBox>
                                </div>
                                <br />
                                <div id="repass">
                                    <label class="label">
                                        <span class="light_space light">*  确认密码：</span>
                                        <span class="space"></span>
                                    </label>

                                    <asp:TextBox ID="User_Password2" runat="server" MaxLength="40"  CssClass="txt"></asp:TextBox>
                                </div>
                                <br />
                                <div id="phone">
                                    <label class="label">
                                        <span class="light_space light">* 手&nbsp;机&nbsp;号：</span>
                                        <span class="space"></span>
                                    </label>

                                    <asp:TextBox ID="User_Phone" runat="server" MaxLength="40"  CssClass="txt"></asp:TextBox>
                                </div>
                                <br />
                                <br />
                                <div id="Email">
                                    <label class="label">
                                        <span class="light_space light">* 邮&nbsp;&nbsp;箱：</span>
                                        <span class="space"></span>
                                    </label>
                                    <asp:TextBox ID="User_Email" runat="server" MaxLength="40"  CssClass="txt"></asp:TextBox>

                                </div>
                                <br />
                                <span style="float: left;">
                                    <asp:Button ID="Change" runat="server" Text="修改" CssClass="c_subbutton" OnClick="Change_Click" />
                                    <asp:Button ID="noChange" runat="server" Text="重置" CssClass="c_subbutton" OnClick="noChange_Click" />
                                </span>
                            </div>
                        </div>

                    </div>

                    <%-- 绑定数据--%>

                     <%--ACG投稿管理 --%>
                    <div class="right_side" id="acg">                     
                        <div>
                            <table class="data display datatable" id="example">
                                <thead>
                                </thead>
                                <asp:ListView ID="UserIndex_Acg" runat="server">
                                    <ItemTemplate>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:HyperLink ID="Pro_Title" runat="server" ForeColor="Black" CssClass="text" Text='<%# SplitChar(Eval("Pro_Title").ToString(),10) %>' NavigateUrl='<%# "../.aspx?prosid="+ Eval("Pro_ID") %>'></asp:HyperLink>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Pro_Time" runat="server" Text='<%# Eval("Pro_Time") %>'></asp:Label>
                                                </td>

                                                <td style="text-align: left">
                                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Pro_ID")%>' />

                                                    <asp:HyperLink CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="删除" NavigateUrl='<%#"~/User_Index.aspx?proid="+ Eval("Pro_ID")%>' OnClientClick="return confirm('确认删除？')" Height="25px" Font-Size="12px" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </ItemTemplate>
                                </asp:ListView>
                            </table>
                        </div>
                        <div class="sxy">
                            共有<span id="totalRows" runat="server"></span>条   
 <span id="totalPage" runat="server"></span>
                            <asp:DataPager runat="server" PagedControlID="UserIndex_Acg" PageSize="4" ID="DDPager">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                    <asp:NumericPagerField ButtonCount="4" />
                                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </div>
                    <%--评论 --%>
                     <div class="right_side" id="comments">                     
                        <div>
                            <table class="data display datatable">
                                <thead>
                                </thead>
                                <asp:ListView ID="UserIndex_Comments" runat="server">
                                    <ItemTemplate>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:HyperLink ID="Comments_Content" runat="server" ForeColor="Black" CssClass="text" Text='<%# SplitChar(Eval("Comments_Content").ToString(),10) %>' NavigateUrl='<%# "../.aspx?comments="+ Eval("Comments_ID") %>'></asp:HyperLink>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Comments_Time" runat="server" Text='<%# Eval("Comments_Time") %>'></asp:Label>
                                                </td>

                                                <td style="text-align: left">
                                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Comments_ID")%>' />

                                                    <asp:HyperLink CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="删除" NavigateUrl='<%#"~/User_Index.aspx?proid="+ Eval("Comments_ID")%>' OnClientClick="return confirm('确认删除？')" Height="25px" Font-Size="12px" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </ItemTemplate>
                                </asp:ListView>
                            </table>
                        </div>
                        <div class="sxy">
                            共有<span id="Span1" runat="server"></span>条   
 <span id="Span2" runat="server"></span>
                            <asp:DataPager runat="server" PagedControlID="UserIndex_Comments" PageSize="4" ID="DataPager1">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                    <asp:NumericPagerField ButtonCount="4" />
                                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </div>
                     <%--评论 --%>
                     <div class="right_side" id="leavwords">                     
                        <div>
                            <table class="data display datatable">
                                <thead>
                                </thead>
                                <asp:ListView ID="UserIndex_Leavewords" runat="server">
                                    <ItemTemplate>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:HyperLink ID="Leavewords_Title" runat="server" ForeColor="Black" CssClass="text" Text='<%# SplitChar(Eval("Leavewords_Title").ToString(),10) %>' NavigateUrl='<%# "../.aspx?leavewordsid="+ Eval("Leavewords_ID") %>'></asp:HyperLink>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Leavewords_Time" runat="server" Text='<%# Eval("Leavewords_Time") %>'></asp:Label>
                                                </td>

                                                <td style="text-align: left">
                                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Leavewords_ID")%>' />

                                                    <asp:HyperLink CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="删除" NavigateUrl='<%#"~/User_Index.aspx?leavewordsid="+ Eval("Leavewords_ID")%>' OnClientClick="return confirm('确认删除？')" Height="25px" Font-Size="12px" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </ItemTemplate>
                                </asp:ListView>
                            </table>
                        </div>
                        <div class="sxy">
                            共有<span id="Span3" runat="server"></span>条   
 <span id="Span4" runat="server"></span>
                            <asp:DataPager runat="server" PagedControlID="UserIndex_Leavewords" PageSize="4" ID="DataPager2">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                    <asp:NumericPagerField ButtonCount="4" />
                                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </div>
                </div>
            </article>

        </div>
    </form>
</body>
</html>
