<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="sorugoster.aspx.vb" Inherits="SoruCevapPortali.sorugosterr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table" width="693" border="1" cellpadding="0" cellspacing="0" bordercolor="#CCCCCC">
        <tr>
            <td colspan="2" class="style1">
                <div style="text-align:center">
                    <asp:Label ID="lblsoru" runat="server" Font-Size="X-Large"></asp:Label>
         </div>
      </td>
    </tr>
  <tr>
      <td colspan="2" class="style2">
          <b><asp:Label ID="lblaciklama" runat="server"></asp:Label></b>
          </td>
      </tr>
        <tr>
            <td width="344">
                <b><asp:Label ID="lblisim" runat="server"></asp:Label></b>
                &nbsp;<b><asp:Label ID="lbltarih" runat="server"></asp:Label></b>
                </td>
            <td width="343" class="style3">
                <b><asp:Label ID="lblcevap" runat="server"></asp:Label>&nbsp;<asp:Label ID="lblgoruntulenme" runat="server"></asp:Label></b>
                &nbsp;</td>
            </tr>
        </table>
        <hr />
    <table class="table table-hover"><tr><td><b>Adınız: </b></td><td>
        <asp:TextBox ID="txtad" runat="server"></asp:TextBox></td></tr><tr><td>
        <b><asp:Label ID="Label2" runat="server" Text="Cevabınızı yazınız: "></asp:Label></b></td><td>
        <asp:TextBox ID="txtCevap" runat="server"></asp:TextBox></td></tr></table>
  <b>  <table class="table table-hover" >

<tr>
    <td class="auto-style10">Soru No</td>
<td class="auto-style6">Tarih</td>

<td>Soru</td>
    <td>Detay</td>

<td>İsim</td>

<td class="auto-style7">Götüntüleme Sayısı</td>
    <td class="auto-style8">Cevap Sayısı</td>
    <td><b>Cevapla</b></td>

</tr>

<asp:Repeater ID="rptSoru" runat="server">

<ItemTemplate>

<tr>

<td><%#Eval("soruid")%></td>

<td><%#Eval("sorutarih")%></td>

<td><%#Eval("soru")%></td>

<td><%#Eval("detay")%></td>
    <td><%#Eval("isim")%></td>
    <td><%#Eval("goruntulenme")%></td>
    <td><%#Eval("cevap")%></td>
        <td><asp:Button ID="btnCevap" CommandName="cmdCevap" CommandArgument='<%#Eval("soruid")%>' runat="server" CssClass="btn btn-primary" Text="Cevapla" OnClientClick="return confirm('Cevaplama işlemini onaylıyor musunuz?')" /></td>

       
</tr>

</ItemTemplate>

</asp:Repeater>


</table></b>
    <b><table class="table table-hover" >

<tr>
    <td class="auto-style10">Soru NO</td>
<td class="auto-style6">Tarih</td>

<td>Cevap</td>
    <td>İsim</td>


</tr>

<asp:Repeater ID="rptCevap" runat="server">

<ItemTemplate>

<tr>

<td><%#Eval("soruid")%></td>

<td><%#Eval("tarih")%></td>

<td><%#Eval("detay")%></td>


    <td><%#Eval("isim")%></td>
    
    

       
</tr>

</ItemTemplate>

</asp:Repeater>


</table>

    </b>
        <asp:HyperLink ID="hplgeri" runat="server" NavigateUrl="/forumanasayfa.aspx">Forum'a Geri Dön</asp:HyperLink>
        <hr />
        
        </asp:Content>
