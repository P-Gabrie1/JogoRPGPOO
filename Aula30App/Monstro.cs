using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30App
{
    public class Monstro:Criatura
    {
        public string Nome { get; set; }
        public int DanoMaxima { get; set; }

        public Monstro(string nome, int danoMaxima, int vidaAtual, int vidaMaxima):base(vidaAtual, vidaMaxima) 
        {
            Nome = nome;
            DanoMaxima = danoMaxima;

        }
        
    }
}
