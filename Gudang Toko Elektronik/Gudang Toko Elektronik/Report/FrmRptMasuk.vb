Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptMasuk

    Private Sub FrmRptMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("E:\Semester Pendek 4-5\Client - Server\Proyek\Gudang Toko Elektronik\Gudang Toko Elektronik\Report\FrmRptTransMasuk.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class