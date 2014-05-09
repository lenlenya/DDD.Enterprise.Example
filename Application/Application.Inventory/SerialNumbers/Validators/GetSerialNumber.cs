﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Inventory.SerialNumbers.Validators
{
    public class GetSerialNumber : AbstractValidator<Queries.GetSerialNumber>
    {
        public GetSerialNumber()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}