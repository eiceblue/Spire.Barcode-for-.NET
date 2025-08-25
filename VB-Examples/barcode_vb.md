# spire.barcode vb.net qr code
## add logo image to QR code
```vbnet
' Create barcode settings
Dim barCodeSetting As New BarcodeSettings()
barCodeSetting.Type = BarCodeType.QRCode
barCodeSetting.QRCodeDataMode = QRCodeDataMode.Byte
barCodeSetting.QRCodeECL = QRCodeECL.M
barCodeSetting.X = 3

' Set barcode data
barCodeSetting.Data2D = "ABC 123456789"
barCodeSetting.Data = "ABC 123456789"

' Add logo image to QR code
barCodeSetting.QRCodeLogoImage = Image.FromFile("..\..\..\..\..\..\..\Data\Logo.png")

' Generate and save barcode image
Dim generator As New BarCodeGenerator(barCodeSetting)
Dim barcode As Image = generator.GenerateImage()
barcode.Save("QRCode.png")
```

---

# spire.barcode vb.net aztec code generation
## generate aztec barcode with specific data and save as image
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.Aztec
bs.Data2D = "12345"

' Generate barcode image
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("AztecCode.png")
```

---

# Spire.Barcode Codabar Generation
## Generate Codabar barcode using Spire.Barcode library
```vbnet
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.Codabar
bs.Data = "12345"
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# vb.net code11 barcode generation
## generate Code11 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to Code11
bs.Type = BarCodeType.Code11

' Set the data to be encoded
bs.Data = "12345"

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# spire barcode vb.net code128
## generate Code128 barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to Code128
bs.Type = BarCodeType.Code128

' Set data to be encoded in the barcode
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# Spire.Barcode Code25 Generation
## Generate Code25 barcode using Spire.Barcode library
```vbnet
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.Code25
bs.Data = "12345"
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# VB.NET Code39 Barcode Generation
## Generate Code39 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to Code39
bs.Type = BarCodeType.Code39

' Set barcode data
bs.Data = "12345"

' Create barcode generator
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
Dim barcodeImage As Image = bg.GenerateImage()
```

---

# Spire.Barcode Code39Extended Generation
## Generate Code39Extended barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to Code39Extended
bs.Type = BarCodeType.Code39Extended

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate and save barcode image
bg.GenerateImage().Save("Code39ExtendedCode.png")
```

---

# vb.net code93 barcode generation
## generate code93 barcode using spire.barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to Code93
bs.Type = BarCodeType.Code93

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# spire.barcode vb.net code93extended
## generate Code93Extended barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.Code93Extended
bs.Data = "12345"

' Generate barcode image
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("Code93ExtendedCode.png")
Process.Start("Code93ExtendedCode.png")
```

---

# vb.net datamatrix barcode generation
## generate datamatrix barcode using spire.barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to DataMatrix
bs.Type = BarCodeType.DataMatrix

' Set the data for the barcode
bs.Data2D = "12345"

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)

' Generate the barcode image
bg.GenerateImage()
```

---

# Spire.Barcode DeutschePost Identcode Generation
## Generate DeutschePost Identcode barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to DeutschePost Identcode
bs.Type = BarCodeType.DeutschePostIdentcode

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)
```

---

# vb.net deutsche post leitcode barcode generation
## generate deutsche post leitcode barcode using spire.barcode
```vbnet
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.DeutschePostLeitcode
bs.Data = "12345"
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# Spire.Barcode EAN128 Generation
## Generate EAN128 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to EAN128
bs.Type = BarCodeType.EAN128

' Set barcode data
bs.Data = "12345"

' Generate barcode
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# EAN13 Barcode Generation
## Generate EAN13 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to EAN13
bs.Type = BarCodeType.EAN13

' Set barcode data
bs.Data = "12345"

' Create barcode generator
Dim bg As New BarCodeGenerator(bs)

' Generate and save barcode image
bg.GenerateImage().Save("EAN13Code.png")
```

---

# vb.net ean14 barcode generation
## generate EAN14 barcode using Spire.Barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to EAN14
bs.Type = BarCodeType.EAN14

' Set barcode data
bs.Data = "12345"

' Create barcode generator
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# spire.barcode vb.net ean8 generation
## generate EAN8 barcode using Spire.Barcode library
```vbnet
Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
    ' Create barcode settings
    Dim bs As New BarcodeSettings()
    
    ' Set barcode type to EAN8
    bs.Type = BarCodeType.EAN8
    
    ' Set barcode data
    bs.Data = "12345"
    
    ' Create barcode generator
    Dim bg As New BarCodeGenerator(bs)
    
    ' Generate barcode image
    bg.GenerateImage()
End Sub
```

---

# Spire.Barcode VB.NET Interleaved 2 of 5 Generation
## Generate Interleaved 2 of 5 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
' Set barcode type to Interleaved 2 of 5
bs.Type = BarCodeType.Interleaved25
' Set barcode data
bs.Data = "12345"
' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)
' Generate barcode image
bg.GenerateImage()
```

---

# ITF14 Barcode Generation
## Generate ITF14 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to ITF14
bs.Type = BarCodeType.ITF14

' Set barcode data
bs.Data = "12345"

' Set ITF14 border type to Frame (vertical bar)
bs.ITF14BearerBars = ITF14BorderType.Frame
' Alternative: Set ITF14 border type to Bar (horizontal bar)
'bs.ITF14BearerBars = ITF14BorderType.Bar

' Generate barcode image and save
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("ITF14Code.png")
```

---

# spire.barcode vb.net itf6 generation
## generate ITF6 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to ITF6
bs.Type = BarCodeType.ITF6

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# Spire.Barcode MSI Code Generation
## Generate MSI barcode using Spire.Barcode library in VB.NET
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
' Set barcode type to MSI
bs.Type = BarCodeType.MSI
' Set barcode data
bs.Data = "12345"
' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)
' Generate the barcode image
bg.GenerateImage()
```

---

# Spire.Barcode VB.NET OPC Code Generation
## Generate OPC barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to OPC
bs.Type = BarCodeType.OPC

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
Dim barcodeImage As Image = bg.GenerateImage()
```

---

# PDF417 Barcode Generation
## Generate PDF417 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
' Set barcode type to PDF417
bs.Type = BarCodeType.Pdf417
' Set data for the barcode
bs.Data2D = "12345"
' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)
' Generate the barcode image
bg.GenerateImage()
```

---

# Spire.Barcode PDF417Macro Generation
## Generate PDF417Macro barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to PDF417Macro
bs.Type = BarCodeType.Pdf417Macro

' Set the data for the barcode
bs.Data2D = "12345"

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)

' Generate the barcode image
bg.GenerateImage()
```

---

# spire.barcode vb.net planet barcode generation
## generate Planet barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.Planet
bs.Data = "12345"

' Generate barcode image
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# PostNet Barcode Generation
## Generate PostNet barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
' Set barcode type to PostNet
bs.Type = BarCodeType.PostNet
' Set barcode data
bs.Data = "12345"
' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)
' Generate the barcode image
bg.GenerateImage()
```

---

# vb.net pzn barcode generation
## generate pzn barcode using spire.barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to PZN
bs.Type = BarCodeType.PZN

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# spire.barcode vb.net qrcode generation
## generate QR code using Spire.Barcode library
```vbnet
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.QRCode
bs.Data2D = "12345"
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("QRCode.png")
```

---

# RoyalMail4State Barcode Generation
## Generate RoyalMail4State barcode using Spire.Barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to RoyalMail4State
bs.Type = BarCodeType.RoyalMail4State

' Set barcode data
bs.Data = "12345"

' Generate barcode and save as image
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("RoyalMail4StateCode.png")
```

---

# spire.barcode vb.net rss14 generation
## generate RSS14 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to RSS14
bs.Type = BarCodeType.RSS14

' Set barcode data
bs.Data = "12345"

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)

' Generate and save the barcode image
bg.GenerateImage().Save("RSS14Code.png")
```

---

# Spire.Barcode RSS14 Truncated Generation
## Generate RSS14 Truncated barcode using Spire.Barcode library
```vbnet
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.RSS14Truncated
bs.Data = "12345"
Dim bg As New BarCodeGenerator(bs)
Dim barcodeImage As Image = bg.GenerateImage()
```

---

# Spire.Barcode RSS Expanded Generation
## Generate RSS Expanded barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to RSS Expanded
bs.Type = BarCodeType.RSSExpanded

' Set the data to be encoded in the barcode
bs.Data = "(12)345678(90)"

' Create barcode generator with the settings
Dim bg As New BarCodeGenerator(bs)

' Generate and save the barcode image
bg.GenerateImage().Save("RSSExpandedCode.png")

' Open the generated image
Process.Start("RSSExpandedCode.png")
```

---

# Spire.Barcode VB.NET Generation
## Generate RSSLimited barcode
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.RSSLimited
bs.Data = "12345"

' Generate barcode and save as image
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage().Save("RSSLimitedCode.png")
```

---

# SCC14 Barcode Generation
## Generate SCC14 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
' Set barcode type to SCC14
bs.Type = BarCodeType.SCC14
' Set barcode data
bs.Data = "12345"
' Create barcode generator
Dim bg As New BarCodeGenerator(bs)
' Generate and save barcode image
bg.GenerateImage().Save("SCC14Code.png")
```

---

# SingaporePost4State Barcode Generation
## Generate SingaporePost4State barcode using Spire.Barcode library
```vbnet
' SingaporePost4State barcode generation
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.SingaporePost4State
bs.Data = "12345"
Dim bg As New BarCodeGenerator(bs)
bg.GenerateImage()
```

---

# SSCC18 Barcode Generation
## Generate SSCC18 barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to SSCC18
bs.Type = BarCodeType.SSCC18

' Set barcode data
bs.Data = "12345"

' Create barcode generator
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# Spire.Barcode SwissPostParcel Generation
## Generate SwissPostParcel barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to SwissPostParcel
bs.Type = BarCodeType.SwissPostParcel

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate and save the barcode image
bg.GenerateImage().Save("SwissPostParcelCode.png")
```

---

# UPCA Barcode Generation
## Generate UPCA type barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()
bs.Type = BarCodeType.UPCA
bs.Data = "12345678901"

' Generate barcode
Dim bg As New BarCodeGenerator(bs)
Dim barcodeImage = bg.GenerateImage()
```

---

# UPCE Barcode Generation
## Generate UPCE barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to UPCE
bs.Type = BarCodeType.UPCE

' Set barcode data
bs.Data = "12345"

' Create barcode generator
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# spire.barcode vb.net usps generation
## generate USPS barcode using Spire.Barcode library
```vbnet
' Create barcode settings
Dim bs As New BarcodeSettings()

' Set barcode type to USPS
bs.Type = BarCodeType.USPS

' Set barcode data
bs.Data = "12345"

' Create barcode generator with settings
Dim bg As New BarCodeGenerator(bs)

' Generate barcode image
bg.GenerateImage()
```

---

# Spire.Barcode VB.NET Implementation
## Barcode generation and scanning functionality
```vbnet
' Barcode settings initialization
Private bs As New BarcodeSettings()

' Set barcode type
Dim barcodeType As String = Me.lbBarcodeType.SelectedItem.ToString()
bs.Type = CType(System.Enum.Parse(GetType(BarCodeType), barcodeType), BarCodeType)

' Set barcode data
If Me.txtBarcodeData.Text.Length > 0 Then
    bs.Data = Me.txtBarcodeData.Text
Else
    bs.Data = "12345"
End If

' Configure text display settings
If ckShowText.Checked Then
    bs.ShowText = True
Else
    bs.ShowText = False
End If

If cKShowTextOnBottom.Checked Then
    bs.ShowTextOnBottom = True
Else
    bs.ShowTextOnBottom = False
End If

' Configure top text settings
If ckShowTopText.Checked Then
    bs.ShowTopText = True
Else
    bs.ShowTopText = False
End If

' Configure border settings
If cKBorder.Checked Then
    bs.HasBorder = True
    bs.BorderColor = ccbBorderColor.SelectColor
    bs.BorderWidth = Single.Parse(Me.txtBorderWidth.Text)
Else
    bs.HasBorder = False
End If

' Configure text font
bs.TextFont = New Font(Me.cbbFontName.SelectedItem.ToString(), Single.Parse(Me.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style)

' Configure text alignment
Dim textAlignment As String = Me.cBAlignment.SelectedItem.ToString()
bs.TextAlignment = CType(System.Enum.Parse(GetType(StringAlignment), textAlignment), StringAlignment)

' Configure top text font
bs.TopTextFont = New Font(Me.cBTopTextFontName.SelectedItem.ToString(), Single.Parse(Me.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style)

' Configure top text alignment
Dim topTextAlignment As String = Me.cBTopTextAlignment.SelectedItem.ToString()
bs.TopTextAligment = CType(System.Enum.Parse(GetType(StringAlignment), topTextAlignment), StringAlignment)

' Configure colors
bs.TopTextColor = Me.ccbTopTextFontColor.SelectColor
bs.ForeColor = Me.ccbBarColor.SelectColor
bs.BackColor = Me.ccbBackgroundColor.SelectColor
bs.TextColor = Me.cBFontColor.SelectColor

' Configure rotation
If rBNone.Checked Then
    bs.Rotate = 0
ElseIf rBNine.Checked Then
    bs.Rotate = 90
ElseIf rBEight.Checked Then
    bs.Rotate = 180
ElseIf rBTwoSeven.Checked Then
    bs.Rotate = 270
End If

' Configure DPI
bs.DpiX = CSng(Me.nudDpi.Value)
bs.DpiY = CSng(Me.nudDpi.Value)

' Configure bar dimensions
bs.BarHeight = Single.Parse(txtBarHeight.Text)
bs.X = Single.Parse(txtBarWidth.Text)

' Generate barcode image
Dim BCG As New BarCodeGenerator(bs)
Me.pictureBox1.Image = BCG.GenerateImage()

' Scan barcode from image
Dim scanResult As String = BarcodeScanner.ScanOne(TryCast(Me.pictureBox2.Image, Bitmap))
Me.txtScanResult.Text = scanResult
```

---

# spire.barcode vb.net barcode info extraction
## extract information from barcode image
```vbnet
' Load barcode image
Dim barcodeInfos() As BarcodeInfo = BarcodeScanner.ScanInfo("..\..\..\..\..\Data\GetBarcodeInfo.png")

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
```

---

