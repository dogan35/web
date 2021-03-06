﻿Imports System.Data.OleDb
Module vt
    Function Baglan()
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & HttpContext.Current.Server.MapPath("App_Data/forum.mdb"))
        baglanti.Open()
        Return baglanti
    End Function
    Function dtGetir(sql As String) As DataTable
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim dt As DataTable = New DataTable
        adp.Fill(dt)
        Return dt
        baglanti.Close()
        cmd.Connection.Close()
        cmd.Dispose()
        adp.Dispose()
    End Function
    Function sqlCalistir(sql As String) As Boolean
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        baglanti.Close()
        cmd.Connection.Close()
        cmd.Dispose()
        Return True
    End Function
    Function kayitSayisi(sql As String) As Integer
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim dt As DataTable = New DataTable
        adp.Fill(dt)
        Return dt.Rows.Count
        baglanti.Close()
        cmd.Connection.Close()
        cmd.Dispose()
        adp.Dispose()
    End Function
    Function dsGetir(sql As String) As DataSet
        Dim baglanti As OleDbConnection = Baglan()
        Dim cmd As New OleDbCommand
        cmd.Connection = baglanti
        cmd.CommandText = sql
        Dim adp As New OleDbDataAdapter
        adp.SelectCommand = cmd
        Dim ds As DataSet = New DataSet
        adp.Fill(ds, "tb")
        Return ds
        baglanti.Close()
        cmd.Connection.Close()
        cmd.Dispose()
        adp.Dispose()
    End Function
End Module