// See https://aka.ms/new-console-template for more information
using DesignPatterns.State;


Orcamento reforma = new Orcamento(500);
reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);
reforma.Aprova();
reforma.AplicaDescontoExtra();
reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);
reforma.Finaliza();
Console.ReadKey(); 

