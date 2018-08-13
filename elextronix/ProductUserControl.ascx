<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductUserControl.ascx.cs" Inherits="ProductUserControl" %>

<table>
    <tr>
        <td>  
<asp:Label ID="Label1" runat="server" Text="" CssClass="contact_login"><strong>Select Category :</strong></asp:Label>

        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CatName" DataValueField="CatID"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Market_WebConnectionString %>" SelectCommand="SELECT [CatID], [CatName] FROM [Cat]"></asp:SqlDataSource>
        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label2" runat="server" Text="" CssClass="contact_login"><strong>Product Name :</strong></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="ProdNameTB" runat="server"></asp:TextBox>
        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label3" runat="server" Text="" CssClass="contact_login"><strong>Image :</strong></asp:Label>

        </td>
        <td>
    <asp:FileUpload ID="FileUpload1" runat="server" />

        </td>
        <td>
                <asp:Image ID="Image1" runat="server" />

        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label4" runat="server" Text="" CssClass="contact_login"><strong>Price :</strong></asp:Label>

        </td>
        <td>
    <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>

        </td>
    </tr>

    <tr>
        <td>  
<asp:Label ID="Label5" runat="server" Text="" CssClass="contact_login"><strong>Quantity :</strong></asp:Label>

        </td>
        <td>
    <asp:TextBox ID="QuantityTB" runat="server"></asp:TextBox>

        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label6" runat="server" Text="" CssClass="contact_login"><strong>Short Desc :</strong></asp:Label>

        </td>
        <td>
    <asp:TextBox ID="ShortDEscTB" runat="server"></asp:TextBox>

        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label7" runat="server" Text="" CssClass="contact_login"><strong>Long Desc :</strong></asp:Label>

        </td>
        <td>
                <asp:TextBox ID="LongDEscTB" runat="server"></asp:TextBox>

        </td>
    </tr>


    <tr>
        <td>  
<asp:Label ID="Label8" runat="server" Text="" CssClass="contact_login"><strong>Notes :</strong></asp:Label>

        </td>
        <td>
                <asp:TextBox ID="NotesTB" runat="server"></asp:TextBox>

        </td>
    </tr>


   </table>
