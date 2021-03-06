﻿using Demo.Library.Responses;
using ServiceStack;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Configuration.AccountType.Validators
{
    public class ChangeDeferral : AbstractValidator<Services.ChangeDeferral>
    {
        public ChangeDeferral()
        {
            RuleFor(x => x.AccountTypeId).NotEmpty();
            RuleFor(x => x.DeferralMethod).NotEmpty();
        }
    }
}