using Spire.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddLogoImageToQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            Image barcode = generator.GenerateImage(); ;
            string outputFile = "QRCode.png";
            barcode.Save(outputFile);
            Viewer(outputFile);
        }
        private void Viewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }
    }
}
