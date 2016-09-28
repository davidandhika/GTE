Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptOpname

    Private Sub FrmRptOpname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("E:\Semester Pendek 4-5\Client - Server\Proyek\Gudang Toko Elektronik\Gudang Toko Elektronik\Report\rptOpname.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class