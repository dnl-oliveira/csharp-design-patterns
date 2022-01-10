// See https://aka.ms/new-console-template for more information
using DesignPatterns.TemplateMethod;

IImposto iss = new ISS();
IImposto icms = new ICMS();
IImposto iccc = new ICCC();
IImposto icpp = new ICPP();
IImposto ikcv = new IKCV();
IImposto ihit = new IHIT();

Orcamento orcamento = new Orcamento(500.0);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iccc);
calculador.RealizaCalculo(orcamento, icpp);
calculador.RealizaCalculo(orcamento, ikcv);
calculador.RealizaCalculo(orcamento, ihit);
