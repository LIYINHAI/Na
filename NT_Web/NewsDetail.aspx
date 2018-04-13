<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="NT_Web.NewsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
                <%--左侧新闻标题--%>
                <div class="MoreNews">
                    <div class="NewIcon">

                        <p>最近新闻</p>
                    </div>
                    <div class="MoreNewsTitle">

                        <asp:ListView ID="ElseNewsListView" runat="server">
                            <LayoutTemplate>
                                <div id="itemPlaceholderContainer" runat="server">
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>

                                <ul class="box">
                                    <li><a href="NewsDetail.aspx?id=<%#Eval("News_ID") %>"><%#Eval("News_Title") %> </a>
                                        <br />
                                    </li>
                                </ul>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <%--右侧新闻内容--%>
                <div class="NewsContent">
                    <asp:Repeater ID="NewsContentRepeater" runat="server">
                        <ItemTemplate>
                            <div class="first-main">
                                <h3><%#Eval("News_Title") %></h3>
                                <h5>发布时间:<%#Eval("News_Time") %>&nbsp&nbsp&nbsp&nbsp </h5>
                            </div>
                            <br />
                            <div class="second-main">
                                <div class="text">
                                    <h6 style="line-height: 25px; margin-top: 15px; color: #555555; margin-left: 5px; margin-top: 5px; padding: 15px; font-size: 15px;">&nbsp&nbsp&nbsp&nbsp <%#Eval("News_Content") %></h6>
                                </div>

                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
</asp:Content>
