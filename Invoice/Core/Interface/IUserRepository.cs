using Invoice.Core.Entity;
using Invoice.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Core.Interface
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        bool ValidarUsuario(LoginViewModel user);
    }
}
