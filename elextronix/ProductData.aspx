<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductData.aspx.cs" Inherits="ProductData" %>

<%@ Register Src="~/ProductUserControl.ascx" TagPrefix="uc1" TagName="ProductUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <table class="Center">
                <tr>
                 <td>
                     <asp:Button ID="NewPRod_BUt" runat="server" Text="New Prod" OnClick="NewPRod_BUt_Click" /></td>   
                    <td>
                        <asp:Button ID="EDitProd_But" runat="server" Text="Edit Product" OnClick="EDitProd_But_Click" /></td>
                    <td>
                        <asp:Button ID="RemoveProd_But" runat="server" Text="Remove Product" OnClick="RemoveProd_But_Click" /></td>
                 
                </tr>
            </table>
            <asp:MultiView ID="controls_view" runat="server">
                <asp:View ID="new_product_view" runat="server">
                <div>
                <uc1:ProductUserControl runat="server" ID="ProductUserControl" />
            </div>
                <br />
            <asp:Button ID="Button1" runat="server" Text="Save Data" OnClick="Button1_Click" />
                    </asp:View>
                <asp:View ID="remove_product_view" runat="server">

                    <table>
                        <tr>
                            <td>Choose One :</td>
                            <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ProdName" DataValueField="ProdID"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Market_WebConnectionString %>" SelectCommand="SELECT * FROM [Product]" DeleteCommand="DELETE FROM [Product] WHERE [ProdID] = @ProdID" InsertCommand="INSERT INTO [Product] ([ProdName], [CatID], [ImageURL], [Price], [Quantity], [ShortDesc], [LongDesc], [Notes]) VALUES (@ProdName, @CatID, @ImageURL, @Price, @Quantity, @ShortDesc, @LongDesc, @Notes)" UpdateCommand="UPDATE [Product] SET [ProdName] = @ProdName, [CatID] = @CatID, [ImageURL] = @ImageURL, [Price] = @Price, [Quantity] = @Quantity, [ShortDesc] = @ShortDesc, [LongDesc] = @LongDesc, [Notes] = @Notes WHERE [ProdID] = @ProdID">
                        <DeleteParameters>
                            <asp:Parameter Name="ProdID" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="ProdName" Type="String" />
                            <asp:Parameter Name="CatID" Type="Int32" />
                            <asp:Parameter Name="ImageURL" Type="String" />
                            <asp:Parameter Name="Price" Type="Decimal" />
                            <asp:Parameter Name="Quantity" Type="Int32" />
                            <asp:Parameter Name="ShortDesc" Type="String" />
                            <asp:Parameter Name="LongDesc" Type="String" />
                            <asp:Parameter Name="Notes" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="ProdName" Type="String" />
                            <asp:Parameter Name="CatID" Type="Int32" />
                            <asp:Parameter Name="ImageURL" Type="String" />
                            <asp:Parameter Name="Price" Type="Decimal" />
                            <asp:Parameter Name="Quantity" Type="Int32" />
                            <asp:Parameter Name="ShortDesc" Type="String" />
                            <asp:Parameter Name="LongDesc" Type="String" />
                            <asp:Parameter Name="Notes" Type="String" />
                            <asp:Parameter Name="ProdID" Type="Int32" />
                        </UpdateParameters>
                                </asp:SqlDataSource>
              </td>
                            <td>
                                <asp:Button ID="EnterID_But" runat="server" Text="Delete" OnClick="EnterID_But_Click" />
                            </td>
                            </tr>
                        <tr><td colspan="3"> 
                            <%--<asp:Panel ID="Delete_Panal" runat="server" Enabled="True" EnableViewState="True" Visible="false">
                                <table>
                                    <tr>
                                        <td>
                                            
                                            <asp:FormView ID="FormView1" runat="server" DataKeyNames="ProdID" DataSourceID="SqlDataSource1">
                                                <EditItemTemplate>
                                                    ProdID:
                                                    <asp:Label ID="ProdIDLabel1" runat="server" Text='<%# Eval("ProdID") %>' />
                                                    <br />
                                                    ProdName:
                                                    <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:TextBox ID="ImageURLTextBox" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:TextBox ID="ShortDescTextBox" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:TextBox ID="LongDescTextBox" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                                                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                                </EditItemTemplate>
                                                <InsertItemTemplate>
                                                    ProdName:
                                                    <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:TextBox ID="ImageURLTextBox" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:TextBox ID="ShortDescTextBox" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:TextBox ID="LongDescTextBox" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                                                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                                </InsertItemTemplate>
                                                <ItemTemplate>
                                                    ProdID:
                                                    <asp:Label ID="ProdIDLabel" runat="server" Text='<%# Eval("ProdID") %>' />
                                                    <br />
                                                    ProdName:
                                                    <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:Label ID="CatIDLabel" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:Label ID="ImageURLLabel" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:Label ID="ShortDescLabel" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:Label ID="LongDescLabel" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:Label ID="NotesLabel" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                                                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                                                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                                                </ItemTemplate>
                                            </asp:FormView>

                                        </td>

                                    </tr>
                                    


                                </table>

                                
                                
                                
                                
                                </asp:Panel>--%>
                            </td></tr >
                            <tr>
                                       <asp:Label ID="Result_Label" runat="server" Text="Label" cssclass="contact_login"></asp:Label> </tr>

                            
                             </table>
                         </asp:View>
              <%--  <asp:View ID="edit_product_view" runat="server">
               <asp:Panel ID="Delete_Panal" runat="server" Enabled="True" EnableViewState="True" Visible="false">
                                <table>
                                    <tr>
                                        <td>
                                            
                                            <asp:FormView ID="FormView1" runat="server" DataKeyNames="ProdID" DataSourceID="SqlDataSource1">
                                                <EditItemTemplate>
                                                    ProdID:
                                                    <asp:Label ID="ProdIDLabel1" runat="server" Text='<%# Eval("ProdID") %>' />
                                                    <br />
                                                    ProdName:
                                                    <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:TextBox ID="ImageURLTextBox" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:TextBox ID="ShortDescTextBox" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:TextBox ID="LongDescTextBox" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                                                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                                </EditItemTemplate>
                                                <InsertItemTemplate>
                                                    ProdName:
                                                    <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:TextBox ID="ImageURLTextBox" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:TextBox ID="ShortDescTextBox" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:TextBox ID="LongDescTextBox" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:TextBox ID="NotesTextBox" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                                                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                                </InsertItemTemplate>
                                                <ItemTemplate>
                                                    ProdID:
                                                    <asp:Label ID="ProdIDLabel" runat="server" Text='<%# Eval("ProdID") %>' />
                                                    <br />
                                                    ProdName:
                                                    <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Bind("ProdName") %>' />
                                                    <br />
                                                    CatID:
                                                    <asp:Label ID="CatIDLabel" runat="server" Text='<%# Bind("CatID") %>' />
                                                    <br />
                                                    ImageURL:
                                                    <asp:Label ID="ImageURLLabel" runat="server" Text='<%# Bind("ImageURL") %>' />
                                                    <br />
                                                    Price:
                                                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                                                    <br />
                                                    Quantity:
                                                    <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                                                    <br />
                                                    ShortDesc:
                                                    <asp:Label ID="ShortDescLabel" runat="server" Text='<%# Bind("ShortDesc") %>' />
                                                    <br />
                                                    LongDesc:
                                                    <asp:Label ID="LongDescLabel" runat="server" Text='<%# Bind("LongDesc") %>' />
                                                    <br />
                                                    Notes:
                                                    <asp:Label ID="NotesLabel" runat="server" Text='<%# Bind("Notes") %>' />
                                                    <br />
                                                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                                                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                                                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                                                </ItemTemplate>
                                            </asp:FormView>

                                        </td>

                                    </tr>
                                    


                                </table>

                                
                                
                                
                                
                                </asp:Panel>
                     </asp:View>

              --%>
                
                
                
                
                
                <%--       <asp:View ID="edit_product_view" runat="server">
                    <table>
                        <tr>
                            <td><p>
                                        Enter product name:</p>
                            </td>
                            <td>
                                <asp:TextBox ID="edit_by_name_TB" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EDIT_TXTBOX_ID_RFV" runat="server" ControlToValidate="edit_by_name_TB" Display="Dynamic" ErrorMessage="Enetr ID of product" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                            </td>
                            <td>
                                <asp:RangeValidator ID="RV_EDIT_TB_NAME" runat="server" ControlToValidate="edit_by_name_TB" Display="Dynamic" ErrorMessage="Erroe Value" ForeColor="Red">*</asp:RangeValidator>
                                <asp:Button ID="Edit_Ok_BUT" runat="server" Text="OK." CssClass="onButton" OnClick="Edit_Ok_BUT_Click" />
                            </td>
                        </tr>
                        <tr>
                            <asp:Panel ID="edit_Product_info_panal" runat="server" Visible="False">
                            <td colspan="3"><p>
This your pruduct:</p>
                                <uc1:products runat="server" ID="products1" />
                            </td></asp:Panel>
                        </tr>
                         </table>
                    <asp:Panel ID="edit_controls_panal" runat="server" DefaultButton="okBUT" Visible="False">
                        <table>
                        <tr>
                            <td><p>
product name:</p></td>
                            <td>
                                <asp:TextBox ID="edit_nameTB" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><p>
product photo:</p></td>
                            <td>
                                <asp:FileUpload ID="edit_uplodePhoto" runat="server" /></td>
                        </tr>
                        <tr>
                            <td><p>
Price:</p></td>
                            <td>
                                <asp:TextBox ID="edit_priceTB" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><p>
some info about prouduct:</p></td>
                            <td>
                                <asp:TextBox ID="edit_infoTB" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><p>
discribtion:</p></td>
                            <td>
                                <asp:TextBox ID="edit_discTB" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="okBUT" runat="server" Text="Ok." CssClass="onButton" OnClick="Ok_Edit_BUT_Click"/></td>
                            <td>
                                <asp:Button ID="edit_Canel_Edit_BUT" runat="server" Text="cancel" CssClass="onButton" /></td>
                        </tr>
                        </table>
                    </asp:Panel>

                   
                </asp:View>--%>


            </asp:MultiView>
            
            
            
            
            
            
            
            
            
            
            
            
             

            <br />

            
        </div>
    </form>
</body>
</html>
