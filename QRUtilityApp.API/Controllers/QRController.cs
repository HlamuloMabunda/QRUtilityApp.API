using Microsoft.AspNetCore.Mvc;
using QRUtilityApp.Domain.Entities;
using QRUtilityApp.Service.Services;


namespace QRUtilityApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QRController : ControllerBase
    {
        private readonly ImageService _imageService;

        public QRController(ImageService imageService)
        {
            _imageService = imageService ?? throw new ArgumentNullException(nameof(imageService));
        }

        [HttpPost("generate-qr")]
        public IActionResult GenerateQRCode([FromBody] QRData data)
        {
            var qrImage = _imageService.GenerateQRCode(data);
            return File(qrImage, "image/png");
        }


    }
}
