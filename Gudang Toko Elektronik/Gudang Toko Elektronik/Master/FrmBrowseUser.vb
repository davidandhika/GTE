Imports Oracle.DataAccess.Client
Public Class FrmBrowseUser
    Dim rd As OracleDataReader


    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT * FROM ADMINISTRATOR", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "ID USER"
            .Columns(1).HeaderCell.Value = "USERNAME"
            .Columns(2).HeaderCell.Value = "PASSWORD"
            .Columns(3).HeaderCell.Value = "JABATAN"
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM ADMINISTRATOR WHERE USERNAME LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
       With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "ID USER"
            .Columns(1).HeaderCell.Value = "USERNAME"
            .Columns(2).HeaderCell.Value = "PASSWORD"
            .Columns(3).HeaderCell.Value = "JABATAN"
        End With
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            FrmUser.lblIDUser.Text = DataGridView1.Item(0, barisdgv).Value
            FrmUser.txtUsername.Text = DataGridView1.Item(1, barisdgv).Value
            FrmUser.txtPassword.Text = DataGridView1.Item(2, barisdgv).Value
            FrmUser.cmbJabatan.Text = DataGridView1.Item(3, barisdgv).Value
        End If
        Me.Close()
    End Sub

    Private Sub FrmBrowseUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub
End Class