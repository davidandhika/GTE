﻿Imports Oracle.DataAccess.Client
Public Class FrmBrowseGudang

    Dim rd As OracleDataReader
    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT * FROM GUDANG", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE"
            .Columns(1).HeaderCell.Value = "NAMA"
            .Columns(2).HeaderCell.Value = "ALAMAT"
            .Columns(3).HeaderCell.Value = "KOTA"
            .Columns(4).HeaderCell.Value = "TELP"
            .Columns(5).HeaderCell.Value = "PIC"
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM GUDANG WHERE NMGUDANG LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE"
            .Columns(1).HeaderCell.Value = "NAMA"
            .Columns(2).HeaderCell.Value = "ALAMAT"
            .Columns(3).HeaderCell.Value = "KOTA"
            .Columns(4).HeaderCell.Value = "TELP"
            .Columns(5).HeaderCell.Value = "PIC"
        End With
    End Sub

    
    Private Sub FrmBrowseGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            FrmGudang.lblKodeGudang.Text = DataGridView1.Item(0, barisdgv).Value
            FrmGudang.txtNamaGudang.Text = DataGridView1.Item(1, barisdgv).Value
            FrmGudang.txtAlamat.Text = DataGridView1.Item(2, barisdgv).Value
            FrmGudang.txtKota.Text = DataGridView1.Item(3, barisdgv).Value
            FrmGudang.txtTelp.Text = DataGridView1.Item(4, barisdgv).Value
            FrmGudang.txtContactPerson.Text = DataGridView1.Item(5, barisdgv).Value
        End If
        Me.Close()
    End Sub
End Class