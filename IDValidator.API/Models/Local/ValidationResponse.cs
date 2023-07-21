namespace IDValidator.API.Models.Local;

public class ValidationResponse
{
    public bool IsValid { get; set; } = false;
    public string? IdNumber { get; set; }
}