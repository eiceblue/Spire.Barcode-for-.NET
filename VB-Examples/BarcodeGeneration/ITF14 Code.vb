﻿Imports System.ComponentModel
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
            bs.Type = BarCodeType.ITF14
            bs.Data = "12345"
      'vertical bar
			bs.ITF14BearerBars = ITF14BorderType.Frame
			'horizontal bar
			'bs.ITF14BearerBars = ITF14BorderType.Bar
			Dim bg As New BarCodeGenerator(bs)
			bg.GenerateImage().Save("ITF14Code.png")
			Process.Start("ITF14Code.png")
		End Sub
	End Class
End Namespace
