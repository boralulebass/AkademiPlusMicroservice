using AkademiPlusMicroservice.Services.PhotoStock.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotostocksController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SavePhoto(IFormFile formFile, CancellationToken cancellationToken)
        {
            if(formFile != null && formFile.Length > 0) 
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/photos",formFile.FileName);
                using var stream = new FileStream(path,FileMode.Create);

                await formFile.CopyToAsync(stream,cancellationToken);
                var returnPath = formFile.FileName;
                PhotoDto photoDto = new ()
                {
                    Url = returnPath,            
                };
                return Ok("Fotoğraf başarıyla kaydedildi");
            }
            return BadRequest("Bir hata oluştu");
        }
    }
}
