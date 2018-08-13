<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="OneProduct.aspx.cs" Inherits="OneProduct" %>
<%@ Reference Control="~/OnlyOneProdShowUserControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
    <asp:PlaceHolder ID="ShowOnlyProdPleaseHolder" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>

