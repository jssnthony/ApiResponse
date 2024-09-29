using ApiResponse.Enums;

namespace ApiResponse
{
    public class ApiResponse : IApiResponse
    {
        public ResponseModel SuccessResponse(object data, string message)
        {
            var model = new ResponseModel();
            model.ResponseType = ResponseTypes.Success;
            model.Data = data;
            model.ErrorMessage = message;
            return model;
        }

        public ResponseModel ErrorResponse(object data, string message)
        {
            var model = new ResponseModel();
            model.ResponseType = ResponseTypes.Error;
            model.Data = data;
            model.ErrorMessage = message;
            return model;
        }
    }
}
