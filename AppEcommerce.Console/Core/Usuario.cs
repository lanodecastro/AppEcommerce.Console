using AppEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Console.Core
{
    public class Usuario
    {
        public Email Email { get; set; }

        public Usuario(string email)
        {
            this.Email = new Email(email);
        }
        
    }
}
