namespace PinarSütUı.Dtos.ResultPinarSutDto
{
    public class ResultPinarSutDto
    {
        public string UrunAdi { get; set; } = null!;

        public int UrunKodu { get; set; }
        public int TalepMiktari { get; set; }
        public string UrunGrubu { get; set; } 
        public DateTime EklenmeTarihi { get; set; }


    }
}
