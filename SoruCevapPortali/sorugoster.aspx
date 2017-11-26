<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="sorugoster.aspx.vb" Inherits="SoruCevapPortali.sorugoster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Forum Sistesi</title>
    <style type="text/css">
        .style1
        {
            height: 33px;
        }
        .style2
        {
            height: 97px;
        }
        .style3
        {
            width: 318px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="693" border="1" cellpadding="0" cellspacing="0" bordercolor="#CCCCCC">
        <tr>
            <td colspan="2" class="style1">
                <div style="text-align:center">
                    <asp:Label ID="lblsoru" runat="server" Font-Size="X-Large"></asp:Label>
         </div>
      </td>
    </tr>
  <tr>
      <td colspan="2" class="style2">
          <asp:Label ID="lblaciklama" runat="server"></asp:Label>
          </td>
      </tr>
        <tr>
            <td width="344">
                <asp:Label ID="lblisim" runat="server"></asp:Label>
                &nbsp;<asp:Label ID="lbltarih" runat="server"></asp:Label>
                </td>
            <td width="343" class="style3">
                <asp:Label ID="lblgoruntulenme" runat="server"></asp:Label>
                &nbsp;<asp:Label ID="lblcevap" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        
        <asp:Repeater ID="cevapgoruntuleyici" runat="server" >
            <ItemTemplate>
                <table width="693" border="1" cellpadding="0" cellspacing="0" bordercolor="#CCCCCC">
                    <tr>
                        <td colspan="2" class="style2">
                            <asp:Label ID="lblcevapno" runat="server"></asp:Label><br /><br />
                            <asp:Label ID="lblcevapdetay" runat="server"></asp:Label></td>
                        </tr>
                    <tr>
                        <td width="344">
                            <asp:Label ID="lblcevaplayan" runat="server"></asp:Label>
                            </td>
                        <td width="343" class="style3">
                            <asp:Label ID="lblcevaptarih" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                <br />
                </ItemTemplate>
            </asp:Repeater>

        <asp:HyperLink ID="hplgeri" runat="server" NavigateUrl="/forumanasayfa.aspx">Forum'a Geri Dön</asp:HyperLink>

        <br /><br />
        <table width="600" border="1" cellpadding="0" cellspacing="0" bordercolor="#CCCCCC">
            <tr>
                <td class="style2">
                    <asp:Label ID="lblcevapdetaybaslik" runat="server" Text="cevabınız....:"></asp:Label>
                    </td>
                <td class="style2">
                    <asp:TextBox ID="txtdetay" runat="server" Columns="5" Height="83px"
                        TextMode="MultiLine" Width="301px"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td width="109">
                    <asp:Label ID="lblcevaplayanadibaslik" runat="server" Text="İsminiz :"></asp:Label>
                    </td>
                <td width="579">
                    <asp:TextBox ID="txtisim" runat="server"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td width="109" colspan="2" style="width: 688px">
                    <asp:Button ID="btnkaydet" runat="server" Text="Kaydet" style="height: 26px"  />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
