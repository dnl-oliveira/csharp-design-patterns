// See https://aka.ms/new-console-template for more information
using DesignPatterns.Strategy;

IImposto iss = new ISS();
IImposto icms = new ICMS();
IImposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(500.0);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iccc);
