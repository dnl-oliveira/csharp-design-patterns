namespace DesignPatterns.State
{
    public abstract class Imposto
    {        
        public Imposto OutroImposto { get; set; }

        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
