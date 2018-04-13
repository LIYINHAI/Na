<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Cull.aspx.cs" Inherits="NT_Web.Cull" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                            <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("Cull_Name") %>' Font-Size="12" NavigateUrl='<%#"~/NewsDetail.aspx?id="+Eval("Cull_ID") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("Cull_Name") %>' onmouseover="this.style.textDecoration='underline';this.style.color='steelblue';" onmouseout="this.style.textDecoration='none';this.style.color='#2b2b2b'"></asp:HyperLink>
                            <asp:Image ID="Image1" runat="server" CssClass="img-responsive" src='<%#Eval("Cull_Img") %>' />
                        </div>
                        <div style="float: right; padding: 5px; width: 12%;">
                            <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#Eval("Cull_Dyn")%>' ForeColor="gray"></asp:Label>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
</asp:Content>
