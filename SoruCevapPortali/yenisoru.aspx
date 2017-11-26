<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="yenisoru.aspx.vb" Inherits="SoruCevapPortali.yenisoru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Forum Sistemi</title>
    <style type="text/css">

        .style2
        {
         height: 97px;
        }
        .style3
        {
        height: 24px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="600" border="1" cellpadding="0" cellspacing="0" bordercolor="#CCCCCC">
        <tr>
            <td class="style3">
                <asp:Label ID="lblsoru" runat="server" Text="Sorular :"></asp:Label>
                </td>
            <td class="style3">
                <asp:TextBox ID="txtsoru" runat="server" Width="387px"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblaciklama" runat="server" Text="Sorunuz ile ilgili kısa bir açıklama yazınız :"></asp:Label>
                </td>
            <td class="style2">
                <asp:TextBox ID="txtaciklama" runat="server" Columns="5" Height="83px"
                    TextMode="MultiLine" Width="301px"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td width="109">
                <asp:Label ID="lblisim" runat="server" Text="İsminiz :"></asp:Label>
                </td>
            <td width="579">
                <asp:TextBox ID="txtisim" runat="server"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td width="109" colspan="2" style="width: 688px">
                <asp:Button ID="btnkaydet" runat="server" Text="Kaydet" onclick="btnkaydet_Click" />
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
