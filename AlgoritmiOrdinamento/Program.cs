namespace AlgoritmiOrdinamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestoreAlgoritmi algoritmi;
            int lunghezza, nMin, nMax, sceltaAlgoritmo;
            bool continuaProgramma = true;

            do
            {
                lunghezza = nMin = nMax = 0;
                Console.WriteLine("Inserisci la lunghezza dell'array, il numero minimo e massimo generato, tutti separati tra loro da una virgola: ");
                string caratteristicheVettore = Console.ReadLine();
                DividiCaratteristicheArray(caratteristicheVettore, ref lunghezza, ref nMin, ref nMax);
                algoritmi = new GestoreAlgoritmi(lunghezza, nMin, nMax);

                Console.WriteLine("\n[1] -> Selection sort\n[2] -> Bubble sort\n[3] -> Insertion sort\n[9] -> Esci dal programma");
                Console.WriteLine("Scegli inserendo il numero corrispondente: ");
                sceltaAlgoritmo = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.CursorVisible = false;
                Console.WriteLine("Ordinamento in corso, attendere...");
                
                switch (sceltaAlgoritmo)
                {
                    case 1:
                        algoritmi.SelectionSort();
                        break;
                    case 2:
                        algoritmi.BubbleSort();
                        break;
                    case 3:
                        algoritmi.InsertionSort();
                        break;
                    case 9:
                        Console.WriteLine("\nProgramma terminato");
                        continuaProgramma = false;
                        break;
                    default:
                        Console.WriteLine("Scelta invalida");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = true;
                Console.WriteLine("\nOrdinamento completato");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(algoritmi.TempoEsecuzione);
                Console.WriteLine();
            } while (continuaProgramma);
        }

        static void DividiCaratteristicheArray(string input, ref int length, ref int min, ref int max)
        {
            string[] ris = input.Split(",");
            length = Convert.ToInt32(ris[0]);
            min = Convert.ToInt32(ris[1]);
            max = Convert.ToInt32(ris[2]);
        }
    }
}