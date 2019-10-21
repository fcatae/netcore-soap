using webxml.Models;
using System;

namespace webxml
{
    public class UsuarioService : IUsuarioService
    {
        public bool Login(Login login)
        {
            return (login.Name == login.Password );
        }

        public User[] ListarUsuarios()
        {
            return new User[] { 
                new User { Id = 1, Name = "Fabio" },
                new User { Id = 2, Name = "Fabricio" },
                new User { Id = 3, Name = "Fernando" }
            };
        }
    }
}