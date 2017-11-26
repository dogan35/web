Public Class İletişimaspx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGonder_Click(sender As Object, e As EventArgs) Handles btnGonder.Click
        If txtAd.Text = "" Or txtTel.Text = "" Or txtYas.Text = "" Or txtCinsiyet.Text = "" Or txtMail.Text = "" Or txtMesaj.Text = "" Then


            lbSonuc.Text = "Lütfen Tüm Alanları Doldurunuz!"

            lbSonuc.CssClass = "alert alert-danger"

            Return

        End If

        sqlCalistir("insert into iletiler(adsoyad,tel,yasiniz,cinsiyetiniz,mail,mesaj,tarih) values ('" & txtAd.Text & "','" & txtTel.Text & "','" & txtYas.Text & "','" & txtCinsiyet.Text & "','" & txtMail.Text & "','" & txtMesaj.Text & "','" & Now.ToShortDateString() & " " & Now.ToShortDateString() & "')")

        lbSonuc.Text = "Mesajınız Gönderilmiştir..."

        lbSonuc.CssClass = "alert alert-success"

    End Sub
End Class