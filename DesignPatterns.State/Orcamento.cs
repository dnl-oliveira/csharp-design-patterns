using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Orcamento
    {

        

        public IEstadoDeUmOrcamento EstadoAtual;
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public bool DescontoEmAprovacaoAplicado { get; set; }
        public bool DescontoAprovadoAplicado { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
            DescontoAprovadoAplicado = false;
            DescontoEmAprovacaoAplicado = false;
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this); 
        }
    }
}
