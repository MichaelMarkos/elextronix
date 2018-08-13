<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MY_Cart.aspx.cs" Inherits="MY_Cart" %>

<%@ Reference Control="~/MyCartUserControl.ascx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function NOneRigUser() {
            window.alert("Please Sign in First");
        }
    </script>
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="text-align: center;">
        <table class="Center" style="width: 1000px;">
            <tr>
                <th colspan="3">
                    <div style="text-align: center;">
                        <asp:Label ID="Label6" runat="server" Text="" CssClass="contact_login_Center"><h1><strong> Your Bill</strong></h1></asp:Label>
                    </div>
                </th>
            </tr>
            <tr>
                <td style="text-align: center; margin-left:25px; ">

                    <asp:Label ID="Label1" runat="server" Text="" CssClass="contact_login_Center"><strong>Product Name</strong></asp:Label>

                </td>

                <td style="text-align: center;">

                    <asp:Label ID="Label2" runat="server" Text="" CssClass="contact_login_Center"><strong>Price</strong></asp:Label>

                </td>

                <td style="text-align: center;">

                    <asp:Label ID="Label3" runat="server" Text="" CssClass="contact_login_Center"><strong>Quantity</strong></asp:Label>

                </td>

                <td style="text-align: center;">

                    <asp:Label ID="Label4" runat="server" Text="" CssClass="contact_login_Center"><strong>Edit</strong></asp:Label>

                </td>

                <td style="text-align: center;">
                    <asp:Label ID="Label7" runat="server" Text="" CssClass="contact_login_Center"><strong>Remove</strong></asp:Label>
                </td>

                <td style="text-align: center;">
                    <asp:Label ID="Label5" runat="server" Text="" CssClass="contact_login_Center"><strong>Total Price</strong></asp:Label>

                </td>
            </tr>


            <tr class="Center" style="text-align: center;">
                <td colspan="6">
                    <asp:PlaceHolder ID="ViewBayerProduct" runat="server"></asp:PlaceHolder>
                    <br />
                    <br />
                    <br />
                <div style="text-align: center;">
                      <h1><strong>  <asp:Label ID="MsgLab" runat="server" Text="" CssClass="contact_login_Center"> </asp:Label></strong></h1>
                    </div>
                    <div style="text-align: center;">
                        <p>&nbsp;</p>
                    </div>
                    <div style="text-align: center;">
                        <p>&nbsp;</p>
                    </div>
                </td>
            </tr>

            <tr class="Center" style="text-align: center;">
                <td colspan="6">
                    <div style="vertical-align: top; text-align: center;" class="contact_login_Center">
                        <asp:Literal ID="SumOfBill_Lit" runat="server" Text="Total Of Bill :"></asp:Literal>LE
                    </div>
                </td>
            </tr>



            <tr class="Center" style="text-align: center;">
                <td colspan="6">


                    <table class="Center" style="width: 1000px;">
                        <tr class="Center" style="text-align: center;">
                            <td style="text-align: center;">
                                <asp:Button ID="PaycartAndEnd_BUT" runat="server" Text="Pay Cart & End Shopping" OnClick="PaycartAndEnd_BUT_Click" CssClass="register_MYCart" />
                            </td>
                            <td style="text-align: center;">
                                <asp:Button ID="BackProducts_But" runat="server" Text="Back To Continue Shopping" OnClick="BackProducts_But_Click" CssClass="register_MYCart" /></td>
                        </tr>
                    </table>


                </td>

              </tr>
        </table>
    </div>

</asp:Content>

