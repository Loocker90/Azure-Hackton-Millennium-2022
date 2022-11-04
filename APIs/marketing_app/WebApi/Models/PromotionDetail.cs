namespace WebApi.Models
{
    public class PromotionDetail
    {
        public int PromoId { get; set; }
        public Coordinates ItemCoordinates { get; set; }
        public string LogoUrl { get; set; }
        public string ItemUrl { get; set; }
        public string BasicInfo { get; set; }
    }
}