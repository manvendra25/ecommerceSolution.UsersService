﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ecommerceCore.DTO
{
    public record RegisterRequest(
    string? Email,
    string? Password,
    string? PersonName,
    GenderOptions Gender);
}
