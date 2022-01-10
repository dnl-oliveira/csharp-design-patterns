﻿namespace DesignPatterns.Decorator
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {           
            Console.WriteLine(imposto.Calcula(orcamento));
        }

       
    }
}
