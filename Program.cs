using System;

namespace lab_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("marka", 60, 100, 6);
            samochod.jedz(100, 200);
        }
    }
}
