using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30App
{
    public static class Utilitarios
    {
       public static int SortearNumero(int min, int max) 
        {
        return Random.Shared.Next(min, max+1);//numeros aleatorios
       }

    }
}
