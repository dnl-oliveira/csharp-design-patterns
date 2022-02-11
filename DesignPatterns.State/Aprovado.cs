using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {            
            if (!orcamento.DescontoAprovadoAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.02);
                orcamento.DescontoAprovadoAplicado = true;
            }
            else
                throw new Exception("Desconto ja aplicado para esse orçamento");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja foi aprovado, não pode ser reprovado agora");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
