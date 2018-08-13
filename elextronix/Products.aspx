<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<%@ Reference Control="~/Show_productUserControl.ascx" %>





<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div class="center_title_bar">Latest Products</div>
    <div class="center_content">

         <asp:Table ID="Table1" runat="server"></asp:Table>
   </div>
    








</asp:Content>

