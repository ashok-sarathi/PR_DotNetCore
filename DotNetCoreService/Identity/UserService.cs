using DotNetCoreService.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreService.Identity
{
    public interface IUserService : IScopedDependency
    {

    }
    public class UserService : IUserService, IScopedDependency
    {

    }
}
