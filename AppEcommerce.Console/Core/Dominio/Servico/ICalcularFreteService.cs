using AppEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Console.Core.Dominio.Servico
{
    interface ICalcularFreteService
    {
        void CalcularFrete(Frete frete);
    }
}
