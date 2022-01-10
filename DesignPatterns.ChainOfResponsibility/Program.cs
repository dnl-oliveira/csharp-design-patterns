// See https://aka.ms/new-console-template for more information
using DesignPatterns.ChainOfResponsibility;

CalculadorDeDescontos calculador = new CalculadorDeDescontos();

Orcamento orcamento = new Orcamento(6800.0);
orcamento.AdicionaItem(new Item("CANETA", 250.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));
orcamento.AdicionaItem(new Item("GELADEIRA", 2000.0));
orcamento.AdicionaItem(new Item("XBOX", 4000.0));
orcamento.AdicionaItem(new Item("TENIS", 250.0));
orcamento.AdicionaItem(new Item("CHINELO", 50.0));

double desconto = calculador.Calcula(orcamento);

Console.WriteLine(desconto);
