<%@ Control Language="C#" AutoEventWireup="true" CodeFile="_signWebUserControl.ascx.cs" Inherits="WebUserControl" %>


<style type="text/css">
    .auto-style1 {
        width: 113px;
    }
</style>


<div style="text-align: center;">
    <table class="Center">
        <tr>
            <td class="auto-style1">
                <strong>
                    <asp:Label ID="Label2" runat="server" Text="    Name :   " CssClass="contact_login"></asp:Label></strong>

            </td>
            <td>
                <asp:TextBox ID="NameTB" runat="server" CssClass="contact_input"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTB" Display="Dynamic" ErrorMessage="Enter Your Name" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <strong>
                    <asp:Label ID="Label1" runat="server" Text="  E-Mail :   " CssClass="contact_login"></asp:Label></strong>

            </td>
            <td>

                <asp:TextBox ID="EmailTB" runat="server" CssClass="contact_input"></asp:TextBox>

                &nbsp;
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailTB" Display="Dynamic" ErrorMessage="Enter Your Email" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTB" Display="Dynamic" ErrorMessage="EMail Is Wrong" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <strong>
                    <asp:Label ID="Label3" runat="server" Text="    Age :  " CssClass="contact_login"></asp:Label>
                </strong>


            </td>
            <td>
                <asp:TextBox ID="AgeTB" runat="server" CssClass="contact_input"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="AgeTB" Display="Dynamic" ErrorMessage="Enter your Age" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="AgeTB" Display="Dynamic" ErrorMessage="your age must be from 16 to 60" ForeColor="Red" MaximumValue="60" MinimumValue="16" Type="Integer">*</asp:RangeValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">


                <strong>
                    <asp:Label ID="Label4" runat="server" Text="Address :   " CssClass="contact_login"></asp:Label></strong>


            </td>
            <td>
                <asp:TextBox ID="AddressTB" runat="server" Height="81px" TextMode="MultiLine" Width="161px" CssClass="contact_input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">

                <strong>
                    <asp:Label ID="Label5" runat="server" Text="Password :" CssClass="contact_login">   </asp:Label></strong>


            </td>
            <td>
                <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password" CssClass="contact_input"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PasswordTB" Display="Dynamic" ErrorMessage="Enter Your Password" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <strong>
                    <asp:Label ID="Label6" runat="server" Text="Re-Password :  " CssClass="contact_login"></asp:Label></strong>


            </td>
            <td>
                <asp:TextBox ID="REPasswordTB" runat="server" TextMode="Password" CssClass="contact_input"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="PasswordTB" Display="Dynamic" ErrorMessage="Retype Your Password" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTB" ControlToValidate="REPasswordTB" Display="Dynamic" ErrorMessage="Password Is Wrong" ForeColor="Red">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">

                <strong>
                    <asp:Label ID="Label7" runat="server" Text=" Gender :    " CssClass="contact_login"></asp:Label></strong>





            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>FeMale</asp:ListItem>
                </asp:RadioButtonList></td>





        </tr>

        <tr>
            <td colspan="2">

                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</div>

