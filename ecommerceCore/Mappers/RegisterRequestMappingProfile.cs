﻿using AutoMapper;
using ecommerceCore.DTO;
using ecommerceCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceCore.Mappers;

    public class RegisterRequestMappingProfile : Profile
    {
        public RegisterRequestMappingProfile()
        {
            CreateMap<RegisterRequest, ApplicationUser>()
              .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
              .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
              .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()))
              .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
              ;
        }
    }
