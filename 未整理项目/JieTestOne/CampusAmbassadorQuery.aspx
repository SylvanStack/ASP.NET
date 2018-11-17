<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.master" AutoEventWireup="true" CodeFile="CampusAmbassadorQuery.aspx.cs" Inherits="User_CampusAmbassadorQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="center_table width_960 reg_bgc">
        <asp:UpdatePanel ID="upOne" runat="server">
            <ContentTemplate>
                <table class="border_dashed center_table">
                    <tr>
                        <td class="search_table">
                            <asp:TextBox runat="server" ID="tbSearch" Width="650" Height="50" AutoCompleteType="Search"></asp:TextBox>
                            <asp:Button runat="server" ID="btnSel" Text="查  询" Width="60" Height="55" OnClick="btnSel_Click" />
                            <asp:Button runat="server" ID="btnClear" Text="清  空" Width="60" Height="55" OnClick="btnClear_Click" />
                            <asp:Button runat="server" ID="btnSelToGV" Text="显示全部" Width="90" Height="55" OnClick="btnSelToGV_Click" /><br />
                            <label>查询结果：</label>
                            <asp:Label runat="server" ID="selResult"></asp:Label>
                            <asp:GridView runat="server" ID="gvSearch" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:BoundField DataField="ID" HeaderText="编号" />
                                    <asp:BoundField DataField="userName" HeaderText="用户名" />
                                    <asp:BoundField DataField="userSex" HeaderText="性别" />
                                    <asp:BoundField DataField="userBorn" HeaderText="出生日期" />
                                    <asp:BoundField DataField="userPhone" HeaderText="电话" />
                                    <asp:BoundField DataField="userMail" HeaderText="邮箱" />
                                    <asp:BoundField DataField="userQQ" HeaderText="QQ" />
                                    <asp:BoundField DataField="create_date" HeaderText="注册时间" />                                    
                                    <asp:TemplateField HeaderText="操作">
                                        <ItemTemplate>
                                            <asp:HyperLink runat="server" ID="loginUser" Text='<%#Convert.ToString(Eval("userName")) %>' ToolTip='<%#Convert.ToString(Eval("userName")) %>' NavigateUrl='<%#Eval("ID","#?ID={0}") %>'></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

