Imports Spire.Barcode
Imports System.ComponentModel
Imports System.Text

Namespace AddLogoImageToQRCode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim barCodeSetting As New BarcodeSettings()
			barCodeSetting.Type = BarCodeType.QRCode
			barCodeSetting.BackColor = Color.WhiteSmoke
			barCodeSetting.QRCodeDataMode = QRCodeDataMode.Byte
			barCodeSetting.QRCodeECL = QRCodeECL.M
			barCodeSetting.ShowTextOnBottom = True

			barCodeSetting.X = 3
			Dim data As String = "ABC 123456789"
			barCodeSetting.Data2D = data
			barCodeSetting.Data = data
			barCodeSetting.QRCodeLogoImage = Image.FromFile("..\..\..\..\..\..\..\Data\Logo.png")
			Dim generator As New BarCodeGenerator(barCodeSetting)
			Dim barcode As Image = generator.GenerateImage()

			Dim outputFile As String = "QRCode.png"
			barcode.Save(outputFile)
			Viewer(outputFile)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
