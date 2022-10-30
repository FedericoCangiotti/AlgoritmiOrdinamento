using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiOrdinamento
{
    internal class GestioneAlgoritmi
    {
        int[] vettore;

        public GestioneAlgoritmi(int lunghezzaArray, int numeroMinimo, int numeroMassimo)
        {
            vettore = new int[lunghezzaArray];
            Random rand = new Random();

            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = rand.Next(numeroMinimo, numeroMassimo + 1);
            }
        }
    }
}