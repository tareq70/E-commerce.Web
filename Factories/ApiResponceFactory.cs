using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Web.Factories
{
    public static class ApiResponceFactory
    {
        public static IActionResult GenerateApiValidationErrorResponse(ActionContext context)
        {
            var errors = context.ModelState
                .Where(e => e.Value.Errors.Any())
                .Select(e => new Shared.Error_Models.ValidationError
                {
                    Field = e.Key,
                    Errors = e.Value.Errors.Select(x => x.ErrorMessage)
                });
            var errorResponse = new Shared.Error_Models.ValidationErrorToReturn
            {
                validationErrors = errors,
            };
            return new BadRequestObjectResult(errorResponse);
        }


    }
}
