Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptBarang

    Private Sub FrmRptBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me. = FormWindowState.Maximized
        Dim rpt As New ReportDocument
        rpt.Load("E:\Semester Pendek 4-5\Client - Server\Proyek\Gudang Toko Elektronik\Gudang Toko Elektronik\Report\rptBarang.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class