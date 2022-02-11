namespace DesignPatterns.State
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto)
        {
        }
        public ICPP() : base()
        {
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500 + OutroImposto.Calcula(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + OutroImposto.Calcula(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
