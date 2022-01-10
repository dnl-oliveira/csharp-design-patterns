// See https://aka.ms/new-console-template for more information
using DesignPatterns;

Imposto iss = new ISS();
Imposto icms = new ICMS();

Orcamento orcamento = new Orcamento(500.0);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms); 
