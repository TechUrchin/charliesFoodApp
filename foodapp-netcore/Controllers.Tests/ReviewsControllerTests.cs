using NUnit.Framework;
using foodapp_netcore.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;

namespace foodapp_netcore.Controllers.Tests
{
    [TestFixture]
    public class ReviewsController_Tests
    {
        private ReviewsController _reviewsController;

        // Arrange
        [SetUp]
        public void SetUp()
        {
            _reviewsController = new ReviewsController();
        }

        [Test]
        public async Task IsReview_Empty()
        {
            // Act
            var review = await _reviewsController.GetReview();

            // Assert
            Assert.IsNotNull(review, "Review should not be empty");
        }

        [Test]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            var result = (OkObjectResult) await _reviewsController.GetReview();

            result.StatusCode.Should().Be(200);
        }

        [Test]
        public async Task GetCorrect_ReviewsValues()
        {
            var result = await _reviewsController.GetReview();
        }

        // [Test]
        // public void IsReview_DataTypesCorrect()
        // {
        //     // write test to compare the values of an expected result with the actual result

            
        //     var review = _reviewsController.GetReview();


        //     Assert.AreEqual(expected, review, "Incorrect data input");
        // }

    }
}

