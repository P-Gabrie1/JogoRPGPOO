using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30App
{
    public class Jogador:Criatura
    {
        public Arma ArmaAtual {  get; set; }
        public Monstro MonstroAtual{ get; set; }
        public Jogador( int vidaAtual, int vidaMaxima) :base(vidaAtual,vidaMaxima) 
        {
        }

        public int AtacarMonstro() 
        {
            int dano= Utilitarios.SortearNumero(ArmaAtual.DanoMinimo, ArmaAtual.DanoMaximo);
            MonstroAtual.VidaAtual -= dano;
            return dano;
        }

        public int SerAtacado() 
        {
         int dano = Utilitarios.SortearNumero(0, MonstroAtual.DanoMaxima);
            VidaAtual-=dano;
            return dano;
        
        }
    }
}
