Imports System.Data.OleDb
Public Class sorugosterr
    Inherits System.Web.UI.Page

    Protected baglanti As OleDbConnection

    Protected sorgusoruid As String = HttpContext.Current.Request.QueryString("soruid")

    Protected cevapno As Integer = 1


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

            Return

        End If
        Dim veritabani As String = Nothing

        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        Me.baglanti = New OleDbConnection(veritabani)
        Me.baglanti.Open()
        arttir()
        cevapgoster()
        csay()
        kayitgetir()
        'cevapsay()
    End Sub
    Sub kayitgetir()
        rptSoru.DataSource = dtGetir("select * from sorular")
        rptSoru.DataBind()
    End Sub
    'Sub cevapsay()
    '    Dim a As Integer
    '    Dim dt As DataTable = dtGetir("select * from sorular ")
    '    a = dt.Rows(0)("soruid").ToString()
    '    Dim b As Integer
    '    Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & a)
    '    b = db.Rows.Count
    '    sqlCalistir("update sorular set cevap=" & b & " where soruid=" & a)



    'End Sub
    Sub cevapgoster()
        rptCevap.DataSource = dtGetir("select * from cevaplar")
        rptCevap.DataBind()
    End Sub
    
    Sub csay()
        lblcevap.Text = "<b>Cevap sayısı: " & rptCevap.Items.Count
    End Sub


   

    Protected Sub Page_UnLoad(ByVal sender As Object, ByVal e As EventArgs)
        Me.baglanti.Close()
        Me.baglanti = Nothing
    End Sub


    'Protected Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
    '    Dim sorgu As StringBuilder = New StringBuilder
    '    Dim komut As OleDbCommand = Nothing

    '    sorgu.Append(" INSERT INTO cevaplar (tarih,detay,isim) ")
    '    sorgu.Append(" VALUES ")
    '    sorgu.Append(" (@tarih,@detay,@isim) ")
    '    komut = New OleDbCommand(sorgu.ToString, Me.baglanti)
    '    komut.Parameters.Add("@sCreateDate", OleDbType.Date).Value = DateTime.Now.ToString
    '    komut.Parameters.Add("@sDetails", OleDbType.VarChar).Value = Me.txtdetay.Text
    '    komut.Parameters.Add("@sName", OleDbType.VarChar).Value = Me.txtisim.Text
    '    komut.ExecuteNonQuery()

    '    sorgu.Remove(0, sorgu.Length)
    '    sorgu.Append(" UPDATE sorular SET cevap = cevap + 1 ")
    '    sorgu.Append(" WHERE soruid = @soruid ")
    '    komut = New OleDbCommand(sorgu.ToString, Me.baglanti)
    '    komut.ExecuteNonQuery()
    '    Response.Redirect(("sorugoster.aspx?soruid=" + Me.sorgusoruid.ToString))
    'End Sub
    Sub arttir()
        sqlCalistir("update sorular set goruntulenme = goruntulenme + 1")

        Dim dt As DataTable = dtGetir("select * from sorular ")
        lblgoruntulenme.Text = "Görüntülenme sayısı: " & dt.Rows(0)("goruntulenme").ToString()
    End Sub
    Protected Sub rptSoru_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptSoru.ItemCommand

       


        If (e.CommandName = "cmdCevap") Then

            Dim soruid As Integer = Convert.ToInt32(e.CommandArgument.ToString())
            sqlCalistir("insert into cevaplar (soruid,tarih,detay,isim) values('" & soruid & "','" & Now.ToShortDateString() & " " & Now.ToShortTimeString() & "','" & txtCevap.Text & "','" & txtad.Text & "')")

            
            Dim b As Integer
            Dim db As DataTable = dtGetir("select * from cevaplar where soruid=" & soruid)
            b = db.Rows.Count
            sqlCalistir("update sorular set cevap=" & b & " where soruid=" & soruid)
            kayitgetir()
            cevapgoster()
        End If

    End Sub

End Class