Imports System.Data.OleDb
Public Class yenisoru
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnkaydet_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim baglanti As OleDbConnection = Nothing
        Dim sorgu As StringBuilder = New StringBuilder
        Dim komut As OleDbCommand = Nothing
        Dim veritabani As String = Nothing
        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        baglanti = New oleDbConnection(veritabani)
        baglanti.Open()
        sorgu.Append(" INSERT INTO sorular(soruid,sorutarih,soru,detay,isim,[goruntulenme],cevap) ")
        sorgu.Append(" VALUES ")
        sorgu.Append(" (@soruid,@sorutarih,@soru,@detay,@isim,@gotuntulenme,@cevap) ")
        komut = New OleDbCommand(sorgu.ToString, baglanti)
        komut.Parameters.Add("@soruid", OleDbType.Integer).Value = 0
        komut.Parameters.Add("@sorutarih", OleDbType.Date).Value = DateTime.Now.ToString
        komut.Parameters.Add("@soru", OleDbType.VarChar).Value = Me.txtsoru.Text
        komut.Parameters.Add("@detay", OleDbType.VarChar).Value = Me.txtaciklama.Text
        komut.Parameters.Add("@isim", OleDbType.VarChar).Value = Me.txtisim.Text
        komut.Parameters.Add("@gotuntulenme", OleDbType.Integer).Value = 0
        komut.Parameters.Add("@cevap", OleDbType.Integer).Value = 0
        komut.ExecuteNonQuery()
        baglanti.Close()
        baglanti = Nothing
        Response.Redirect("forumanasayfa.aspx")
    End Sub
End Class