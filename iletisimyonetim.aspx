<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="iletisimyonetim.aspx.vb" Inherits="SoruCevapPortali.iletisimyonetim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>İletişim Yönetim Paneli</h1>

<div class="row">
    
<div class="col-lg-6 form-group">

<p><table class="table table-hover">

<tr>

<td><b>Mesaj NO</b></td>

<td><b>Ad Soyad</b></td>

<td><b>Telefon</b></td>
    <td><b>Yaş</b></td>
    <td><b>Cinsiyet</b></td>
<td><b>Mail</b></td>
    <td><b>Mesaj</b></td><td><b>Tarih</b></td><td><b>Sil</b></td>
</tr>

<asp:Repeater ID="rptMesaj" runat="server">

<ItemTemplate>

<tr>

<td><%#Eval("id")%></td>

<td><%#Eval("adsoyad")%></td>

<td><%#Eval("tel")%></td>
    <td><%#Eval("yasiniz")%></td>

    <td><%#Eval("cinsiyetiniz")%></td>
    <td><%#Eval("mail")%></td>
    <td><%#Eval("mesaj")%></td>
    <td><%#Eval("tarih")%></td>
    <td><asp:Button ID="btnSil" CommandName="cmdSil" CommandArgument='<%#Eval("id") %>' runat="server" CssClass="btn btn-danger" Text="Sil" /></td>
</tr>

</ItemTemplate>

</asp:Repeater>

</table>
    </p>
</asp:Content>
