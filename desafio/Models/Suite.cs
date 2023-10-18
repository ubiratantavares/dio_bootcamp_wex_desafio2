using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.Models
{
    public class Suite
    {
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite()
        {
            Tipo = "";
            Capacidade = 0;
            ValorDiaria = 0.0M;
        }

        public Suite(string tipo, int capacidade, decimal valorDiaria)
        {
            Tipo = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}