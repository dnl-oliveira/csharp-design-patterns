using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            double result;
            if (orcamento.Valor < 1000)
                result = orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                result = orcamento.Valor * 0.07;
            else
                result = (orcamento.Valor * 0.08) + 30;

            return result;  
        }
    }
}
