using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    class Prestacoes
    {
        public DateTime DataDeVencimento { get; set; }
        public double Montante { get; set; }

        public Prestacoes(DateTime dataDeVencimento, double montante)
        {
            DataDeVencimento = dataDeVencimento;
            Montante = montante;
        }
    }
}
