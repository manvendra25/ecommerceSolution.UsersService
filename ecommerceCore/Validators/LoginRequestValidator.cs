﻿using ecommerceCore.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceCore.Validators;
public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        //Email
        RuleFor(temp => temp.Email)
          .NotEmpty().WithMessage("Email is required")
          .EmailAddress().WithMessage("Invalid email address format")
          ;

        //Password
        RuleFor(temp => temp.Password)
          .NotEmpty().WithMessage("Password is required")
          ;
    }
}