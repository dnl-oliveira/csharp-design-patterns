﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Item
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
