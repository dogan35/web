<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="iletisim.aspx.vb" Inherits="SoruCevapPortali.İletişimaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Forum İletişim</h1>

    <div class="row">

        <div class="col-lg-6 form-group">

            <label>Adınız</label>

            <asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>

            <span class="help-block">Adınızı Soyadınızı Yazınız</span>

            <label>Telefon Numaranız</label>

            <asp:TextBox ID="txtTel" runat="server" CssClass="form-control"></asp:TextBox>

            <span class="help-block">Telefon Numaranızı Yazınız</span>

             <label>Yaşınız</label>

            <asp:TextBox ID="txtYas" runat="server" CssClass="form-control"></asp:TextBox>

            <span class="help-block">Yaşınızı Yazınız</span>

             <label>Cinsiyetiniz</label>

            <asp:TextBox ID="txtCinsiyet" runat="server" CssClass="form-control"></asp:TextBox>

            <span class="help-block">Cinsiyetinizi Yazınız</span>

            <label>E-Posta Adresiniz</label>

            <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>

            <span class="help-block">E-Posta Adresinizi Yazınız</span>

            <label>Mesajınız</label>

            <asp:TextBox ID="txtMesaj" runat="server" CssClass="form-control"
                TextMode="MultiLine" Rows="5"></asp:TextBox>

            <span class="help-block">Mesajınızı Yazınız</span>

            <br /><asp:Label ID="lbSonuc" runat="server"></asp:Label><br /><br />

            <asp:Button ID="btnGonder" runat="server" CssClass="btn btn-primary"
                
                Text="Gönder"/>
        </div>

        <div class="col-lg-6">

            <h3>İletişim Bilgileri</h3>

            <b>Adres:</b>Akdeniz Üniversitesi<br />

            Teknik Bilimler MYO Bilgisayar Programcılığı<br />

            Tel:0 536 793 44 85 <br />

            </div>

        </div>
    </asp:Content>