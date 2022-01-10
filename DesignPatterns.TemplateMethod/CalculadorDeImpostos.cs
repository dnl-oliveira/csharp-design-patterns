namespace DesignPatterns.TemplateMethod
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {           
            Console.WriteLine(imposto.Calcula(orcamento));
        }

       
    }
}
