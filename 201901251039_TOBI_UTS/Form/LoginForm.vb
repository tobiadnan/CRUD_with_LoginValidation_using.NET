Imports System.Data
Imports System.Data.SqlClient

Public Class LoginForm
    Dim strSql As New SqlCommand
    Dim objDataSet As New DataSet
    Dim objReader As SqlDataReader
    Dim conn As New Connection.VbConnection
    Dim userId, pass, userName As String

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Call Login()
    End Sub
    Private Sub Login()
        On Error Resume Next
        If tbUserName.Text = "" Or tbPassword.Text = "" Or tbUserId.Text = "" Then
            MsgBox("Semua Field Harus Terisi", MsgBoxStyle.Exclamation, "")
            tbUserId.Focus()
            Exit Sub
        End If

        strSql = conn.Open.CreateCommand
        strSql.CommandText = ("SELECT * FROM tblLogin WHERE idUser = '" & tbUserId.Text & "' AND userName = '" & tbUserName.Text & "' AND passwordId = '" & Trim(tbPassword.Text) & "'")
        objReader = strSql.ExecuteReader
        objReader.Read()

        userId = objReader.Item("idUser")
        userName = objReader.Item("userName")
        pass = objReader.Item("passwordId")

        conn.Close()

        If userId = "" Or pass = "" Or userName = "" Then
            MsgBox("Akses ditolak, User Id, User Name atau Password Salah", vbCritical, "Akses..")
            Exit Sub
        Else
            Me.Visible = False
            KaryawanForm.Show()
            KaryawanForm.tbNik.Focus()
            tbUserName.Text = ""
            tbPassword.Text = ""
            tbUserId.Text = ""
        End If
    End Sub
    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbUserId.Focus()

    End Sub

    Private Sub tbUserId_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbUserId.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbUserName.Focus()
        End If
    End Sub

    Private Sub tbUserName_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbUserName.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbPassword.Focus()
        End If
    End Sub

    Private Sub tbPassword_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call Login()

        End If
    End Sub
End Class
