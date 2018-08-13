<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="content1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <%--<div class="Contact_content" >
        <div class="Center_title_bar">Contact Us        </div>
    

    
    </div>--%>

    <div class="center_content">
        <div class="center_title_bar">Contact Us</div>
        <div class="prod_box_big">
            <div class="top_prod_box_big"></div>
            <div class="center_prod_box_big">

                <div class="contact_form">






                    <table class="Center">

                        <tr>
                            <td>

                                <div class="form_row">
                                    <label class="contact"><strong>Name:</strong></label>
                                </div>
                            </td>


                            <td>
                                <div class="form_row">
                                    <asp:TextBox ID="Name_coTB" CssClass="contact_TextBoox" runat="server" TextMode="SingleLine"></asp:TextBox>
                                </div>
                            </td>

                        </tr>

                        <tr>
                            <td>
                                <div class="form_row">
                                    <label class="contact"><strong>Email:</strong></label>
                                </div>
                            </td>
                            <td>
                                <div class="form_row">
                                    <asp:TextBox ID="Email_conTB" CssClass="contact_TextBoox" runat="server" TextMode="Email"></asp:TextBox>

                                </div>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <div class="form_row">
                                    <label class="contact"><strong>Phone:</strong></label>
                                </div>
                            </td>
                            <td>
                                <div class="form_row">
                                    <asp:TextBox runat="server" ID="Phon_conTB" TextMode="Phone" CssClass="contact_TextBoox"></asp:TextBox>
                                </div>
                            </td>
                        </tr>


                        <tr>
                            <td>
                                <div class="form_row">
                                    <label class="contact"><strong>Company:</strong></label>

                                </div>
                            </td>
                            <td>
                                <div class="form_row">
                                    <asp:TextBox ID="Company_conTB" runat="server" CssClass="contact_TextBoox"></asp:TextBox>
                                </div>
                            </td>
                        </tr>


                        <tr>
                            <td>
                                <div class="form_row">
                                    <label class="contact"><strong>Message:</strong></label>
                                </div>
                            </td>
                            <td>
                                <div class="form_row">
                                    <asp:TextBox ID="Messege_ConTB" runat="server" TextMode="MultiLine" CssClass="Contact_Textbox_Messege"></asp:TextBox>

                                </div>

                            </td>
                        </tr>

                        
                    </table>
                    <div class="form_row"><a href="http://www.google.com" class="contact">send</a> </div>

                </div>


            </div>
            <div class="bottom_prod_box_big"></div>
        </div>
    </div>
    <!-- end of center content -->



    


</asp:Content>

