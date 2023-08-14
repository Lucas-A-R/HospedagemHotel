using HotelSheraton.Quartos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton
{
    public class Hotel
    {
        public List<Quarto> quartos = new List<Quarto>();

        public Hotel()
        {
            quartos.Add(new Simples("S01"));
            quartos.Add(new Simples("S02"));
            quartos.Add(new Simples("S03"));
            quartos.Add(new Duplo("D04"));
            quartos.Add(new Duplo("D05"));
            quartos.Add(new Presidencial("P06"));
        }

        public List<Quarto> QuartosVagos()
        {
            List<Quarto> quartosVagos = new List<Quarto>();
            foreach (Quarto quarto in quartos)
            {
                if (quarto.cliente == null)
                {
                    quartosVagos.Add(quarto);
                }
            }

            return quartosVagos;
        }
    }
}
