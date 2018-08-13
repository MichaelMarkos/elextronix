<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Show_productUserControl.ascx.cs" Inherits="Show_productUserControl" %>




<div class="prod_box">
    <div class="center_prod_box">
        <div class="product_title">
        <strong>    <a href="details.html">
                <asp:Label ID="Name_Prod" runat="server" Text="" CssClass="contact_login_Center"></asp:Label></a></strong>
        </div>

        <div class="product_img">
            <asp:Image ID="Image_Prod" runat="server" Width="173px" Height="104px" />
        </div>
        
            <span class="contact_login_Center">
                <asp:Label ID="Price_Prod" runat="server" Text=""></asp:Label></span> <%--<span class="price">----</span></div>--%>
            <div class="bottom_prod_box"></div>


            <div class="prod_details_tab">

                <table>
                    <tr>
                        <td>
                            <asp:Button ID="ADDTOCart"  runat="server" Text="Add To Cart" CssClass="register" OnClick="ADDTOCart_Click1" />             
                            </td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/cart.gif" OnClick="ImageButton1_Click"  />
                        </td>
                        <td>
                            <asp:Button ID="Details_But" runat="server" Text="Details" CssClass="register" OnClick="Button1_Click1" />
                        </td>
                    </tr>
                </table>
            </div>

        </div>
    
</div>
