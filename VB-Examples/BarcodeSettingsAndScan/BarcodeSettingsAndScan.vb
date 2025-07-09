Imports System.ComponentModel
Imports System.Text
Imports System.Drawing.Drawing2D

Imports Spire.Barcode

Namespace BarcodeLibUtilizationInWinForm
	Partial Public Class Form1
		Inherits Form
		Private bs As New BarcodeSettings()
		Public Sub New()
			InitializeComponent()
			InitializeData()

		End Sub
		Private Sub InitializeData()
			'barcode type
			Dim typeArray As Array = System.Enum.GetNames(GetType(BarCodeType))
			Array.Sort(typeArray)
			For Each value As String In typeArray
				Me.lbBarcodeType.Items.Add(value)
			Next value
			Me.lbBarcodeType.SelectedIndex = 3
			'Font Name
			Dim fonts As New System.Drawing.Text.InstalledFontCollection()
			For Each value As FontFamily In fonts.Families
				Me.cbbFontName.Items.Add(value.Name)
				Me.cBTopTextFontName.Items.Add(value.Name)
				If value.Name="Arial" Then
					Me.cBTopTextFontName.SelectedItem = value.Name
					Me.cbbFontName.SelectedItem = value.Name
				End If
			Next value

			'Font Size
			Me.cBFontSize.SelectedIndex = 5
			Me.cBTopTextFontSize.SelectedIndex = 2
			'Rotation
			Me.rBNone.Checked = True
			'Alignment
			Dim alignmentArray As Array = System.Enum.GetNames(GetType(StringAlignment))
			For Each value As String In alignmentArray
				Me.cBAlignment.Items.Add(value)
				Me.cBTopTextAlignment.Items.Add(value)
			Next value
			Me.cBAlignment.SelectedIndex = 1
			Me.cBTopTextAlignment.SelectedIndex = 1
			'
			If Me.ckShowText.Checked Then
				Me.cKShowTextOnBottom.Enabled = True
				Me.cKShowTextOnBottom.Checked = True
			End If
			'
			ckShowTopText.Checked = True
			'
			cBFontColor.SelectedIndex = 34
			'
			ccbTopTextFontColor.SelectedIndex = 34
			'
			ccbBarColor.SelectedIndex = 34
			'
			txtBarHeight.Text = "15.0"
			txtBarWidth.Text = "1"
			'
			nudDpi.Value = 96
			'
			Me.txtTopText.Text = "Spire.BarCode Evaluation Version"
			Dim BCG As New BarCodeGenerator(bs)
			Me.pictureBox1.Image = BCG.GenerateImage()
			Me.pictureBox2.Image = BCG.GenerateImage()
			Me.txtScanResult.Text = BarcodeScanner.ScanOne(TryCast(Me.pictureBox2.Image, Bitmap))
		End Sub
		Private Sub lbBarcodeType_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbBarcodeType.SelectedValueChanged
			Dim barcodeType As String = Me.lbBarcodeType.SelectedItem.ToString()
			bs.Type = CType(System.Enum.Parse(GetType(BarCodeType), barcodeType), BarCodeType)
			BarcodeDataSetting()


		End Sub

		Private Sub BarcodeDataSetting()
			If Me.txtBarcodeData.Text.Length > 0 Then
				bs.Data = Me.txtBarcodeData.Text

			Else

				bs.Data = "12345"

			End If
		End Sub

		Private Sub tSBSaveBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tSBSaveBarcode.Click
			Dim bcg As New BarCodeGenerator(bs)
			Dim sf As New SaveFileDialog()
			sf.Filter = "Bitmap Image(*.bmp)|*.bmp|JPEG Image(*.jpg)|*.jpg|PNG Image(*.png)|*.png"
            If sf.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bcg.GenerateImage().Save(sf.FileName)
            End If
		End Sub
		Private Sub ckShowText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ckShowText.CheckedChanged
			If ckShowText.Checked Then
				bs.ShowText = True
				Me.cKShowTextOnBottom.Enabled = True
			Else
				bs.ShowText = False
				Me.cKShowTextOnBottom.Enabled = False
				Me.cKShowTextOnBottom.Checked = False
			End If
		End Sub

		Private Sub cKShowTextOnBottom_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cKShowTextOnBottom.CheckedChanged
			If cKShowTextOnBottom.Checked Then
				bs.ShowTextOnBottom = True
			Else
				bs.ShowTextOnBottom = False
			End If
		End Sub

		Private Sub ckShowTopText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ckShowTopText.CheckedChanged
			If ckShowTopText.Checked Then
				bs.ShowTopText = True
			Else
				bs.ShowTopText = False
			End If
		End Sub

		Private Sub cKBorder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cKBorder.CheckedChanged
			If cKBorder.Checked Then
				bs.HasBorder = True
				Me.gBBorderStyle.Visible = True
				'Border style
				Dim borderStyleArray As Array = System.Enum.GetNames(GetType(DashStyle))
				For Each value As String In borderStyleArray
					Me.cBBorderStyle.Items.Add(value)
				Next value
				Me.cBBorderStyle.SelectedIndex = 0
				Me.ccbBorderColor.SelectedIndex = 0
				bs.BorderColor = ccbBorderColor.SelectColor
				bs.BorderWidth = Single.Parse(Me.txtBorderWidth.Text)
			Else
				bs.HasBorder = False
				Me.gBBorderStyle.Visible = False
			End If
		End Sub

		Private Sub ccbBorderColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbBorderColor.SelectedIndexChanged
			bs.BorderColor = ccbBorderColor.SelectColor
		End Sub

		Private Sub cBBorderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBBorderStyle.SelectedIndexChanged
			Dim borderStyle As String = Me.cBBorderStyle.SelectedItem.ToString()
			bs.BorderDashStyle = CType(System.Enum.Parse(GetType(DashStyle), borderStyle), DashStyle)
		End Sub

		Private Sub txtBorderWidth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBorderWidth.KeyPress
            If Not (((e.KeyChar >= "0"c) AndAlso (e.KeyChar <= "9"c)) OrElse (e.KeyChar <= "31")) Then
                If e.KeyChar = "."c Then
                    If (CType(sender, TextBox)).Text.Trim().IndexOf("."c) > -1 Then
                        e.Handled = True
                    End If

                Else
                    e.Handled = True
                End If
            End If

		End Sub

		Private Sub cbbFontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbbFontName.SelectedIndexChanged
			If Me.cBFontSize.SelectedItem Is Nothing Then
				Me.cBFontSize.SelectedIndex = 0
			End If
			Dim size As Single = Single.Parse(Me.cBFontSize.SelectedItem.ToString())
			Try
				bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), size, bs.TextFont.Style)
			Catch

			End Try

		End Sub

		Private Sub cBFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBFontSize.SelectedIndexChanged

				bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style)


		End Sub

		Private Sub cbBold_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBold.CheckedChanged
			If cbBold.Checked Then
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Or FontStyle.Bold)
				Catch
				End Try
			Else
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Xor FontStyle.Bold)
				Catch
				End Try
			End If
		End Sub

		Private Sub cBItalic_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBItalic.CheckedChanged
			If cBItalic.Checked Then
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Or FontStyle.Italic)
				Catch
				End Try
			Else
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Xor FontStyle.Italic)
				Catch
				End Try
			End If
		End Sub

		Private Sub cBUnderline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBUnderline.CheckedChanged
			If cBUnderline.Checked Then
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Or FontStyle.Underline)
				Catch

				End Try
			Else
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Xor FontStyle.Underline)
				Catch

				End Try
			End If
		End Sub

		Private Sub cBStrikeout_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBStrikeout.CheckedChanged
			If cBStrikeout.Checked Then
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Or FontStyle.Strikeout)
				Catch

				End Try

			Else
				Try
					bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style Xor FontStyle.Strikeout)
				Catch

				End Try
			End If
		End Sub
		Private Sub cBAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBAlignment.SelectedIndexChanged
			Dim textAlignment As String = Me.cBAlignment.SelectedItem.ToString()
			bs.TextAlignment = CType(System.Enum.Parse(GetType(StringAlignment), textAlignment), StringAlignment)
		End Sub

		Private Sub cBTopTextFontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBTopTextFontName.SelectedIndexChanged
			If Me.cBTopTextFontSize.SelectedItem Is Nothing Then
				Me.cBTopTextFontSize.SelectedIndex = 0
			End If
			Dim size As Single = Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString())
			bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), size, bs.TopTextFont.Style)
		End Sub

		Private Sub cBTopTextFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBTopTextFontSize.SelectedIndexChanged
			bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style)
		End Sub

		Private Sub cBTopTextAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBTopTextAlignment.SelectedIndexChanged
			Dim topTextAlignment As String = Me.cBTopTextAlignment.SelectedItem.ToString()
			bs.TopTextAligment = CType(System.Enum.Parse(GetType(StringAlignment), topTextAlignment), StringAlignment)
		End Sub

		Private Sub ccbTopTextFontColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbTopTextFontColor.SelectedIndexChanged
			bs.TopTextColor = Me.ccbTopTextFontColor.SelectColor
		End Sub

		Private Sub ccbBarColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbBarColor.SelectedIndexChanged
			bs.ForeColor = Me.ccbBarColor.SelectColor
		End Sub

		Private Sub ccbBackgroundColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbBackgroundColor.SelectedIndexChanged
			bs.BackColor = Me.ccbBackgroundColor.SelectColor
		End Sub

		Private Sub rBNone_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rBNone.CheckedChanged
			bs.Rotate = 0
		End Sub

		Private Sub rBNine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rBNine.CheckedChanged
			bs.Rotate = 90
		End Sub

		Private Sub rBEight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rBEight.CheckedChanged
			bs.Rotate = 180
		End Sub

		Private Sub rBTwoSeven_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rBTwoSeven.CheckedChanged
			bs.Rotate = 270
		End Sub

		Private Sub nudDpi_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudDpi.ValueChanged
			bs.DpiX = CSng(Me.nudDpi.Value)
			bs.DpiY = CSng(Me.nudDpi.Value)
		End Sub

		Private Sub txtBarHeight_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBarHeight.KeyPress
            If Not (((e.KeyChar >= "0"c) AndAlso (e.KeyChar <= "9"c)) OrElse e.KeyChar <= "31") Then
                If e.KeyChar = "."c Then
                    If (CType(sender, TextBox)).Text.Trim().IndexOf("."c) > -1 Then
                        e.Handled = True
                    End If

                Else
                    e.Handled = True
                End If
            End If

		End Sub

		Private Sub txtBarHeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarHeight.TextChanged
			If txtBarHeight.Text.Length = 0 OrElse txtBarHeight.Text.Trim().IndexOf("."c) = 0 Then
				txtBarHeight.Text = "15.0"
			End If
			bs.BarHeight = Single.Parse(txtBarHeight.Text)
		End Sub
		Private Sub txtBarWidth_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarWidth.TextChanged
			If txtBarWidth.Text.Length = 0 OrElse txtBarWidth.Text = "." Then
				txtBarWidth.Text = "1"
			End If
			bs.X = Single.Parse(txtBarWidth.Text)
		End Sub
		Private Sub txtBarcodeData_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcodeData.TextChanged
			BarcodeDataSetting()
		End Sub

		Private Sub cBFontColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cBFontColor.SelectedIndexChanged
			bs.TextColor = Me.cBFontColor.SelectColor
		End Sub

		Private Sub txtBorderWidth_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBorderWidth.TextChanged
			If Me.txtBorderWidth.Text.Length = 0 OrElse Me.txtBorderWidth.Text.Trim().IndexOf("."c) = 0 Then
				Me.txtBorderWidth.Text = "1"
			End If
			bs.BorderWidth = Single.Parse(Me.txtBorderWidth.Text)
		End Sub

		Private Sub txtBarWidth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBarWidth.KeyPress
            If Not (((e.KeyChar >= "0"c) AndAlso (e.KeyChar <= "9"c)) OrElse e.KeyChar <= "31") Then
                If e.KeyChar = "."c Then
                    If (CType(sender, TextBox)).Text.Trim().IndexOf("."c) > -1 Then
                        e.Handled = True
                    End If

                Else
                    e.Handled = True
                End If
            End If
		End Sub

		Private Sub cbTopTextBold_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopTextBold.CheckedChanged
			If cbTopTextBold.Checked Then
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Or FontStyle.Bold)
			Else
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Xor FontStyle.Bold)
			End If
		End Sub
		Private Sub cbTopTextItalic_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopTextItalic.CheckedChanged
			If cbTopTextItalic.Checked Then
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Or FontStyle.Italic)
			Else
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Xor FontStyle.Italic)
			End If
		End Sub

		Private Sub cbTopTextUnderline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopTextUnderline.CheckedChanged
			If cbTopTextUnderline.Checked Then
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Or FontStyle.Underline)
			Else
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Xor FontStyle.Underline)
			End If
		End Sub

		Private Sub cbTopTextStrikout_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTopTextStrikout.CheckedChanged
			If cbTopTextStrikout.Checked Then
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Or FontStyle.Strikeout)
			Else
				bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style Xor FontStyle.Strikeout)
			End If
		End Sub
		Private Sub txtTopText_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTopText.TextChanged
			If Me.txtTopText.Text.Length = 0 Then
				Me.ckShowTopText.Checked = False
			Else
				Me.ckShowTopText.Checked = True
				bs.TopText = Me.txtTopText.Text
			End If

		End Sub

		Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
			Dim BCG As New BarCodeGenerator(bs)
			Try
				Me.pictureBox1.Image = BCG.GenerateImage()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub btnScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScan.Click
			Dim openDia As New OpenFileDialog()
			openDia.Filter = "Bitmap Image(*.bmp)|*.bmp|JPEG Image(*.jpg)|*.jpg|PNG Image(*.png)|*.png"
            If openDia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.pictureBox2.Image = Image.FromFile(openDia.FileName)
                Dim scanResult As String = BarcodeScanner.ScanOne(openDia.FileName)
                Me.txtScanResult.Text = scanResult
            End If
		End Sub

	End Class
End Namespace
