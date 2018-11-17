<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.master" AutoEventWireup="true" CodeFile="Registered.aspx.cs" Inherits="User_Registered" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="../theme/js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <div class="center_table width_960 reg_bgc">
        <asp:UpdatePanel ID="userNine" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <table class="border_dashed reg_table text_right text_line">
                    <tr>
                        <td>
                            <label>用户名：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userOne" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="userName" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" AutoPostBack="True" OnTextChanged="userName_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ErrorMessage="*请填写用户名" ForeColor="Red" ControlToValidate="userName"></asp:RequiredFieldValidator>
                                    <asp:Label runat="server" ID="lbUserNameMsg" Visible="false"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>性&nbsp;别：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userTwo" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="男" AutoPostBack="True" OnCheckedChanged="RadioButton_CheckedChanged" />
                                    <asp:RadioButton ID="rbFeMale" runat="server" GroupName="Gender" Text="女" AutoPostBack="True" OnCheckedChanged="RadioButton_CheckedChanged" />
                                    <asp:Label runat="server" ID="lbUserSexMsg" Visible="false"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>出生日期：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userThree" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="tbBorn" Width="200px" CssClass="txt_style" OnTextChanged="tbBorn_TextChanged" OnClick="WdatePicker()" AutoCompleteType="Disabled" AutoPostBack="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTbBorn" runat="server" ErrorMessage="*请填写出生日期" ForeColor="Red" ControlToValidate="tbBorn"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lbDateMsg" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>电&nbsp;话：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userFour" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="tbPhone" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" AutoPostBack="true" OnTextChanged="tbPhone_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTbPhone" runat="server" ErrorMessage="*请填写电话号码" ForeColor="Red" ControlToValidate="tbPhone"></asp:RequiredFieldValidator>
                                    <asp:Label runat="server" ID="lbTbPhoneMsg" Visible="false"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>邮&nbsp;箱：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userFive" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="tbMail" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" AutoPostBack="True" OnTextChanged="tbMail_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTbMail" runat="server" ErrorMessage="*请填写邮箱号" ForeColor="Red" ControlToValidate="tbMail"></asp:RequiredFieldValidator>
                                    <asp:Label runat="server" ID="lbTbMailMsg" Visible="false"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Q&nbsp;Q：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userSix" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="tbTencent" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" AutoPostBack="True" OnTextChanged="tbTencent_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTbTencent" runat="server" ErrorMessage="*请填写QQ号码" ForeColor="Red" ControlToValidate="tbTencent"></asp:RequiredFieldValidator>
                                    <asp:Label runat="server" ID="lbTbTencentMsg" Visible="false"></asp:Label>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>密&nbsp;码：</label></td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userSeven" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="userPassWord" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" TextMode="Password" AutoPostBack="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvUserPassWord" runat="server" ErrorMessage="*请输入密码" ForeColor="Red" ControlToValidate="userPassWord" Display="Dynamic"></asp:RequiredFieldValidator>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>确认密码：</label>
                        </td>
                        <td class="text_left">
                            <asp:UpdatePanel ID="userEight" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox runat="server" ID="conPassWord" Width="200px" AutoCompleteType="Disabled" CssClass="txt_style" TextMode="Password" AutoPostBack="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvConPassWord" runat="server" ErrorMessage="*请输入确认密码" ForeColor="Red" ControlToValidate="conPassWord" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*两次密码输入不一致" ForeColor="Red" ControlToValidate="conPassWord" ControlToCompare="userPassWord"></asp:CompareValidator>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat="server" ID="btnReg" Text="提  交" OnClick="btnReg_Click" />&nbsp;
                        </td>
                        <td class="btnClear">
                            <asp:Button runat="server" ID="btnClear" Text="清  空" OnClick="btnClear_Click" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="btnReg" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>

