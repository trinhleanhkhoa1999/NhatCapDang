using AutoMapper;
using Lab5.Models;
using Lab5.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistationModel, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
