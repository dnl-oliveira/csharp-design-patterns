using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
        {
        }
        public ImpostoMuitoAlto() : base()
        {
        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + OutroImposto.Calcula(orcamento);
        }
    }
}
