using Dapper;
using PinarSutApi.Dtos;
using PinarSutApi.Dtos.PinarDto;
using PinarSutApi.Models;

namespace PinarSutApi.Repository.PinarSütRepository
{
    public class PınarSütRepository : IPinarSütRepository
    {
        private readonly context _context;
        public PınarSütRepository (context context)
        {
            _context = context;
        }
        public async void CreatePinarSüt(CreatePinarSutDto createPinarSutDto)
        {
            string query = "UPDATE SutasTablo SET urunAdi = @urunAdi,talepMiktari = @talepMiktari,urungrubu = @urungrubu,eklenmeTarihi = @eklenmeTarihi WHERE urunKodu = @urunKodu";

            var parameters = new DynamicParameters();
            parameters.Add("@urunKodu", createPinarSutDto.UrunKodu);
            parameters.Add("@urunAdi", createPinarSutDto.UrunAdi);
            parameters.Add("@talepMiktari", createPinarSutDto.TalepMiktari);
            parameters.Add("@urungrubu", createPinarSutDto.UrunGrubu);
            parameters.Add("@eklenmeTarihi", createPinarSutDto.EklenmeTarihi);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<PinarSutDto>> GettAllPinarSütAsync()
        {
            string query = "SELECT talepmiktari, urunAdi, urunKodu,urungrubu,eklenmeTarihi FROM SutasTablo ORDER BY talepmiktari DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PinarSutDto> (query);
                return values.ToList();
            }
        }

        public async Task<List<UrunGrubuDto>> GetUrunGrubuAsync(UrunGrubuDto urunGrubuDto)
        {
            string query = "SELECT TOP 25 SUM(talepmiktari) AS toplam_talep, urungrubu FROM SutasTablo GROUP BY urungrubu ORDER BY toplam_talep DESC;";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<UrunGrubuDto>(query);
                return values.ToList();
            }
        }
    }
}
