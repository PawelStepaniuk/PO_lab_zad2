using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zad4
{
    class Kabriolet : Samochod
    {
        private bool dach_otwarty;

        public Kabriolet(string marka, int poj_baku, int predkosc_max, double zuzycie_paliwa):base(marka,poj_baku,predkosc_max,zuzycie_paliwa)
        {
            this.dach_otwarty = false;
        }
      public void otworz_dach()
        {
            if(dach_otwarty != true)
            {
                dach_otwarty = true;
                Console.WriteLine("Dach otwarty");
            }
            
        }

        public void zamknij_dach()
        {
            if (dach_otwarty != false)
            {
                dach_otwarty = false;
                Console.WriteLine("Dach zamkniety");
            }
        }

        public new void jedz(float jakSzybko, float jakDaleko)
        {
            double zasiegNaBaku = (Poj_baku / Zuzycie_paliwa) * 100;
            Console.WriteLine(dach_otwarty);

            if (dach_otwarty == true)
            {
                zasiegNaBaku = zasiegNaBaku - zasiegNaBaku * 0.15;
            }
            Console.WriteLine(zasiegNaBaku);

            double iloscTankowan = jakDaleko / zasiegNaBaku;
            double predkoscMax = Predkosc_max;
            if (jakSzybko < Predkosc_max)
            {
                predkoscMax = jakSzybko;
            }

            Console.WriteLine("Ilosc tankowan: " + Math.Ceiling(iloscTankowan) + " predkosc maksymalna: " + predkoscMax);
        }

    }
}
