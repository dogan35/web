Imports System.Data.OleDb
Public Class forumanasayfa
    Inherits System.Web.UI.Page

    Protected baglanti As OleDbConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim veritabani As String = Nothing
        veritabani = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        Me.baglanti = New OleDbConnection(veritabani)
        Me.baglanti.Open()
        If Not Page.IsPostBack Then
            Me.forumgoster()
        End If

    End Sub

    Protected Sub forumgoster()
        
        grdsorular.DataSource = dtGetir("SELECT * FROM cevaplar")
        grdsorular.DataBind()

    End Sub
    Protected Sub grdsorular_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
        grdsorular.PageIndex = e.NewPageIndex
        Me.forumgoster()
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
    Protected Sub Page_UnLoad(ByVal sender As Object, ByVal e As EventArgs)
        Me.baglanti.Close()
        Me.baglanti = Nothing
    End Sub
End Class