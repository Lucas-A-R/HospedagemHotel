using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton.Clientes
{
    public abstract class Cliente
    {
        public string Name { get; set; }
        public Cliente(string Nome)
        {
            this.Name = Nome;
        }

        public virtual double Desconto()
        {
            return 0.9;
        }
    }
}
