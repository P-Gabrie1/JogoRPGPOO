using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30App
{
    public class Arma
    {
        public string Nome { get; set; }
        public int DanoMinimo { get; set; }
        public int DanoMaximo { get; set; }

        public Arma(string nome, int danoMinimo, int danoMaximo)
        {
            Nome = nome;
            DanoMinimo = danoMinimo;
            DanoMaximo = danoMaximo;
        }
    }
}
