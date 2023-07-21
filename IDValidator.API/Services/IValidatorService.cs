using IDValidator.API.Models.Local;

namespace IDValidator.API.Services;

public interface IValidatorService
{
    Result<ValidationResponse> CheckAuthenticityAsync(string idNumber);
}