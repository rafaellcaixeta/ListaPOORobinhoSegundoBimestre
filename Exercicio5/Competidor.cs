﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Competidor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Modalidade: {Modalidade}";
        }
    }
}
