using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PinarSutApi.Dtos;
using PinarSutApi.Dtos.PinarDto;
using PinarSutApi.Repository.PinarSütRepository;

namespace PinarSutApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinarSutController : ControllerBase
    {
        private readonly IPinarSütRepository _pinarSütRepository ;
        public PinarSutController(IPinarSütRepository pinarSütRepository )
        {
            _pinarSütRepository = pinarSütRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PinarSütList()
        {
            var values = await _pinarSütRepository.GettAllPinarSütAsync();
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> CreatePinarSüt(CreatePinarSutDto createPinarSutDto)
        {
            _pinarSütRepository.CreatePinarSüt(createPinarSutDto);
            return Ok("Ürün Başarılı Bir Şekilde Eklendi");
        }
        [HttpGet("urun")]
        public async Task<IActionResult> GetUrunGrubuAsync(UrunGrubuDto urunGrubuDto)
        {
            var values = await _pinarSütRepository.GetUrunGrubuAsync( urunGrubuDto);
            return Ok(values);
        }
    }
}
