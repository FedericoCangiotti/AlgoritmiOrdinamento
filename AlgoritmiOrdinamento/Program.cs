namespace AlgoritmiOrdinamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestioneAlgoritmi algoritmi = new GestioneAlgoritmi(10, 1, 10);
            //algoritmi.SelectionSort();
            algoritmi.BubbleSort();
        }
    }
}