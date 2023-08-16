using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton.Alimentos
{
    public abstract class Alimento
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Alimento(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
