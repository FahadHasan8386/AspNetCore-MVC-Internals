using System.ComponentModel.DataAnnotations;

namespace StudentMangementSystem.Attribute
{
    public class GenderBasedAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance;

            var genderProperty = model.GetType().GetProperty("Gender");
            var gender = genderProperty?.GetValue(model)?.ToString();

            if (value == null)
            {
                return new ValidationResult("Age is required.");
            }

            int age = Convert.ToInt32(value);

            if (age > 100)
            {
                return new ValidationResult("Age cannot exceed 100.");
            }

            if (gender == "Male" && age < 21)
            {
                return new ValidationResult(
                    "Male must be at least 21 years old.");
            }

            if (gender == "Female" && age < 18)
            {
                return new ValidationResult(
                    "Female must be at least 18 years old.");
            }

            if (gender == "Other" && age < 18)
            {
                return new ValidationResult(
                    "Age must be at least 18 years old.");
            }

            return ValidationResult.Success;
        }
    }
}
