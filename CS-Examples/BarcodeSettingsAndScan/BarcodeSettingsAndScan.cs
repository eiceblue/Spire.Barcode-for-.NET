using System;
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
        BarcodeSettings bs = new BarcodeSettings();
        
        public Form1()
        {
            InitializeComponent();
            InitializeData();

        }
        private void InitializeData()
        {
            //barcode type
            Array typeArray = Enum.GetNames(typeof(BarCodeType));
            Array.Sort(typeArray);
            foreach (string value in typeArray)
            {
                this.lbBarcodeType.Items.Add(value);
            }
            this.lbBarcodeType.SelectedIndex = 3;
            //Font Name
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily value in fonts.Families)
            {
                this.cbbFontName.Items.Add(value.Name);
                this.cBTopTextFontName.Items.Add(value.Name);
                if(value.Name=="Arial")
                {
                    this.cBTopTextFontName.SelectedItem = value.Name;
                    this.cbbFontName.SelectedItem = value.Name;
                }
            }
            
            //Font Size
            this.cBFontSize.SelectedIndex = 5;
            this.cBTopTextFontSize.SelectedIndex = 2;
            //Rotation
            this.rBNone.Checked = true;
            //Alignment
            Array alignmentArray = Enum.GetNames(typeof(StringAlignment));
            foreach (string value in alignmentArray)
            {
                this.cBAlignment.Items.Add(value);
                this.cBTopTextAlignment.Items.Add(value);
            }
            this.cBAlignment.SelectedIndex = 1;
            this.cBTopTextAlignment.SelectedIndex = 1;
            //
            if (this.ckShowText.Checked)
            {
                this.cKShowTextOnBottom.Enabled = true;
                this.cKShowTextOnBottom.Checked = true;
            }
            
            //
            ckShowTopText.Checked = true;
            //
            cBFontColor.SelectedIndex = 34;
            //
            ccbTopTextFontColor.SelectedIndex = 34;
            //
            ccbBarColor.SelectedIndex = 34;
            //
            txtBarHeight.Text = "15.0";
            txtBarWidth.Text = "1";
            //
            nudDpi.Value = 96;
            //
            this.txtTopText.Text = "Spire.BarCode Evaluation Version";
            BarCodeGenerator BCG = new BarCodeGenerator(bs);
            this.pictureBox1.Image = BCG.GenerateImage();
            this.pictureBox2.Image = BCG.GenerateImage();
            this.txtScanResult.Text = BarcodeScanner.ScanOne(this.pictureBox2.Image as Bitmap);
        }
        private void lbBarcodeType_SelectedValueChanged(object sender, EventArgs e)
        {
            string barcodeType = this.lbBarcodeType.SelectedItem.ToString();
            bs.Type = (BarCodeType)Enum.Parse(typeof(BarCodeType), barcodeType);
            BarcodeDataSetting();


        }

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
        private void ckShowText_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowText.Checked)
            {
                bs.ShowText = true;
                this.cKShowTextOnBottom.Enabled = true;
            }
            else
            {
                bs.ShowText = false;
                this.cKShowTextOnBottom.Enabled = false;
                this.cKShowTextOnBottom.Checked = false;
            }
        }

        private void cKShowTextOnBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (cKShowTextOnBottom.Checked)
            {
                bs.ShowTextOnBottom = true;
            }
            else
            {
                bs.ShowTextOnBottom = false;
            }
        }

        private void ckShowTopText_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowTopText.Checked)
            {
                bs.ShowTopText = true;
            }
            else
            {
                bs.ShowTopText = false;
            }
        }

        private void cKBorder_CheckedChanged(object sender, EventArgs e)
        {
            if (cKBorder.Checked)
            {
                bs.HasBorder = true;
                this.gBBorderStyle.Visible = true;
                //Border style
                Array borderStyleArray = Enum.GetNames(typeof(DashStyle));
                foreach (string value in borderStyleArray)
                {
                    this.cBBorderStyle.Items.Add(value);
                }
                this.cBBorderStyle.SelectedIndex = 0;
                this.ccbBorderColor.SelectedIndex = 0;
                bs.BorderColor = ccbBorderColor.SelectColor;
                bs.BorderWidth = float.Parse(this.txtBorderWidth.Text);
            }
            else
            {
                bs.HasBorder = false;
                this.gBBorderStyle.Visible = false;
            }
        }

        private void ccbBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.BorderColor = ccbBorderColor.SelectColor;
        }

        private void cBBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string borderStyle = this.cBBorderStyle.SelectedItem.ToString();
            bs.BorderDashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), borderStyle);
        }

        private void txtBorderWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;

                }
                else
                    e.Handled = true;
            }

        }

        private void cbbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cBFontSize.SelectedItem == null)
            {
                this.cBFontSize.SelectedIndex = 0;
            }
            float size = float.Parse(this.cBFontSize.SelectedItem.ToString());
            try
            {
                bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), size, bs.TextFont.Style);
            }
            catch
            {
               
            }

        }

        private void cBFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style);
            

        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBold.Checked)
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style | FontStyle.Bold);
                }
                catch { }
            }
            else
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style ^ FontStyle.Bold);
                }
                catch { }
            }
        }

        private void cBItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cBItalic.Checked)
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style | FontStyle.Italic);
                }
                catch { }
            }
            else
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style ^ FontStyle.Italic);
                }
                catch { }
            }
        }

        private void cBUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cBUnderline.Checked)
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style | FontStyle.Underline);
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style ^ FontStyle.Underline);
                }
                catch
                {

                }
            }
        }

        private void cBStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (cBStrikeout.Checked)
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style | FontStyle.Strikeout);
                }
                catch
                {

                }

            }
            else
            {
                try
                {
                    bs.TextFont = new Font(this.cbbFontName.SelectedItem.ToString(), float.Parse(this.cBFontSize.SelectedItem.ToString()), bs.TextFont.Style ^ FontStyle.Strikeout);
                }
                catch
                {

                }
            }
        }
        private void cBAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textAlignment = this.cBAlignment.SelectedItem.ToString();
            bs.TextAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), textAlignment);
        }

        private void cBTopTextFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cBTopTextFontSize.SelectedItem == null)
            {
                this.cBTopTextFontSize.SelectedIndex = 0;
            }
            float size = float.Parse(this.cBTopTextFontSize.SelectedItem.ToString());
            bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), size, bs.TopTextFont.Style);
        }

        private void cBTopTextFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style);
        }

        private void cBTopTextAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string topTextAlignment = this.cBTopTextAlignment.SelectedItem.ToString();
            bs.TopTextAligment = (StringAlignment)Enum.Parse(typeof(StringAlignment), topTextAlignment);
        }

        private void ccbTopTextFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.TopTextColor = this.ccbTopTextFontColor.SelectColor;
        }

        private void ccbBarColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.ForeColor = this.ccbBarColor.SelectColor;
        }

        private void ccbBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.BackColor = this.ccbBackgroundColor.SelectColor;
        }

        private void rBNone_CheckedChanged(object sender, EventArgs e)
        {
            bs.Rotate = 0;
        }

        private void rBNine_CheckedChanged(object sender, EventArgs e)
        {
            bs.Rotate = 90;
        }

        private void rBEight_CheckedChanged(object sender, EventArgs e)
        {
            bs.Rotate = 180;
        }

        private void rBTwoSeven_CheckedChanged(object sender, EventArgs e)
        {
            bs.Rotate = 270;
        }

        private void nudDpi_ValueChanged(object sender, EventArgs e)
        {
            bs.DpiX = (float)this.nudDpi.Value;
            bs.DpiY = (float)this.nudDpi.Value;
        }

        private void txtBarHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;

                }
                else
                    e.Handled = true;
            }

        }

        private void txtBarHeight_TextChanged(object sender, EventArgs e)
        {
            if (txtBarHeight.Text.Length == 0 || txtBarHeight.Text.Trim().IndexOf('.') == 0)
            {
                txtBarHeight.Text = "15.0";
            }
            bs.BarHeight = float.Parse(txtBarHeight.Text);
        }
        private void txtBarWidth_TextChanged(object sender, EventArgs e)
        {
            if (txtBarWidth.Text.Length == 0 || txtBarWidth.Text == ".")
            {
                txtBarWidth.Text = "1";
            }
            bs.X = float.Parse(txtBarWidth.Text);
        }
        private void txtBarcodeData_TextChanged(object sender, EventArgs e)
        {
            BarcodeDataSetting();
        }

        private void cBFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.TextColor = this.cBFontColor.SelectColor;
        }

        private void txtBorderWidth_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBorderWidth.Text.Length == 0 || this.txtBorderWidth.Text.Trim().IndexOf('.') == 0)
            {
                this.txtBorderWidth.Text = "1";
            }
            bs.BorderWidth = float.Parse(this.txtBorderWidth.Text);
        }

        private void txtBarWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;

                }
                else
                    e.Handled = true;
            }
        }

        private void cbTopTextBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopTextBold.Checked)
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style | FontStyle.Bold);
            }
            else
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style ^ FontStyle.Bold);
            }
        }
        private void cbTopTextItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopTextItalic.Checked)
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style | FontStyle.Italic);
            }
            else
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style ^ FontStyle.Italic);
            }
        }

        private void cbTopTextUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopTextUnderline.Checked)
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style | FontStyle.Underline);
            }
            else
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style ^ FontStyle.Underline);
            }
        }

        private void cbTopTextStrikout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopTextStrikout.Checked)
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style | FontStyle.Strikeout);
            }
            else
            {
                bs.TopTextFont = new Font(this.cBTopTextFontName.SelectedItem.ToString(), float.Parse(this.cBTopTextFontSize.SelectedItem.ToString()), bs.TopTextFont.Style ^ FontStyle.Strikeout);
            }
        }
        private void txtTopText_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTopText.Text.Length == 0)
            {
                this.ckShowTopText.Checked = false;
            }
            else
            {
                this.ckShowTopText.Checked = true;
                bs.TopText = this.txtTopText.Text;
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

    }
}
