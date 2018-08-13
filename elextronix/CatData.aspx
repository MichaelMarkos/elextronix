<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CatData.aspx.cs" Inherits="Cat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="body_login" style="width:1000px;">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CatID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="CatID" HeaderText="CatID" ReadOnly="True" SortExpression="CatID" />
                <asp:BoundField DataField="CatName" HeaderText="CatName" SortExpression="CatName" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Market_WebConnectionString %>" DeleteCommand="DELETE FROM [Cat] WHERE [CatID] = @CatID" InsertCommand="INSERT INTO [Cat] ([CatName], [Notes]) VALUES (@CatName, @Notes)" SelectCommand="SELECT [CatID], [CatName], [Notes] FROM [Cat]" UpdateCommand="UPDATE [Cat] SET [CatName] = @CatName, [Notes] = @Notes WHERE [CatID] = @CatID">
            <DeleteParameters>
                <asp:Parameter Name="CatID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="CatNameTB" Name="CatName" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="NotesTB" Name="Notes" PropertyName="Text" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CatName" Type="String" />
                <asp:Parameter Name="Notes" Type="String" />
                <asp:Parameter Name="CatID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />


        <table>
            <tr>
                <td>Cat Name :</td>

                <td>
                    <asp:TextBox ID="CatNameTB" runat="server"></asp:TextBox></td>

            </tr>

            <tr>
                <td>Notes</td>

                <td>
                    <asp:TextBox ID="NotesTB" runat="server"></asp:TextBox></td>

            </tr>

            <tr>
                <td>
                    </td>

                <td><asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" /></td>

            </tr>

        </table>






    </div>

    </div>
    </form>
</body>
</html>
