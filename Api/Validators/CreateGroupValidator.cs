using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Services.Group.Command;

namespace Api.Validators
{
    public class CreateGroupValidator:AbstractValidator<CreateGroup>
    {
        public CreateGroupValidator()
        {
            RuleFor(createGroup=>createGroup.GroupName)
                .NotEmpty();
        }
    }
}
