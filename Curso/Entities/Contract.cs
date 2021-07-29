using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Curso.Entities
{
    class Contract
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacoes> Prestacoes { get; set; } 

        public Contract(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacoes>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Prestacoes prestacoes in Prestacoes)
            {
                sb.Append(prestacoes.DataDeVencimento.ToString("dd/MM/yyyy"));
                sb.Append(" - ");
                sb.Append(prestacoes.Montante.ToString("F2",CultureInfo.InvariantCulture));
                sb.AppendLine();
              
            }
            return sb.ToString();
        }
    }
}
