using IDValidator.API.Models.Local;

namespace IDValidator.API.Services;

public interface IValidatorService
{
    Task<Result<bool>> CheckAuthenticityAsync(string idNumber);
}