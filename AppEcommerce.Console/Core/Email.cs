using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Console.Core
{
    public class Email
    {
        public string Value { get; private set; }

        public Email(string email)
        {
            ValidarEmail(email);
            this.Value = email;
        }
        private void ValidarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new Exception("E-mail inválido");
            }
        }

    }
}
