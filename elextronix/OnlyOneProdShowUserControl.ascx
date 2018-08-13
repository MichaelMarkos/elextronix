<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OnlyOneProdShowUserControl.ascx.cs" Inherits="OnlyOneProdShowUserControl" %>
<table class="center">
    <tr>
        <th >
            <asp:Label ID="ProdNameLabel" runat="server" CssClass="contact_login_Center"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:Image ID="PhotoProd" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
               <asp:Label ID="Label1" runat="server" CssClass="contact_login_Center">Price :</asp:Label>
         <asp:Label ID="PriceLabel" runat="server" CssClass="contact_login_Center"></asp:Label>   
        &nbsp;EL</td>
    </tr>
    <tr>
        <td>
         <asp:Button ID="AddToCart" runat="server" Text="Add to cart" CssClass="onButton" style="margin-left:-10px;" OnClick="AddToCart_Click"/>   
        </td>
    </tr>
    <tr>
        <td>
               <asp:Label ID="Label2" runat="server" CssClass="contact_login_Center">Quantity :</asp:Label>
            <asp:Label ID="Quantity_Label" runat="server" Width="350" CssClass="contact_login_Center"></asp:Label>
        </td>
    </tr>
    
    <tr>
        <td>
            <asp:Label ID="DescLabel" runat="server" Width="350" CssClass="contact_login_Center"></asp:Label>
        </td>
    </tr>
    
    <tr>
        <td>
            <asp:Label ID="Notes_Label" runat="server" Width="350" CssClass="contact_login_Center"></asp:Label>
        </td>
    </tr>
    
</table>
