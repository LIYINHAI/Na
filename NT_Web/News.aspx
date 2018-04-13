<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="NT_Web.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
                <div style="float:right;">
                    <p>当前位置：新闻资讯</p>
                </div>
            </div>
        </div>

        <div>
            <asp:ListView ID="ListView1" runat="server">
                 <LayoutTemplate>
                    <div id="itemPlaceholderContainer" runat="server">
                        <div id="itemPlaceholder" runat="server">
                        </div>
                    </div>
                    <div style="width: 100%; float: left; background-color: #ececec;">
                        <asp:DataPager ID="DataPager1" class="myPager" runat="server" PageSize="8">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowNextPageButton="false"
                                    ShowPreviousPageButton="true" FirstPageText="首页" NextPageText="下一页" PreviousPageText="上一页" LastPageText="尾页" />
                                <asp:NumericPagerField ButtonCount="5" CurrentPageLabelCssClass="current" />
                                <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True"
                                    ShowNextPageButton="true" NextPageText="下一页" PreviousPageText="上一页"  ShowPreviousPageButton="false" FirstPageText="首页" LastPageText="尾页" />

                            </Fields>

                        </asp:DataPager>

                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <br />
                    <div style="font-family: 'Microsoft YaHei'; border-bottom: 1px dashed #e3e3e5; padding: 5px; overflow: hidden;">
                        <div style="float: left; padding: 5px; width: 80%;">
                            <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("News_Title") %>' Font-Size="12" NavigateUrl='<%#"~/NewsDetail.aspx?id="+Eval("News_ID") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("News_Title") %>' onmouseover="this.style.textDecoration='underline';this.style.color='steelblue';" onmouseout="this.style.textDecoration='none';this.style.color='#2b2b2b'"></asp:HyperLink>
                        </div>
                        <div style="float: right; padding: 5px; width: 12%;">
                            <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#String.Format("{0:yyyy-MM-dd hh:mm}",Eval("News_Time")) %>' ForeColor="gray"></asp:Label>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
</asp:Content>
