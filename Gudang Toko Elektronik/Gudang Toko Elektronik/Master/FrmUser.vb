Imports Oracle.DataAccess.Client
Public Class FrmUser
    Dim cmd As New OracleCommand("", conn)
    Dim rd As OracleDataReader
    Sub AutoGenerate()
        cmd.CommandText = "SELECT generateUser from dual"
        lblIDUser.Text = cmd.ExecuteScalar
    End Sub
    Sub start()
        AutoGenerate()
        Label1.Text = Date.Today.ToString("dd-MMM-yy")
        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbJabatan.Text = "-- pilih --"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FrmBrowseUser.Show()
        Me.Hide()
    End Sub

    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            start()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New OracleCommand("INSERT INTO administrator(iduser, username, password, jabatan) VALUES (:iduser, :username, :password,:jabatan)", conn)

        With cmd
            .Parameters.Add(":iduser", lblIDUser.Text)
            .Parameters.Add(":username", txtUsername.Text)
            .Parameters.Add(":password", txtPassword.Text)
            .Parameters.Add(":jabatan", cmbJabatan.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New OracleCommand("UPDATE administrator SET username = :username , password = :password , jabatan = :jabatan WHERE iduser = :iduser", conn)

        With cmd
            .Parameters.Add(":username", txtUsername.Text)
            .Parameters.Add(":password", txtPassword.Text)
            .Parameters.Add(":jabatan", cmbJabatan.Text)
            .Parameters.Add(":iduser", lblIDUser.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diperbaharui!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        start()
    End Sub

   
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAdministrator.Show()
    End Sub

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs)
    '    Dim msg = "Apakah Anda yakin akan menghapus data tersebut?"
    '    Dim style = MsgBoxStyle.YesNo
    '    Dim response = MsgBox(msg, style)
    '    If response = MsgBoxResult.Yes Then
    '        Dim cmd As New OracleCommand("DELETE FROM administrator WHERE iduser = :iduser", conn)

    '        With cmd
    '            .Parameters.Add(":iduser", lblIDUser.Text)
    '        End With
    '        Try
    '            cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        start()

    '    End If
    'End Sub
End Class