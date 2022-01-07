using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Core.Features.Employee
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
                return null;

            return new ValidationResult(ErrorMessage = base.ErrorMessage, new[] { validationContext.MemberName });
        }
    }

}
