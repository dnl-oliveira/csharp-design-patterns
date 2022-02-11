using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!orcamento.DescontoEmAprovacaoAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.05);
                orcamento.DescontoEmAprovacaoAplicado = true;
            }
            else
                throw new Exception("Desconto ja aplicado para esse orçamento");
           
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado direto");
        }

       
    }
}
