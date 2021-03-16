using System;

namespace GeneratoreCasuale
{
    class Program
    {
        static void Main(string[] args)
        {
            NRRandom nrr = new NRRandom(90);    // da 0 a 89
            NRRandom nrr2 = new NRRandom(1, 91);    // da 1 a 90

            while(nrr.Rimasti > 0)
                Console.Write($"{nrr.Next()} ");

            nnr.Reset();    // permette di ricominciare un intero di ciclo di generazioni

        }
    }
}
