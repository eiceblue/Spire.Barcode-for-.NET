Imports System.ComponentModel
Imports System.Text
Imports System.Drawing.Drawing2D

Imports Spire.Barcode

Namespace BarcodeLibUtilizationInWinForm
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim bs As New BarcodeSettings()
            bs.Type = BarCodeType.Code25
            bs.Data = "12345"
			Dim bg As New BarCodeGenerator(bs)
			bg.GenerateImage().Save("Code25Code.png")
			Process.Start("Code25Code.png")
		End Sub
	End Class
End Namespace
