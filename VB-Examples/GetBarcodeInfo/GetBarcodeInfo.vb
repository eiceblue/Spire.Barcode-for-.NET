Imports System.Text

Imports Spire.Barcode
Imports Spire.Barcode.Settings
Imports System.IO

Namespace GetBarcodeInfo
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			' Load barcode image
			Dim barcodeInfos() As BarcodeInfo = BarcodeScanner.ScanInfo("..\..\..\..\..\Data\GetBarcodeInfo.png")
			Dim stringBuilder As New StringBuilder()

			Dim point As String = ""
			Dim dataString As String = ""
			Dim vertexes() As Point = Nothing
			Dim barCodeReadType As BarCodeReadType = 0

			' Get barcode information
			For Each barcodeInfo As BarcodeInfo In barcodeInfos
				barCodeReadType = barcodeInfo.BarCodeReadType
				vertexes = barcodeInfo.Vertexes
				dataString = barcodeInfo.DataString

			Next barcodeInfo
			' Get vertexes
			For i As Integer = 0 To vertexes.Length - 1
				point &= vertexes(i).ToString()

			Next i

			'Add barcode information string to StringBuilder
			stringBuilder.AppendLine("barCodeReadType：" & barCodeReadType.ToString())
			stringBuilder.AppendLine("vertexes：" & point)
			stringBuilder.AppendLine("dataString：" & dataString)
			Dim result As String = "BarcodeInfo.txt"

			'Save them to a txt file
			File.WriteAllText(result, stringBuilder.ToString())

			'Launching the txt file.
			TextViewer(result)
		End Sub
		Private Sub TextViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
