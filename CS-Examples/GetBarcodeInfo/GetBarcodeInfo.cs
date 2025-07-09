using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Spire.Barcode;
using Spire.Barcode.Settings;
using System.IO;

namespace GetBarcodeInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            // Load barcode image
            BarcodeInfo[] barcodeInfos = BarcodeScanner.ScanInfo(@"..\..\..\..\..\Data\GetBarcodeInfo.png");
            StringBuilder stringBuilder = new StringBuilder();

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

            //Add barcode information string to StringBuilder
            stringBuilder.AppendLine("barCodeReadType：" + barCodeReadType.ToString());
            stringBuilder.AppendLine("vertexes：" + point);
            stringBuilder.AppendLine("dataString：" + dataString);
            String result = "BarcodeInfo.txt";

            //Save them to a txt file
            File.WriteAllText(result, stringBuilder.ToString());

            //Launching the txt file.
            TextViewer(result);
        }
        private void TextViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }

    }
}
