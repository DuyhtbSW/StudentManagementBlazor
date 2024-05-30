using System;
using System.ComponentModel.DataAnnotations;

public class DateRangeAttribute : ValidationAttribute
{
    private readonly int _minYear;


    public DateRangeAttribute(int minYear, int maxYear)
    {
        _minYear = minYear;
      
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            var currentYear = DateTime.Now.Year;
            if (date.Year >= currentYear - _minYear && date.Year <= currentYear )
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"Date of Birth Wrong, please choose again.");
            }
        }
        return new ValidationResult("Invalid date format.");
    }
}
