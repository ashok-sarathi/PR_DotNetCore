using AutoMapper;
using DotNetCoreEntity.Identity;
using DotNetCoreService.Base;
using DotNetCoreService.Identity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreService.Identity.Service
{
    public interface IUserService : IScopedDependency
    {
        void GetUser(UserModel model);
    }
    public class UserService : IUserService, IScopedDependency
    {
        private readonly IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper ?? throw new Exception(nameof(mapper));
        }

        public void GetUser(UserModel model)
        {
            User user = _mapper.Map<User>(model);
        }
    }
}
