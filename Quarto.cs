using HotelSheraton.Alimentos;
using HotelSheraton.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSheraton.Quartos
{
    public abstract class Quarto
    {
        public string Id { get; set; }

        public Cliente cliente { get; set; }

        public List<Alimento> consumo = new List<Alimento>();

        public static int QtdQuartos = 0;

        public double diaria;

        public Quarto(string id)
        {
            Id = id;
            ++QtdQuartos;
    }
        public void Ocupar(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void Liberar()
        {
            this.cliente = null;
        }

        public double CalcularConta()
        {
            double total = 0;
            foreach (Alimento produto in this.consumo)
            {
                total += produto.preco;
            }
            return total + ((1 - cliente.Desconto()) * this.diaria);
        }
    }
}
