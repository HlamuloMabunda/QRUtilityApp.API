using QRUtilityApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRUtilityApp.Domain.Interfaces
{
    public interface IImageService
    {
        byte[] GenerateQRCode(QRData data);

    }
}