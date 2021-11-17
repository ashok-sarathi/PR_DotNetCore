using AutoMapper;
using DotNetCoreEntity.Identity;
using DotNetCoreService.Identity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreService.Identity.Mapper
{
    public class IdentityMapping : Profile
    {
        public IdentityMapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
