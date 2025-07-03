using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRUtilityApp.Domain.Entities;
using QRUtilityApp.Domain.Interfaces;

namespace QRUtilityApp.Service.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageService _repository;

        public ImageService(IImageService repository)
        {
            _repository = repository;
        }

        public byte[] GenerateQRCode(QRData data)
        {
            return _repository.GenerateQRCode(data);
        }
        
    }
}