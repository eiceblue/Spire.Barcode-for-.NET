﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using Spire.Barcode;

namespace BarcodeLibUtilizationInWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeSettings bs = new BarcodeSettings();
            bs.Type = BarCodeType.ITF14;
            bs.Data = "12345";
            //vertical bar
            bs.ITF14BearerBars = ITF14BorderType.Frame;
            //horizontal bar
            //bs.ITF14BearerBars = ITF14BorderType.Bar;
            BarCodeGenerator bg = new BarCodeGenerator(bs);
            bg.GenerateImage().Save("ITF14Code.png");
            System.Diagnostics.Process.Start("ITF14Code.png");
        }
    }
}
