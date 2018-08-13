<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="My_account.aspx.cs" Inherits="My_account" %>

<%@ Register Src="~/_signWebUserControl.ascx" TagPrefix="uc1" TagName="_signWebUserControl" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <link href="Style.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <%--    <div class="body_login" style="text-align: center;">

        

        <div class="title">
            <span class="title_icon">
                <img src="images/checked.png" alt="" /></span>Updat MY account
        </div>


        <table class="Center">
            <tr>

                <td>
                    <uc1:_signWebUserControl runat="server" ID="_signWebUserControl" />
                </td>
            </tr>
        </table>

        <div class="form_rowl">
            <asp:Button ID="Button1" runat="server" Text="Updat" OnClick="Button1_Click" class="register" />
        </div>
        <div class="contact_login">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    --%>






    <div class="body_login" style="text-align: center;">

        <table>
            <tr>

                <td>
                    <div class="title">
                        <span class="title_icon">
                            <img src="images/checked.png" alt="" /></span>Updat MY account
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div style="text-align: center;">
                        <table class="Center">

                            <tr>

                                <td>
                                 
                                                        <uc1:_signWebUserControl runat="server" ID="_signWebUserControl" />



                                </td>
                            </tr>

                            <tr>
                                <td colspan="2"></td>
                                <td>
                                    <div class="form_rowl">

                                        <asp:Button ID="Button2" runat="server" Text="Updat" OnClick="Button1_Click" class="register" />

                                    </div>
                                    <div class="contact_login">
                                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>

                </td>


            </tr>

        </table>


    </div>











</asp:Content>

