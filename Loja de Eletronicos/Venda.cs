using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletros
{
    internal class Venda
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

        public double Lucro { get; set; }

        public Venda()
        {

        }
        public Venda(int id, string nome, double valor, double lucro)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Lucro = Lucro;

        }

    }
}
