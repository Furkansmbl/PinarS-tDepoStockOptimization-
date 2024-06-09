namespace PinarSutApi.Dtos.PinarDto
{
    public class PinarSutDto
    {
         public string UrunAdi  { get; set; } = null!;

         public int UrunKodu { get; set; }
         public int TalepMiktari { get; set; }
        public string UrunGrubu { get; } = null!;
        public DateTime EklenmeTarihi { get; set; }


    }
}
