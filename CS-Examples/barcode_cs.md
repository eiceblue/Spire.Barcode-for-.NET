# spire.barcode csharp qr code with logo
## Generate QR code with logo image using Spire.Barcode library
```csharp
BarcodeSettings barCodeSetting = new BarcodeSettings();
barCodeSetting.Type = BarCodeType.QRCode;
barCodeSetting.BackColor = Color.WhiteSmoke;
barCodeSetting.QRCodeDataMode = QRCodeDataMode.Byte;
barCodeSetting.QRCodeECL = QRCodeECL.M;
barCodeSetting.ShowTextOnBottom = true;
barCodeSetting.X = 3;
string data = "ABC 123456789";
barCodeSetting.Data2D = data;
barCodeSetting.Data = data;
barCodeSetting.QRCodeLogoImage = Image.FromFile(@"..\..\..\..\..\..\..\Data\Logo.png");
BarCodeGenerator generator = new BarCodeGenerator(barCodeSetting);
Image barcode = generator.GenerateImage();
```

---

# Spire.Barcode C# Aztec Code Generation
## Generate Aztec barcode using Spire.Barcode library
```csharp
private void button1_Click(object sender, EventArgs e)
{
    BarcodeSettings bs = new BarcodeSettings();
    bs.Type = BarCodeType.Aztec;
    bs.Data2D = "12345";
    BarCodeGenerator bg = new BarCodeGenerator(bs);
    bg.GenerateImage();
}
```

---

# Spire.Barcode Codabar Generation
## Generate Codabar barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Codabar;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("CodabarCode.png");
```

---

# Spire.Barcode C# Code11 Generation
## Generate Code11 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code11;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp code128 generation
## generate Code128 barcode with specific settings
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code128;
bs.Data = "12345";
bs.Code128SetMode = Code128SetMode.Auto;
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("Code128Code.png");
```

---

# Spire.Barcode C# Code25 Generation
## Generate Code25 barcode using Spire.Barcode library
```csharp
// Create barcode settings
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code25;
bs.Data = "12345";

// Generate barcode
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
```

---

# Spire.Barcode C# Code39 Generation
## Generate Code39 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code39;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
```

---

# Spire.Barcode C# Code39Extended Generation
## Generate Code39Extended barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code39Extended;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("Code39ExtendedCode.png");
```

---

# Spire.Barcode Code93 Generation
## Generate Code93 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code93;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode Code93Extended Generation
## Generate Code93Extended barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Code93Extended;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp datamatrix generation
## generate DataMatrix barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.DataMatrix;
bs.Data2D = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("DataMatrixCode.png");
```

---

# Spire.Barcode DeutschePostIdentcode Generation
## Generate DeutschePostIdentcode barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.DeutschePostIdentcode;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("DeutschePostIdentcodeCode.png");
```

---

# Spire.Barcode DeutschePostLeitcode Generation
## Generate Deutsche Post Leitcode barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.DeutschePostLeitcode;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("DeutschePostLeitcodeCode.png");
System.Diagnostics.Process.Start("DeutschePostLeitcodeCode.png");
```

---

# spire.barcode csharp ean128 generation
## Generate EAN128 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.EAN128;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("EAN128Code.png");
```

---

# spire.barcode csharp ean13 generation
## generate EAN13 barcode using Spire.Barcode
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.EAN13;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode EAN14 Generation
## Generate EAN14 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.EAN14;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp ean8 generation
## generate EAN8 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.EAN8;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("EAN8Code.png");
```

---

# spire.barcode csharp interleave25 generation
## Generate Interleaved 2 of 5 barcode using Spire.Barcode
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Interleaved25;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp itf14 generation
## generate ITF14 barcode with bearer bars
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.ITF14;
bs.Data = "12345";
//vertical bar
bs.ITF14BearerBars = ITF14BorderType.Frame;
//horizontal bar
//bs.ITF14BearerBars = ITF14BorderType.Bar;
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("ITF14Code.png");
```

---

# Spire.Barcode ITF6 Generation
## Generate ITF6 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.ITF6;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode C# MSI Code Generation
## Generate MSI barcode using Spire.Barcode library
```csharp
private void button1_Click(object sender, EventArgs e)
{
    BarcodeSettings bs = new BarcodeSettings();
    bs.Type = BarCodeType.MSI;
    bs.Data = "12345";
    BarCodeGenerator bg = new BarCodeGenerator(bs);
    bg.GenerateImage().Save("MSICode.png");
}
```

---

# spire.barcode csharp OPC generation
## generate OPC barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.OPC;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode PDF417 Generation
## Generate PDF417 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Pdf417;
bs.Data2D = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("PDF417Code.png");
```

---

# Spire.Barcode PDF417Macro Generation
## Generate a PDF417Macro barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Pdf417Macro;
bs.Data2D = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
```

---

# Spire.Barcode Planet Code Generation
## Generate Planet barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.Planet;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode PostNet Generation
## Generate PostNet barcode using Spire.Barcode library
```csharp
// Create barcode settings
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.PostNet;
bs.Data = "12345";

// Generate barcode
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
```

---

# Spire.Barcode PZN Generation
## Generate PZN barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.PZN;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode QR Code Generation
## Generate QR code using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.QRCode;
bs.Data2D= "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("QRCode.png");
System.Diagnostics.Process.Start("QRCode.png");
```

---

# spire.barcode royal mail 4-state generation
## generate royal mail 4-state barcode using spire.barcode
```csharp
private void button1_Click(object sender, EventArgs e)
{
    BarcodeSettings bs = new BarcodeSettings();
    bs.Type = BarCodeType.RoyalMail4State;
    bs.Data = "12345";
    BarCodeGenerator bg = new BarCodeGenerator(bs);
    bg.GenerateImage().Save("RoyalMail4StateCode.png");
    System.Diagnostics.Process.Start("RoyalMail4StateCode.png");
}
```

---

# spire.barcode csharp rss14 generation
## generate RSS14 barcode using Spire.Barcode
```csharp
// Create barcode settings
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.RSS14;
bs.Data = "12345";

// Generate barcode
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode RSS14Truncated Generation
## Generate RSS14 Truncated barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.RSS14Truncated;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
```

---

# Spire.Barcode RSS Expanded Generation
## Generate RSS Expanded barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.RSSExpanded;
bs.Data="(12)345678(90)";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp rss limited
## generate RSS Limited barcode
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.RSSLimited;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode SCC14 Generation
## Generate SCC14 barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.SCC14;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("SCC14Code.png");
```

---

# Spire.Barcode Singapore Post 4-State Generation
## Generate Singapore Post 4-State barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.SingaporePost4State;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# Spire.Barcode SSCC18 Generation
## Generate SSCC18 barcode using Spire.Barcode library
```csharp
// Create barcode settings
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.SSCC18;
bs.Data = "12345";

// Generate barcode image
BarCodeGenerator bg = new BarCodeGenerator(bs);
Image barcodeImage = bg.GenerateImage();
barcodeImage.Save("SSCC18Code.png");
```

---

# spire.barcode csharp swiss post parcel
## generate Swiss Post Parcel barcode
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.SwissPostParcel;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage();
```

---

# spire.barcode csharp upca generation
## Generate UPCA barcode using Spire.Barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.UPCA;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("UPCACode.png");
```

---

# spire.barcode upce generation
## generate UPCE barcode using spire.barcode library
```csharp
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.UPCE;
bs.Data = "12345";
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("UPCECode.png");
```

---

# Spire.Barcode C# USPS Barcode Generation
## Generate USPS barcode using Spire.Barcode library
```csharp
// Create barcode settings
BarcodeSettings bs = new BarcodeSettings();
bs.Type = BarCodeType.USPS;
bs.Data = "12345";

// Generate barcode and save as image
BarCodeGenerator bg = new BarCodeGenerator(bs);
bg.GenerateImage().Save("USPSCode.png");
```

---

# spire.barcode csharp settings and scan
## configure barcode settings, generate and scan barcodes
```csharp
BarcodeSettings bs = new BarcodeSettings();

private void BarcodeDataSetting()
{
    if (this.txtBarcodeData.Text.Length > 0)
    {
        bs.Data = this.txtBarcodeData.Text;
    }
    else
    {
        bs.Data = "12345";
    }
}

private void btnGenerate_Click(object sender, EventArgs e)
{
    BarCodeGenerator BCG = new BarCodeGenerator(bs);
    try
    {
        this.pictureBox1.Image = BCG.GenerateImage();
    }
    catch(Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

private void btnScan_Click(object sender, EventArgs e)
{
    OpenFileDialog openDia = new OpenFileDialog();
    openDia.Filter = "Bitmap Image(*.bmp)|*.bmp|JPEG Image(*.jpg)|*.jpg|PNG Image(*.png)|*.png";
    if (openDia.ShowDialog() == DialogResult.OK)
    {
        this.pictureBox2.Image = Image.FromFile(openDia.FileName);
        string scanResult = BarcodeScanner.ScanOne(openDia.FileName);
        this.txtScanResult.Text = scanResult;
    }
}

private void tSBSaveBarcode_Click(object sender, EventArgs e)
{
    BarCodeGenerator bcg = new BarCodeGenerator(bs);
    SaveFileDialog sf = new SaveFileDialog();
    sf.Filter = "Bitmap Image(*.bmp)|*.bmp|JPEG Image(*.jpg)|*.jpg|PNG Image(*.png)|*.png";
    if (sf.ShowDialog() == DialogResult.OK)
    {
        bcg.GenerateImage().Save(sf.FileName);
    }
}
```

---

# spire.barcode csharp barcode scanning
## extract barcode information from image
```csharp
// Load barcode image
BarcodeInfo[] barcodeInfos = BarcodeScanner.ScanInfo(@"..\..\..\..\..\Data\GetBarcodeInfo.png");

string point = "";
string dataString = "";
Point[] vertexes = null;
BarCodeReadType barCodeReadType = 0;

// Get barcode information
foreach (BarcodeInfo barcodeInfo in barcodeInfos)
{
    barCodeReadType = barcodeInfo.BarCodeReadType;
    vertexes = barcodeInfo.Vertexes;
    dataString = barcodeInfo.DataString;
}

// Get vertexes
for (int i = 0; i < vertexes.Length; i++)
{
    point += vertexes[i].ToString();
}
```

---

