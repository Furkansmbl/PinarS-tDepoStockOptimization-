using PinarSutApi.Dtos;
using PinarSutApi.Dtos.PinarDto;

namespace PinarSutApi.Repository.PinarSütRepository
{
    public interface IPinarSütRepository
    {
        Task<List<PinarSutDto>> GettAllPinarSütAsync();
        void CreatePinarSüt(CreatePinarSutDto createPinarSutDto );
        Task<List<UrunGrubuDto>> GetUrunGrubuAsync(UrunGrubuDto urunGrubuDto);


    }
}
