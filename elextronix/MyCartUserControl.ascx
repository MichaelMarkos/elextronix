<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyCartUserControl.ascx.cs" Inherits="MyCartUserControl" %>
<div style="text-align:center;">
    <table class="center" style="width: 1000px;">
        
        
        
        
        <tr>
            <td style="text-align: center; ">
           <strong>      <asp:Label ID="Label_ProductName" runat="server" Text="" cssclass="contact_login_Center"></asp:Label> </strong>

            </td>
            <td style="text-align: center; width:150px;">
           <strong>         <asp:Label ID="Label_Price" runat="server" Text="" cssclass="contact_login_Center"></asp:Label></strong>
            </td>
            <td style="text-align: center;width:160px;">
                    <asp:TextBox ID="QuantityProdTB" runat="server" >1</asp:TextBox>
            </td>
            <td style="text-align:center; width:90px;">
                                <div style="float:right;" class="form_rowl">

                    <asp:Button ID="EditQuantity_But" runat="server" Text="Edit Quantity" OnClick="EditQuantity_But_Click" cssclass="register_CartbuPLaceHold"/>
</div>
            </td>
            <td style="text-align:left;width:90px;">
                <div style="float:left;" class="form_rowl">
                    <asp:Button ID="Remove_But" runat="server" Text="Remove" OnClick="Remove_But_Click" cssclass="register_CartbuPLaceHold" /></div>
            </td >
            <td style="text-align: center;width:100px;">
                
                    <asp:Label ID="Label_TotalPrice" runat="server" Text="" cssclass="contact_login_Center"></asp:Label>
            </td >
        </tr>
    </table>
</div>
