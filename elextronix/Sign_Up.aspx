<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sign_Up.aspx.cs" Inherits="Sign_Up" %>

<%@ Register Src="~/_signWebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>
<%@ Register Src="~/_signWebUserControl.ascx" TagPrefix="uc1" TagName="_signWebUserControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="body_login" >
 <div class="title" style="vertical-align:top;">
                                <span class="title_icon">
                                    <img src="images/checked.png" alt="" /></span>Sign Up
                            </div>
        
        <br />
        <br />
         <br />
        <br />
        <br />
        <br />
        <br />
        <table class="Center" style="vertical-align:bottom;" >
                    <tr>
                        <td>
                            


                            <div style="text-align:center;">
                                <table class="Center" >

                                    <tr>

                                        <td>
                                            <uc1:_signWebUserControl runat="server" ID="_signWebUserControl" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2">

                                            
                                        <div class="form_rowl">
                                                <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" class="register" />
                                            </div></td>

                                    </tr>
                                </table>
                            </div>

                        </td>


                    </tr>
                
        </table>


    </div>





</asp:Content>

