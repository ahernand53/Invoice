using Invoice.Core.Entity;
using Invoice.Core.Interface;
using Invoice.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Data.Repository
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(InvoiceDbContext context): base(context)
        {

        }

        public bool ValidarUsuario(LoginViewModel user)
        {
            return Todos().Any(u => u.Email == user.Email && u.Contrasena == user.contrasena);
        }
    }
}
