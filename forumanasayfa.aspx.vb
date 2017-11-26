Imports System.Data.OleDb
Public Class forumanasayfaa
    Inherits System.Web.UI.Page

    Protected baglanti As OleDbConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

            Return

        End If
        Dim veritabani As String = Nothing
        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        Me.baglanti = New OleDbConnection(veritabani)
        Me.baglanti.Open()
        If Not Page.IsPostBack Then
            kayitGetir()
        End If
    End Sub
    Sub kayitGetir()

        rptSoru.DataSource = dtGetir("select * from sorular")

        rptSoru.DataBind()

    End Sub
    Protected Sub grdsorular_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            Dim lblsoruid As Label = CType(e.Row.FindControl("lblsoruid"), Label)
            If (Not (lblsoruid) Is Nothing) Then
                lblsoruid.Text = DataBinder.Eval(e.Row.DataItem, "soruid").ToString
            End If
            Dim lbltarih As Label = CType(e.Row.FindControl("lbltarih"), Label)
            If (Not (lbltarih) Is Nothing) Then
                lbltarih.Text = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "sorutarih")).ToString("dd/MM/yyyy HH:mm")
            End If
            Dim hplsoru As HyperLink = CType(e.Row.FindControl("hplsoru"), HyperLink)
            If (Not (hplsoru) Is Nothing) Then
                hplsoru.Text = CType(DataBinder.Eval(e.Row.DataItem, "soru"), String)

                hplsoru.NavigateUrl = ("sorugoster.aspx?soruid=" + DataBinder.Eval(e.Row.DataItem, "soruid").ToString)
            End If
            Dim lblisim As Label = CType(e.Row.FindControl("lblisim"), Label)
            If (Not (lblisim) Is Nothing) Then
                lblisim.Text = CType(DataBinder.Eval(e.Row.DataItem, "isim"), String)
            End If
            Dim lblgoruntuleme As Label = CType(e.Row.FindControl("lblgoruntuleme"), Label)
            If (Not (lblgoruntuleme) Is Nothing) Then
                lblgoruntuleme.Text = DataBinder.Eval(e.Row.DataItem, "goruntuleme").ToString
            End If
            Dim lblcevap As Label = CType(e.Row.FindControl("lblcevap"), Label)
            If (Not (lblcevap) Is Nothing) Then
                lblcevap.Text = DataBinder.Eval(e.Row.DataItem, "cevap").ToString
            End If
        End If
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
        End If

    End Sub
    Protected Sub Page_UnLoad(ByVal sender As Object, ByVal e As EventArgs)
        Me.baglanti.Close()
        Me.baglanti = Nothing
    End Sub

    Protected Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim baglanti As OleDbConnection = Nothing
        Dim sorgu As StringBuilder = New StringBuilder
        Dim komut As OleDbCommand = Nothing
        Dim veritabani As String = Nothing
        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        baglanti = New OleDbConnection(veritabani)
        baglanti.Open()
        sorgu.Append(" INSERT INTO sorular(sorutarih,soru,detay,isim,[goruntulenme],cevap) ")
        sorgu.Append(" VALUES ")
        sorgu.Append(" (@sorutarih,@soru,@detay,@isim,@gotuntulenme,@cevap) ")
        komut = New OleDbCommand(sorgu.ToString, baglanti)
        komut.Parameters.Add("@sorutarih", OleDbType.Date).Value = DateTime.Now.ToString
        komut.Parameters.Add("@soru", OleDbType.VarChar).Value = Me.txtsoru.Text
        komut.Parameters.Add("@detay", OleDbType.VarChar).Value = Me.txtaciklama.Text
        komut.Parameters.Add("@isim", OleDbType.VarChar).Value = Me.txtisim.Text
        komut.Parameters.Add("@gotuntulenme", OleDbType.Integer).Value = 0
        komut.Parameters.Add("@cevap", OleDbType.Integer).Value = 0
        komut.ExecuteNonQuery()
        baglanti.Close()
        baglanti = Nothing
        lbSonuc.Text = "Kayıt başarılı!"
        lbSonuc.CssClass = "alert alert-success"
        kayitGetir()

    End Sub

    Protected Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        If txtara.Text = "" Then
            lbUyari.Text = "Lütfen Soru Numarası Giriniz!"
            lbUyari.CssClass = "alert alert-danger"
        Else
            ara()
        End If
    End Sub
    Sub ara()
        rptSoru.DataSource = dtGetir("select * from sorular where soruid=" & Convert.ToInt32(txtara.Text))

        rptSoru.DataBind()
    End Sub

    Protected Sub btntemizle_Click(sender As Object, e As EventArgs) Handles btntemizle.Click
        txtara.Text = ""
        kayitGetir()
    End Sub
End Class