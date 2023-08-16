using HotelSheraton.Alimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton.Quartos
{
    internal class Presidencial : Quarto, Frigobar
    {
        public double diaria = 550.90;

        public List<Alimento> frigobar { get; } = new List<Alimento>();

        public Presidencial(string id) : base(id)
        {


        }
    }
}
