<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" smartNavigation="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="center_table width_960">
        <table class="border_dashed">
            <tr>
                <td class="td">
                    <div class="imageRotation">
                        <div class="imageBox">
                            <img src="theme/images/HomePage/model.jpg" />
                            <img src="theme/images/HomePage/model2.jpg" />
                            <img src="theme/images/HomePage/model3.jpg" />
                            <img src="theme/images/HomePage/model4.jpg" />                            
                        </div><div class="icoBox">
                                <span class="active" rel="model">1</span>
                                <span rel="model2">2</span>
                                <span rel="model3">3</span>
                                <span rel="model4">4</span>
                            </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="border_dashed navigation">
                    <asp:LinkButton runat="server" CssClass="no_underline" ForeColor="White">招募背景</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="font_numt">
                    <p class="font_num">
                        为了打造中国最优质的技术服务，满足不同层次用户的需求，联想做出了新的战略规划，推出了联想服务校园行团队计划，让联想的技术、文化、信息深入校园。我们通过设立联想校园直属学生团队，为全国各地大学生提供一个学习计算机技术、提升综合素质的平台，也让同学们在此交流碰撞产生思想的火花。
                    </p>
                    <p class="font_num">
                        每天早9点到晚9点期间，都有经验丰富的工程师老师在线提供技术支持，细心讲解，帮助校园大使积累知识；同时，联想提供内部产品及技术视频课程，助力校园大使更快更全面地了解联想；另外，每月以学校为单位，为校园大使安排当地任意联想服务站实习机会，理论与实践相结合，深化计算机技术学习。 
                    </p>
                </td>
            </tr>
            <tr>
                <td class="border_dashed navigation">
                    <asp:LinkButton runat="server" CssClass="no_underline" ForeColor="White">校园大使职责与目的</asp:LinkButton>
                </td>
            </tr>
            <tr class="font_numt">
                <td>
                    <div class="border_dashed font_numt">
                        <table class="border_dashed width_100">
                            <tr>
                                <td class="width_50">
                                    <ul class="font_numt">
                                        <li class="font_numtt">职责：</li>
                                    </ul>
                                </td>
                                <td class="width_50">
                                    <ul class="font_numt">
                                        <li class="font_numtt">目的：</li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <td class="width_50">
                                    <ul class="font_numt">
                                        <li>(1)官方网站的管理及技术学习</li>
                                        <li>(2)产品、网站的推广</li>
                                        <li>(3)产品体验及反馈</li>
                                        <br />
                                        <br />
                                    </ul>
                                </td>
                                <td class="width_50">
                                    <ul class="font_numt">
                                        <li>(1)让联想文化、计算机技术在校园传播，让更多的人了解联想</li>
                                        <li>(2)为校园提供计算机技术支持，解决校园计算机难题，让校园处处充满联想的温暖</li>
                                        <li>(3)建立联想校园站，宣传联想的服务</li>
                                        <li>(4)拓宽人才培养渠道，助力联想人才引进</li>
                                    </ul>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="border_dashed navigation">
                    <asp:LinkButton runat="server" CssClass="no_underline" ForeColor="White">校园大使优势</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="font_numt">
                    <ul class="font_numt">
                        <li>（1）联想校园大使证书。
                        </li>
                        <li>（2）优先面试权，实习、全职机会；优秀的校园大使可免试。
                        </li>
                        <li>（3）表现优异者奖励联想电子产品。
                        </li>
                        <li>（4）可提供联想内购活动。
                        </li>
                        <li>（5）联想内部视频语音课程、培训资料提供学习。
                        </li>
                        <li>（6）联想服务官网个人展示及信息查询。
                        </li>
                        <li>（7）杰出的校园大使暑假到北京总部聚会旅游，30人/年。
                        </li>
                        <li class="font_num">这是一个属于同学们的舞台，这是一个群聚全国各地大学生的团队，你可以专业不对口，也可以没技术基础，只要你有足够的兴趣和责任心，就有机会加入联想大家庭。心动不如行动，我们期待你的加入！
                        </li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="border_dashed navigation">
                    <asp:LinkButton runat="server" CssClass="no_underline" ForeColor="White">校园大使的专属福利</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="font_numt">
                    <ul class="font_numt">
                        <li>（1）官方资质：联想官方资质认证及联想校园大使官网展示
                        </li>
                        <li>（2）优先机会：优先面试、实习、就业机会
                        </li>
                        <li>（3）专人指导：与联想工程师线上一对一沟通交流、学习
                        </li>
                        <li>（4）精英人脉：有机会与行业内精英学习交流
                        </li>
                        <li>（5）实习就业：联想当地服务站实习
                        </li>
                        <li>（6）优惠特权：联想新产品试用及电子产品奖励、联想产品内购机会
                        </li>
                        <li>（7）沟通平台：联想将构筑在线论坛、QQ群提供实时交流沟通平台
                        </li>
                    </ul>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

