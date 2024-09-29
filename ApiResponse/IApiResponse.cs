using ApiResponse;

public interface IApiResponse
{
    public ResponseModel SuccessResponse(object data, string message);

    public ResponseModel ErrorResponse(object data, string message);
}