Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.SqlClient

Partial Public Class _default1
    Inherits System.Web.UI.Page
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub Koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Fauzan\Documents\Visual Studio 2008\Projects\UAS\UAS\App_Data\dbrental.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
        End If
        conn.Open()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Sub Kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Protected Sub btnlogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnlogin.Click
        Call Koneksi()
        Dim simpan As String = "insert into tbrental(NoPolisi, MerkMobil) " & " values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd = New OleDbCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

        Me.btnlogin.Enabled = True
        Call Koneksi()
        Call Kosong()
        Response.Redirect("http://localhost:50046/pages/default.aspx")
    End Sub

    Protected Sub btnbatal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbatal.Click
        Response.Redirect("http://localhost:50046/pages/laporan.aspx")
    End Sub
End Class