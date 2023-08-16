using HotelSheraton.Alimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton.Quartos
{
    internal class Duplo : Quarto , Frigobar
    {
        public List<Alimento> frigobar { get; } = new List<Alimento>();

        public double diaria = 550.90;

        public Duplo(string id) : base(id)
        {


        }
    }
}
