Public Class FrmReport

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAwal.Show()
    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RptBarang_Click(sender As Object, e As EventArgs) Handles RptBarang.Click
        FrmRptBarang.Show()
    End Sub

    Private Sub RptTransMasuk_Click(sender As Object, e As EventArgs) Handles RptTransMasuk.Click
        FrmRptMasuk.Show()
    End Sub

    Private Sub opname_btn_Click(sender As Object, e As EventArgs) Handles opname_btn.Click
        FrmRptOpname.Show()
    End Sub

    Private Sub RptTransKeluar_Click(sender As Object, e As EventArgs) Handles RptTransKeluar.Click
        FrmRptTransKeluar.Show()
    End Sub
End Class