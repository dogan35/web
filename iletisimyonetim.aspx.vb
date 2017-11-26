Public Class iletisimyonetim
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

            Return

        End If
        kayitGetir()
    End Sub
    Sub kayitGetir()

        rptMesaj.DataSource = dtGetir("select * from iletiler order by tarih desc")

        rptMesaj.DataBind()

    End Sub
    Protected Sub rptMesaj_ItemCommand(source As Object, e As RepeaterCommandEventArgs) Handles rptMesaj.ItemCommand

        If e.CommandName = "cmdSil" Then

            Dim mesaj As Integer = Convert.ToInt32(e.CommandArgument.ToString())

            sqlCalistir("delete from iletiler where id=" & mesaj)

            kayitGetir()



        End If

    End Sub
End Class