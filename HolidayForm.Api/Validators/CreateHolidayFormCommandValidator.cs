using FluentValidation;
using System;

namespace HolidayPlanner.Api.Validators
{
    public class CreateHolidayFormCommandValidator : AbstractValidator<CreateHolidayFormCommand>
    {
        public CreateHolidayFormCommandValidator()
        {

            RuleFor(x => x.RequestBy)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Department)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Position)
                .NotEmpty()
                .NotNull();
                //.Must(BeAValidRole).WithMessage("The position given is not a valid role");

            RuleFor(x => x.FlexibleHolidayAmount)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.VacationDayAmount)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.DateFrom)
                .NotEmpty()
                .NotNull();
                //.GreaterThan(DateTime.Now);

            RuleFor(x => x.DateTo)
                .NotEmpty()
                .NotNull();
                //.GreaterThan(x => x.DateFrom);

            RuleFor(x => x.EmployeeSignatureUrl)
                .NotEmpty()
                .NotNull();
        }



        private bool BeAValidRole(string input)
        {
            if (input.ToUpper() == "DEV")
            {
                return true;
            }
            else if (input.ToUpper() == "MANAGER")
            {
                return true;
            }

            return false;
        }
    }
}
