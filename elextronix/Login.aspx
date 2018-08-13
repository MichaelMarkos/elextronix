<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 422px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">








    <div class="body_login">

        <div class="title">
            <span class="title_icon">
                <img src="images/checked.png" alt="" /></span>My account
        </div>
        <%--     <div style="text-align:center">
            <table class="Center">
                <tr>

                    <td>
                      <div class="form_row">  <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label></div>
                    </td>
                    <td>

                        <asp:TextBox ID="TextBox1" runat="server" CssClass="contact_TextBoox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                      <div class="form_row">  <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></div></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="contact_TextBoox"></asp:TextBox>
                    </td>

                </tr>
                
                <tr>
                    <td>

                    <asp:CheckBox ID="Remember_checkbox" runat="server" Text="Remmember me" />
                        </td>
                </tr>
                <tr><td>
                    <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" /></td></tr>
                <tr><td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>

            </table>
        </div>--%>





        <table>


            <tr>

                <td class="auto-style1">
                    <div class="contact_forms">
                        <div class="form_subtitle">login into your account</div>




                        <table>


                            <tr>

                                <td>

                                    <div>
                                        <asp:Label ID="Label1" runat="server" Text="" cssclass="contact_login"><strong>Username:</strong></asp:Label>
                                    </div>
                                </td>
                                <td>
                                    <div class="form_rowl">
                                        <asp:TextBox ID="UsernameLogTB" runat="server" cssclass="contact_input"></asp:TextBox>
                                    </div>

                                </td>


                            </tr>


                            <tr>

                                <td>
                                    <div>
                                        <asp:Label ID="Label2" runat="server" Text="Label" cssclass="contact_login"><strong>Password:</strong></asp:Label>
                                    </div>
                                </td>

                                <td>
                                    <div class="form_rowl">
                                        <asp:TextBox ID="PaSSwordLogTB" runat="server" cssclass="contact_input" TextMode="Password"></asp:TextBox>
                                    </div>

                                </td>

                            </tr>
                       
<tr>
    <td colspan="2">
                       
                            <asp:CheckBox ID="Remember_checkbox" runat="server" Text="Remmember me" />
   </td> </tr>
                         </table>


                        <div class="form_rowl">
                            <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" cssclass="register" />
                        </div>
                        <div class="contact_login_Center;">
       <strong>                     <asp:Label ID="Wrong_login" runat="server" Text="" ></asp:Label></strong>

                        </div>


                    </div>





                </td>


                <td>
                    <img src="Images/logoooooo.png" />

                </td>

            </tr>

        </table>

    </div>
  
    <div class="clear"></div>

    <!--end of left content-->







































    <%--     <div style="text-align:center">
            <table class="Center">
                <tr>

                    <td>
                      <div class="form_row">  <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label></div>
                    </td>
                    <td>

                        <asp:TextBox ID="TextBox1" runat="server" CssClass="contact_TextBoox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                      <div class="form_row">  <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></div></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="contact_TextBoox"></asp:TextBox>
                    </td>

                </tr>
                
                <tr>
                    <td>

                    <asp:CheckBox ID="Remember_checkbox" runat="server" Text="Remmember me" />
                        </td>
                </tr>
                <tr><td>
                    <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" /></td></tr>
                <tr><td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>

            </table>
        </div>--%>
</asp:Content>

