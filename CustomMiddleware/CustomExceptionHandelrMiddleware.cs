using Azure;
using Domain_Layer.Exceptions;
using Shared.Error_Models;

namespace E_commerce.Web.CustomMiddleware
{
    public class CustomExceptionHandelrMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionHandelrMiddleware> _logger;

        public CustomExceptionHandelrMiddleware(RequestDelegate next, ILogger<CustomExceptionHandelrMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);

                await HandleNotFoundEndPointAsync(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred while processing the request.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {

            var Response = new ErrorToReturn()
            {
                ErrorMessage = ex.Message
            };
            //Set Status Code
            Response.StatusCode = ex switch
            {

            //Create Error Response Object
            

                NotFoundException => StatusCodes.Status404NotFound,
                UnauthorizedException => StatusCodes.Status401Unauthorized,
                BadRequestException badRequestException => GetBadRequestObject(badRequestException, Response),
                
                _ => StatusCodes.Status500InternalServerError
            };
            //Set Content Type


            //Write the error response to the response body
            await context.Response.WriteAsJsonAsync(Response);
        }

        private static int GetBadRequestObject(BadRequestException badRequestException, ErrorToReturn response)
        {
            response.Errors = badRequestException.Errors;

            return StatusCodes.Status400BadRequest;
        }

        private static async Task HandleNotFoundEndPointAsync(HttpContext context)
        {
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                var errorResponse = new ErrorToReturn()
                {
                    StatusCode = context.Response.StatusCode,
                    ErrorMessage = $"EndPoint {context.Request.Path} is not found"
                };

                await context.Response.WriteAsJsonAsync(errorResponse);
            }
        }
    }
}
