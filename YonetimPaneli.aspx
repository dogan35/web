<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="YonetimPaneli.aspx.vb" Inherits="SoruCevapPortali.YonetimPaneli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3><b>Soru Yönetim Paneli</b></h3><br />
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
                 <br /><asp:Label ID="lbSonuc" runat="server"></asp:Label>
             </td>             
         </tr>           
     </table> 
    <b>  <table class="table table-hover" >

<tr>
    <td class="auto-style10">Soru No</td>
<td class="auto-style6">Tarih</td>

<td>Soru</td>
    <td>Detay</td>

<td>İsim</td>

<td class="auto-style7">Götüntüleme Sayısı</td>
    <td class="auto-style8">Cevap Sayısı</td>
    <td><b>Sil</b></td><td>Düzenle</td><td>Cevap Sayısını Yenile</td>

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
      <td><asp:Button ID="btnSay" CommandName="cmdsay" CommandArgument='<%#Eval("soruid")%>' runat="server" CssClass="btn btn-primary" Text="Cevap Sayısını Yenile" OnClientClick="return confirm('İşlemi onaylıyor musunuz?')" /></td>
     
</tr>

</ItemTemplate>

</asp:Repeater>


</table></b><br />
    <h3><b>Cevap Yönetim Paneli</b></h3>
    <br />
    <table class="table table-hover">
        <tr>
            <td><b>Düzenleme yapınız: </b></td>
            <td>
                <asp:TextBox ID="txtdetay" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    <b><table class="table table-hover" >

<tr>
    <td class="auto-style10">Soru NO</td>
<td class="auto-style6">Tarih</td>

<td>Cevap</td>
    <td>İsim</td>
    <td>Sil</td>
    <td>Düzenle</td>

</tr>

<asp:Repeater ID="rptCevap" runat="server">

<ItemTemplate>

<tr>

<td><%#Eval("soruid")%></td>

<td><%#Eval("tarih")%></td>

<td><%#Eval("detay")%></td>


    <td><%#Eval("isim")%></td>
    
            <td><asp:Button ID="btnSil" CommandName="cmdSil1" CommandArgument='<%#Eval("cevapid")%>' runat="server" CssClass="btn btn-danger" Text="Sil" OnClientClick="return confirm('Silme işlemini onaylıyor musunuz?')" /></td>

    <td><asp:Button ID="btnDuzenle" CommandName="cmdDuzenle1" CommandArgument='<%#Eval("cevapid")%>' runat="server" CssClass="btn btn-primary" Text="Düzenle" OnClientClick="return confirm('Düzenleme işlemini onaylıyor musunuz?')" /></td>


       
</tr>

</ItemTemplate>

</asp:Repeater>


</table></b>
</asp:Content>
