using System.ComponentModel.DataAnnotations;

namespace StudentMangementSystem.Attribute
{
    public class MaxValueAttribute : ValidationAttribute
    {
        private readonly int _maxValue;
        public MaxValueAttribute(int maxValue)
        {
            _maxValue = maxValue;
            ErrorMessage = $"The value must be less than or equal to {_maxValue}.";
        }

        public override bool IsValid(object? value)
        {
            if(value == null)
            {
                return true;
            }
            if(value is not int number)
            {
                return false;
            }

            return number <= _maxValue;
        }

    }
}
