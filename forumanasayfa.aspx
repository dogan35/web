<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="forumanasayfa.aspx.vb" Inherits="SoruCevapPortali.forumanasayfaa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3><a href="yenisoru.aspx" style="text-align: left">Yeni Soru</a></h3>
        <div class="col-lg-3">
                 <table class="table">
                      <tr>
                           <td>
                               <b>Sorular</b>
                           </td>
                           <td>
                               <asp:TextBox ID="txtsoru" runat="server" CssClass="formcontrol" TextMode="MultiLine" Rows="3" Width="400px"></asp:TextBox>
                           </td>
                      </tr>                
         <tr>               
             <td>
                 <b>Sorunuz ile ilgili kısa bir açıklama yazınız </b>
             </td>               
             <td>
                 <asp:TextBox ID="txtaciklama" runat="server" CssClass="formcontrol" TextMode="MultiLine" Rows="3" Width="400px"></asp:TextBox>
             </td>             
         </tr>                
         <tr>
              <td>
                  <b>İsminiz </b>
              </td>               
             <td>
                 <asp:TextBox ID="txtisim" runat="server" CssClass="formcontrol" Width="400px"></asp:TextBox>
             </td>             
         </tr>      
                              
         <tr>               
             <td>&nbsp;</td>               
             <td>
                 <asp:Button ID="btnKaydet" runat="server" CssClass="btn btn-primary" Text="Kaydet"></asp:Button>
             </td>             
         </tr>                
         <tr>               
             <td>&nbsp;</td>               
             <td>
                 <br /><asp:Label ID="lbSonuc" runat="server"></asp:Label>
             </td>             
         </tr>           
     </table>  
<b>
            <table class="table table-hover" >

<tr>
    <td class="auto-style10">Soru No</td>
<td class="auto-style6">Tarih</td>

<td>Soru</td>
    <td>Detay</td>

<td>İsim</td>

<td class="auto-style7">Götüntüleme Sayısı</td>
    <td class="auto-style8">Cevap Sayısı</td>
    <td><b>Sil</b></td><td>Düzenle</td>

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
        <td><asp:Button ID="btnSil" CommandName="cmdSil" CommandArgument='<%#Eval("soruid")%>' runat="server" CssClass="btn btn-danger" Text="Sil" OnClientClick="return confirm('Silme işlemini onaylıyor musunuz?')" /></td>

    <td><asp:Button ID="btnDuzenle" CommandName="cmdDuzenle" CommandArgument='<%#Eval("soruid")%>' runat="server" CssClass="btn btn-primary" Text="Düzenle" OnClientClick="return confirm('Düzenleme işlemini onaylıyor musunuz?')" /></td>
       
</tr>

</ItemTemplate>

</asp:Repeater>


</table></div><div class="col-lg-6"></div><br /><table class="table table-hover"><tr><td><b><asp:Label ID="Label1" runat="server" Text="Soru NO: "></asp:Label></b>
    </td><td>
        <asp:TextBox ID="txtara" runat="server"></asp:TextBox></td></tr><tr><td>
            <asp:Button ID="btnara" runat="server" Text="Ara" CssClass="btn btn-primary" />
            <asp:Label ID="lbUyari" runat="server" Text=""></asp:Label>
    </td><td>
        <asp:Button ID="btntemizle" runat="server" Text="Tabloyu Yenile/Aramayı sıfırla" CssClass="btn btn-warning"/></td></tr></table>
    
    </asp:Content>
