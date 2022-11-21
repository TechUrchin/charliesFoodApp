using NUnit.Framework;
using foodapp_netcore.Controllers;

namespace foodapp_netcore.Controllers.Tests
{
    [TestFixture]
    public class ReviewsController_Tests
    {
        private ReviewsController _reviewsController;

        [SetUp]
        public void SetUp()
        {
            _reviewsController = new ReviewsController();
        }

        [Test]
        public void IsReview_Empty()
        {
            var review = _reviewsController.GetReview();

            Assert.IsNotEmpty(review, "Review should not be empty");
        }

    }
}

