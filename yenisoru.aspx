<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="yenisoru.aspx.vb" Inherits="SoruCevapPortali.yenisoruu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
          <hr /> 
</asp:Content>
