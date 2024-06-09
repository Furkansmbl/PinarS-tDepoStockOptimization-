namespace PinarSutApi.Dtos.PinarDto
{
    public class CreatePinarSutDto
    {
        public string UrunAdi { get; set; } = null!;

        public int UrunKodu { get; set; }
        public int TalepMiktari { get; set; }
        public string UrunGrubu { get; set; } = null!;
        public DateTime EklenmeTarihi { get; set; }

    }
}
