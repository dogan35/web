Public Class YonetimPaneli
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

            Return

        End If
        kayitGetir()
        cevapgoster()
    End Sub
    Protected Sub rptSoru_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptSoru.ItemCommand

        If e.CommandName = "cmdSil" Then
            Dim sId As Integer = Convert.ToInt32(e.CommandArgument.ToString())
            sqlCalistir("delete from sorular where soruid=" & sId)

            kayitGetir()
        End If



        If (e.CommandName = "cmdDuzenle") Then

            Dim soruid As Integer = Convert.ToInt32(e.CommandArgument.ToString())
            sqlCalistir("update sorular set soru='" & txtsoru.Text & "',detay='" & txtaciklama.Text & "',isim='" & txtisim.Text & "' where soruid=" & Convert.ToInt32(soruid))
            kayitGetir()
            lbSonuc.Text = "Sorular Güncellenmiştir..."
            lbSonuc.CssClass = "alert alert-success"
            Dim b As Integer
            Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & soruid)
            b = db.Rows.Count
            sqlCalistir("update sorular set cevap=" & b & " where soruid=" & soruid)
            kayitGetir()
            cevapgoster()
        End If
        If (e.CommandName = "cmdsay") Then

            Dim soruid As Integer = Convert.ToInt32(e.CommandArgument.ToString())

            
            Dim b As Integer
            Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & soruid)
            b = db.Rows.Count
            sqlCalistir("update sorular set cevap=" & b & " where soruid=" & soruid)
            kayitGetir()
            cevapgoster()
        End If

    End Sub
    Sub cevapgoster()
        rptCevap.DataSource = dtGetir("select * from cevaplar order by tarih desc")
        rptCevap.DataBind()
    End Sub
    Sub kayitGetir()

        rptSoru.DataSource = dtGetir("select * from sorular order by sorutarih desc")

        rptSoru.DataBind()

    End Sub
    Protected Sub rptCevap_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptCevap.ItemCommand

        If (e.CommandName = "cmdSil1") Then

            Dim cevapid As Integer = Convert.ToInt32(e.CommandArgument.ToString())
            sqlCalistir("delete * from cevaplar where cevapid=" & cevapid)


            Dim b As Integer
            Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & cevapid)
            b = db.Rows.Count
            sqlCalistir("update sorular set cevap=" & b & " where soruid=" & cevapid)
            lbSonuc.Text = "Kayıt Silindi!"
            lbSonuc.CssClass = "alert alert-danger"
            kayitGetir()
            cevapgoster()
        End If

        If (e.CommandName = "cmdDuzenle1") Then

            Dim cevapid As Integer = Convert.ToInt32(e.CommandArgument.ToString())
            sqlCalistir("update cevaplar set detay='" & txtdetay.Text & "' where cevapid=" & Convert.ToInt32(cevapid))


            Dim b As Integer
            Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & cevapid)
            b = db.Rows.Count
            sqlCalistir("update sorular set cevap=" & b & " where soruid=" & cevapid)
            lbSonuc.Text = "Mesaj Güncellenmiştir..."
            lbSonuc.CssClass = "alert alert-success"
            kayitGetir()
            cevapgoster()
        End If

       

    End Sub
End Class