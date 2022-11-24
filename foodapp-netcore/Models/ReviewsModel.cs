namespace foodapp_netcore.Models;

public class ReviewsModel
{
    public int Id {get; set;}
    public string BrandName {get; set;}
    public int TasteRating {get; set;}
    public int NutritionRating {get; set;}
    public int PriceRating {get; set;}
    public int ApprovalRating {get; set;}
    public string LogoLink {get; set;}
}