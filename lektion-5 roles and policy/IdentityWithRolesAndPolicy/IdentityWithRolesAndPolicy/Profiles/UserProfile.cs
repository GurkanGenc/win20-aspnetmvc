using AutoMapper;
using IdentityWithRolesAndPolicy.Data;
using IdentityWithRolesAndPolicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityWithRolesAndPolicy.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
