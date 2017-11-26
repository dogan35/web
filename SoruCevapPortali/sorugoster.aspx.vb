Imports System.Data.OleDb
Public Class sorugoster
    Inherits System.Web.UI.Page

    Protected baglanti As OleDbConnection

    Protected sorgusoruid As String = HttpContext.Current.Request.QueryString("soruid")

    Protected cevapno As Integer = 1


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim veritabani As String = Nothing

        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        Me.baglanti = New OleDbConnection(veritabani)
        Me.baglanti.Open()
        Me.sorularigoster()
        Me.cevaplarigoster()
    End Sub

    Protected Sub sorularigoster()
        Dim dt As DataTable = dtGetir("SELECT * FROM sorular")

        If (dt.Rows.Count > 0) Then
            Me.lblsoru.Text = dt.Rows(0)("soru").ToString
            Me.lblaciklama.Text = dt.Rows(0)("detay").ToString
            Me.lblisim.Text = ("<b>isim :</b>" + dt.Rows(0)("isim").ToString)
            Me.lbltarih.Text = ("<b>Soru Tarihi :</b>" + Convert.ToDateTime(dt.Rows(0)("sorutarih")).ToString("dd/MM/yyyy HH:mm").ToString)
            Me.lblcevap.Text = ("<b>Cevap Sayısı :</b>" + dt.Rows(0)("cevap").ToString)
            Me.lblgoruntulenme.Text = ("<b>Görüntülenme Sayısı :</b>" + dt.Rows(0)("goruntulenme").ToString)
        End If

        
    End Sub

    Protected Sub cevaplarigoster()
        

        cevapgoruntuleyici.DataSource = dtGetir("SELECT * FROM  cevaplar")
        cevapgoruntuleyici.DataBind()
        
    End Sub


    Protected Sub Page_UnLoad(ByVal sender As Object, ByVal e As EventArgs)
        Me.baglanti.Close()
        Me.baglanti = Nothing
    End Sub
    Protected Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click
        Dim sorgu As StringBuilder = New StringBuilder
        Dim komut As OleDbCommand = Nothing

        sorgu.Append(" INSERT INTO cevaplar (soruid,tarih,detay,isim) ")
        sorgu.Append(" VALUES ")
        sorgu.Append(" (@soruid,@tarih,@detay,@isim) ")
        komut = New OleDbCommand(sorgu.ToString, Me.baglanti)
        komut.Parameters.Add("@sQuestionID", OleDbType.VarChar).Value = Me.sorgusoruid.ToString
        komut.Parameters.Add("@sCreateDate", OleDbType.Date).Value = DateTime.Now.ToString
        komut.Parameters.Add("@sDetails", OleDbType.VarChar).Value = Me.txtdetay.Text
        komut.Parameters.Add("@sName", OleDbType.VarChar).Value = Me.txtisim.Text
        komut.ExecuteNonQuery()

        sorgu.Remove(0, sorgu.Length)
        sorgu.Append(" UPDATE sorular SET cevap = cevap + 1 ")
        sorgu.Append(" WHERE soruid = @soruid ")
        komut = New OleDbCommand(sorgu.ToString, Me.baglanti)
        komut.Parameters.Add("@soruid", OleDbType.VarChar).Value = Me.sorgusoruid.ToString
        komut.ExecuteNonQuery()
        Response.Redirect(("sorugoster.aspx?soruid=" + Me.sorgusoruid.ToString))
    End Sub

    Protected Sub cevapgoruntuleyici_ItemDataBound(ByVal sender As Object, ByVal e As RepeaterItemEventArgs)
        If ((e.Item.ItemType = ListItemType.Item) Or (e.Item.ItemType = ListItemType.AlternatingItem)) Then

            Dim lblcevapno As Label = CType(e.Item.FindControl("lblcevapno"), Label)

            If (Not (lblcevapno) Is Nothing) Then
                lblcevapno.Text = ("Cavap Numarası : " + Me.cevapno)
                Me.cevapno = (Me.cevapno + 1)
            End If
            Dim lblcevapdetay As Label = CType(e.Item.FindControl("lblcavapdetay"), Label)
            If (Not (lblcevapdetay) Is Nothing) Then
                lblcevapdetay.Text = CType(DataBinder.Eval(e.Item.DataItem, "detay"), String)
            End If
            Dim lblcevaplayan As Label = CType(e.Item.FindControl("lblcevaplayan"), Label)
            If (Not (lblcevaplayan) Is Nothing) Then
                lblcevaplayan.Text = CType(DataBinder.Eval(e.Item.DataItem, "isim"), String)
            End If
            Dim lblcevaptarih As Label = CType(e.Item.FindControl("lblcevaptarih"), Label)
            If (Not (lblcevaptarih) Is Nothing) Then
                lblcevaptarih.Text = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "tarih")).ToString("dd/MM/yyyy HH:mm")
            End If
        End If
    End Sub
End Class