using Microsoft.AspNetCore.Mvc;
using foodapp_netcore.Models;

namespace foodapp_netcore.Controllers;

[ApiController]
[Route("[controller]")]
public class ReviewsController : ControllerBase 
{

    [HttpGet (Name = "GetReview")]
    public async Task<IActionResult> GetReview()
    {
        var reviews = new ReviewsModel{
                        Id = 0,
                        BrandName = "",
                        TasteRating = 0,
                        NutritionRating = 0,
                        PriceRating = 0,
                        ApprovalRating = 0,
                        LogoLink = ""
                    };
        

        return Ok(reviews);
    }
}