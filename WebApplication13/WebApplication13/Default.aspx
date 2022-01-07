<%@ Page Title="Home Page" Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication13._Default" %>


 <form id="form1" runat="server">
   
    <table>
        <tr>
            <td>
                 <asp:Label ID="lblInterviwer" runat="server" Text="Name of Student"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                 <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Label ID="lblContactNo" runat="server" Text="Contact No"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="txtxContactNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Label ID="lblEmail" runat="server" Text="Email Id"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button id="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
            </td>
            <td>
                 
                <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Text="HIB" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Passport" />
                 
                </td>
        </tr>
    </table>
   
   
     <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
   
   
    <br />
    <br />
</form>

