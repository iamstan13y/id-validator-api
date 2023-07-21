using IDValidator.API.Models.Local;
using System.Text.RegularExpressions;

namespace IDValidator.API.Services;

public class ValidatorService : IValidatorService
{
    public Result<ValidationResponse> CheckAuthenticityAsync(string idNumber)
    {
        if (string.IsNullOrEmpty(idNumber)) return new Result<ValidationResponse>(false, "Provide an ID Number.");
        
        var digits = Regex.Match(idNumber, @"\d+").Value;

        if (digits.Length != 9) return new Result<ValidationResponse>(false, "ID Number length is invalid.");

        var remainder = int.Parse(digits) % 23;

        var letter = remainder switch
        {
            0 => "Z",
            1 => "A",
            2 => "B",
            3 => "C",
            4 => "D",
            5 => "E",
            6 => "F",
            7 => "G",
            8 => "H",
            9 => "J",
            10 => "K",
            11 => "L",
            12 => "M",
            13 => "N",
            14 => "P",
            15 => "Q",
            16 => "R",
            17 => "S",
            18 => "T",
            19 => "V",
            20 => "W",
            21 => "X",
            22 => "Y",
            23 => "Z",
            _ => throw new ArgumentException("Invalid remainder"),
        };

        var isValid = letter == idNumber[^3].ToString();
        var message = isValid ? "ID number is authentic." : "ID number is probably fake.";

        var result = new ValidationResponse
        {
            IsValid = isValid,
            IdNumber = idNumber
        };

        return new Result<ValidationResponse>(result, message);
    }
}