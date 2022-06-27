using System;

namespace lab_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("marka", 60, 100, 6);
            //samochod.jedz(100, 200);
            Kabriolet kabrioletZamkniety = new Kabriolet("kabriolet", 50, 260, 30);
            
            Kabriolet kabrioletOtwarty = new Kabriolet("kabriolet", 50, 260, 30);
            kabrioletOtwarty.otworz_dach();
            kabrioletZamkniety.jedz(2020, 2020);
            kabrioletOtwarty.jedz(2020, 2020);
          //  kabrioletOtwarty.jedz(200, 2020);
        }
    }
}
