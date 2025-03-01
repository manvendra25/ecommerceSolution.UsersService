using AutoMapper;
using ecommerceCore.DTO;
using ecommerceCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceCore.Mappers;
public class ApplicationUserMappingProfile : Profile
{
    public ApplicationUserMappingProfile()
    {
        CreateMap<ApplicationUser, AuthenticationResponse>()
          .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID))
          .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
          .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
          .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
          .ForMember(dest => dest.Success, opt => opt.Ignore())
          .ForMember(dest => dest.Token, opt => opt.Ignore())
          ;
    }
}