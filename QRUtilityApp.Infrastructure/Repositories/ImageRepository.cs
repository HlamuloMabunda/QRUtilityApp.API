using QRUtilityApp.Domain.Interfaces;
using QRUtilityApp.Domain.Entities;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;


namespace QRUtilityApp.Infrastructure.Repositories
{
    public class ImageRepository : IImageService
    {
        public byte[] GenerateQRCode(QRData data)
        {
            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(data.Content, QRCodeGenerator.ECCLevel.Q);
                var pngQrCode = new PngByteQRCode(qrCodeData);
                return pngQrCode.GetGraphic(20); 
            }
        }

    }
}
