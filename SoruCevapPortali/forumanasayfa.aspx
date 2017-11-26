<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="forumanasayfa.aspx.vb" Inherits="SoruCevapPortali.forumanasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Forum Sitesi</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="hplyenisoru" runat="server" NavigateUrl="~/yenisoru.aspx">Yeni Soru</asp:HyperLink>
        <asp:GridView ID="grdsorular" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:TemplateField HeaderText="Soru No">
                    <ItemTemplate>
                        <div style="text-align:center">
                            <asp:Label ID="lblsoruid" runat="server"></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Tarih">
                    <ItemTemplate>
                        <asp:Label ID="lbltarih" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Soru">
                    <ItemTemplate>
                        <asp:HyperLink ID="hplsoru" runat="server"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="İsim">
                    <ItemTemplate>
                        <div style="text-align:center">
                            <asp:Label ID="lblisim" runat="server"></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField HeaderText="Görüntülenme Sayısı">
                            <ItemTemplate>
                                <div style="text-align:center">
                                    <asp:Label ID="lblgoruntulenme" runat="server"></asp:Label>
                                    </div>

                                </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cevap Sayısı">
                    <ItemTemplate>
                        <div style="text-align:center">
                            <asp:Label ID="lblcevap" runat="server"></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </form>
    </body>
    </html>



    
