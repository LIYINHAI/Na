<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="NT_Web.NewsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:ScriptManager ID="ScriptManager2" runat="server">
              </asp:ScriptManager>
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

                                        <div class="comments" id="command">
                                    <asp:UpdatePanel ID="MessageUpdatePanel" runat="server">
                                        <ContentTemplate>
                                    <div class="first_main">
                                    <h4 class="widget-title" style="margin-bottom: 20px;">留言板</h4>
                                        <div class="Messagetext">
                                            <asp:TextBox ID="txtMessage" runat="server" class="form-control" placeholder="评论一番" TextMode="MultiLine"  ValidationGroup="txtMessage"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvtxtMessage" runat="server" ControlToValidate="txtMessage" SetFocusOnError="true" ErrorMessage="评论不能为空"  Display="Dynamic" ValidationGroup="txtMessage">评论不能为空</asp:RequiredFieldValidator>
                                        </div>
                                        <div class="btnMessage">
                                            <asp:Button ID="btnMessage" runat="server" class="btn btn-info" Text="发布留言"  OnClick="btnMessage_Click" ValidationGroup="txtMessage"/>
                                        </div>
                                    </div> 
                                      </ContentTemplate>
                            </asp:UpdatePanel>
                                   
                                    <asp:UpdatePanel ID="ReplyUpdatePanel" runat="server">
                                        <ContentTemplate>
                                            <asp:ListView ID="MessageListView" runat="server"  OnItemDataBound="lvComments_ItemDataBound">
                                                  <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="comment_content">
                                <div style="border-top: 1px solid #dcd9d9; border-bottom: 1px solid #dcd9d9;">
                                    <div>
                                       <li><%#Eval("User_Name")%></li>
                                    </div>                                  
                                    <br />                                 
                                    <span>
                                        <div><p>
                                            <a href="#">
                                                <%#Eval("User_Name") %>：
                                            </a>
                                            <%#Eval("Leavewords_Content") %> 
                                            </p>                                                                                  
                                        </div>
                                       <div><p style="text-align:right; float:right;"><%#Eval("Leavewords_Time") %></p></div>                                                                                                                       
                                    </span>
                                    <br />
                                    <div style="float:right;">
                                       <asp:LinkButton ID="lkbtnReply" runat="server" OnClick="lkbtnReply_Click" ValidationGroup="lkbtnReply">回复</asp:LinkButton></div>                                
                                    </div>
                                    <br />
                                    <asp:Panel ID="PanelReply" runat="server" Visible="false">
                                        <div class="reply_textbox">
                                            <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("Leavewords_ID") %>' Visible="false" />
                                            <asp:TextBox ID="txtReplyContent" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            <asp:LinkButton ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" class="btn btn-info" ValidationGroup="textReply" />
                                        </div>
                                        <div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" Font-Bold="true" Font-Size="14px" runat="server" ErrorMessage="回复内容不能为空" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationGroup="reply_comments"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="14px" ErrorMessage="字数不能超过140字" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationExpression="^[\s\S]{1,140}$" ValidationGroup="reply_comments"></asp:RegularExpressionValidator>
                                        </div>

                                    </asp:Panel>

                                </div>

                                <asp:Repeater ID="RepeaterReplyComments" runat="server">
                                    <ItemTemplate>
                                        <div class="reply">
                                            <div class="reply_contents">
                                                <span>
                                                    <a href="#">
                                                        <%#Eval("回复人")%>
                                                    </a>
                                                    回复
                                                    <a href="#">
                                                        <%#Eval("被回复人")%>
                                                    </a>：
                                                    <%#Eval("ReplyLeavewords_Comment") %>
                                                    <div style="float:right;">
                                                    <%#Eval("ReplyLeavewords_Time") %>
                                                    </div>
                                                </span>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </div>
                        </ItemTemplate>
                        </asp:ListView>
                        <div class="Pager">
                        <!--分页信息*/-->
                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="MessageListView" PageSize="5" OnPreRender="DataPager1_PreRender">
                            <Fields>
                                <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页"  ShowFirstPageButton="true" ShowNextPageButton="false" />
                                <asp:NumericPagerField  ButtonCount="4" />
                                <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false"  ShowLastPageButton="true" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                                </ContentTemplate>
                                    </asp:UpdatePanel>       
                            </div>

                                <hr />
                                <%-- 留言板结束--%>
    </div>
            </div>
</asp:Content>
