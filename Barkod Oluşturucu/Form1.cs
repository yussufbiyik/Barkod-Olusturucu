using BarcodeStandard;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var barcode = new Barcode();
            // Formdan barkod detaylarını çek
            byte productType = Convert.ToByte(productTypeInput.Value);
            int manufacturerCode = Convert.ToInt32(manufacturerCodeInput.Value);
            int productCode = Convert.ToInt32(productCodeInput.Value);
            byte barcodeNumber = Convert.ToByte(barcodeNumberInput.Value);
            // Barkod detaylarını tek bir stringde birleştir
            string barcodeString = $"{productType}{manufacturerCode}{productCode}{barcodeNumber}";
            // Barkod görselini oluştur
            var barcodeImage = barcode.Encode(BarcodeStandard.Type.UpcA, barcodeString, SKColors.Black, SKColors.White, 259, 75);
            // Barkod görselini pictureBox'da kullanmak üzere bitmap'e dönüştür
            using (var barcodeImageData = barcodeImage.Encode(SKEncodedImageFormat.Png, 100))
            {
                // Barkod görselini bit dizisine çevir
                byte[] byteArray = barcodeImageData.ToArray();
                // Bit dizisinden stream oluştur
                using (var memoryStream = new System.IO.MemoryStream(byteArray)) {
                    // Stream'den bitmap oluştur ve pictureBox'a ilet
                    Bitmap barcodeImageBitmap = new Bitmap(memoryStream);
                    resultBox.Image = barcodeImageBitmap;
                }
            }
        }
    }
}
