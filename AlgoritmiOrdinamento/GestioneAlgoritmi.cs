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

        public void SelectionSort()
        {
            int posizioneMinore;
            for (int i = 0; i < vettore.Length - 1; i++)
            {
                posizioneMinore = i;
                for (int j = i + 1; j < vettore.Length; j++)
                {
                    if (vettore[posizioneMinore] > vettore[j])
                    {
                        posizioneMinore = j;
                    }
                }
                if (posizioneMinore != i)
                {
                    int temp = vettore[i];
                    vettore[i] = vettore[posizioneMinore];
                    vettore[posizioneMinore] = temp;
                }
            }
        }
    }
}