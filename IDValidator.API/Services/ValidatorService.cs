using IDValidator.API.Models.Local;

namespace IDValidator.API.Services;

public class ValidatorService : IValidatorService
{
    public Task<Result<bool>> CheckAuthenticityAsync(string idNumber)
    {
        throw new NotImplementedException();
    }
}