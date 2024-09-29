using ApiResponse.Enums;
using NUnit.Framework;

namespace ApiResponseTests
{
    public class ApiResponseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SuccessResponse()
        {
            IApiResponse apiResponse = new ApiResponse.ApiResponse();
            var response = apiResponse.SuccessResponse("Success object", "Success message");

            Assert.IsNotNull(response);
            Assert.AreEqual(response.ResponseType, ResponseTypes.Success);
        }
    }
}