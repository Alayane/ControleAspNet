<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceConsumation.aspx.cs" Inherits="ControleAspNet.WebServiceConsumation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 138px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Categorie Id</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRecherche" runat="server" Text="Recherche" OnClick="btnRecherche_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

    </form>
</body>
</html>
