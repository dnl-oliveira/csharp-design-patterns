// See https://aka.ms/new-console-template for more information
using DesignPatterns.Decorator;

Imposto iss = new ISS(new ICMS());
//Imposto icms = new ICMS();
//Imposto iccc = new ICCC();
//Imposto icpp = new ICPP();
//Imposto ikcv = new IKCV();
//Imposto ihit = new IHIT();

Orcamento orcamento = new Orcamento(500.0);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();
calculador.RealizaCalculo(orcamento, iss);
//calculador.RealizaCalculo(orcamento, icms);
//calculador.RealizaCalculo(orcamento, iccc);
//calculador.RealizaCalculo(orcamento, icpp);
//calculador.RealizaCalculo(orcamento, ikcv);
//calculador.RealizaCalculo(orcamento, ihit);
