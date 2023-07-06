using EventAgenda.Models.Models.Requests;
using FluentValidation;

namespace EventAgenda.Configurations.Validators.Events
{
    public class CreateEventValidator : AbstractValidator<CreateEventRequest>
    {
        public CreateEventValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty();
            RuleFor(x => x.EndDate).NotEmpty().GreaterThanOrEqualTo(p => p.StartDate);
        }
    }
}