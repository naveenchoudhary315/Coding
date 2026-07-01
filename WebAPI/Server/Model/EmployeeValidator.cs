using FluentValidation;
namespace WebAPI.Server.Model
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                                .MaximumLength(100);

            RuleFor(x => x.Salary).NotEmpty()
                                .GreaterThan(100);
        }
    }
}
