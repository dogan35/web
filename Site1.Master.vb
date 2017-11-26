Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim dt As DataTable = dtGetir("select * from kullanicilar ")
        Label1.Text = dt.Rows(0)("kadi").ToString()

        Label2.Text = dt.Rows(0)("sifre").ToString()
        If txtKadi.Text <> Label1.Text Then
            Label3.Text = "Tekrar deneyiniz."
            Label3.CssClass = "alert alert-danger"
        Else
            If txtSifre.Text <> Label2.Text Then

                Label3.Text = "Tekrar deneyiniz."
                Label3.CssClass = "alert alert-danger"

            Else
                Response.Redirect("YonetimPaneli.aspx")
            End If

        End If
    End Sub

    Protected Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        Dim dt As DataTable = dtGetir("select * from kullanicilar ")
        Label1.Text = dt.Rows(0)("kadi").ToString()

        Label2.Text = dt.Rows(0)("sifre").ToString()
        If txtKadi.Text <> Label1.Text Then
            Label3.Text = "Tekrar deneyiniz."
            Label3.CssClass = "alert alert-danger"
        Else
            If txtSifre.Text <> Label2.Text Then

                Label3.Text = "Tekrar deneyiniz."
                Label3.CssClass = "alert alert-danger"
            Else
                Response.Redirect("iletisimyonetim.aspx")
            End If

        End If
    End Sub
End Class