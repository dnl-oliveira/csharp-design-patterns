using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados / finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta finalizado");
        }
    }
}
