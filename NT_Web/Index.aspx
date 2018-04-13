<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NT_Web.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="col-md-4 col-sm-6">
                        <h3>文物宝鉴</h3>
                        <asp:ListView ID="ListView3" runat="server">
                            <LayoutTemplate>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                            </LayoutTemplate>
                            <ItemTemplate>
                                <p>
                                    <strong><a href='NewsDetail.aspx?id=<%#Eval("Cull_ID") %>' target="_blank"><%#Eval("Cull_Name") %></a></strong><br>
                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive" src='<%#Eval("Cull_Img") %>' />
                                </p>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
     <div class="col-md-4 col-sm-6">
                        <h3>前世今生</h3>
                        <asp:ListView ID="ListView2" runat="server">
                            <LayoutTemplate>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                            </LayoutTemplate>
                            <ItemTemplate>
                                <p>
                                    <strong><a href='NewsDetail.aspx?id=<%#Eval("News_ID") %>' target="_blank"><%#Eval("News_Title") %></a></strong>&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#String.Format("{0:yyyy-MM-dd hh:mm}",Eval("News_Time")) %>' ForeColor="gray"></asp:Label>
                                </p>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
    <div class="row">
        <h3>Acg</h3>
                <asp:ListView runat="server" ID="ListView1">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="col-xs-12 col-sm-4 col-md-4">
                            <div class="recent-work-wrap">
                                <asp:Image ID="Image1" runat="server" CssClass="img-responsive" src='<%#Eval("Pro_Img") %>' />
                                <div class="overlay">
                                    <div class="recent-work-inner">
                                        <h3><a href='VideoDetail.aspx?id=<%#Eval("Pro_ID") %>' target="_blank"><%#Eval("Pro_Title") %></a> </h3>
                                        <p><%#Eval("Cull_Name") %></p>
                                        <a class="preview" href='VideoDetail.aspx?id=<%#Eval("Pro_ID") %>'>观看</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
</asp:Content>
