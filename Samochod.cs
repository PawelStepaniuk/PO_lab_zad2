using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zad4
{
   public class Samochod
    {
        private string marka;
  
        public String Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        
        private int poj_baku;
        public int Poj_baku
        {
            get { return poj_baku; }
            set { poj_baku = value;}
        }
        private int predkosc_max;

        public int Predkosc_max
        {
            get { return predkosc_max; }
            set { predkosc_max = value; }
        }
        private double zuzycie_paliwa;
        public double Zuzycie_paliwa
        {
            get { return zuzycie_paliwa; }
            set { zuzycie_paliwa = value; }
        }

  

        public Samochod(string marka, int poj_baku, int predkosc_max, double zuzycie_paliwa)
        {
            this.marka = marka;
            this.poj_baku = poj_baku;
            this.predkosc_max = predkosc_max;
            this.zuzycie_paliwa = zuzycie_paliwa;
        }
        
        public void jedz(float jakSzybko, float jakDaleko)
        {
            double zasiegNaBaku = (poj_baku / zuzycie_paliwa)*100;
            double iloscTankowan = jakDaleko / zasiegNaBaku;
            double predkoscMax = predkosc_max;
            if (jakSzybko < predkosc_max)
            {
                predkoscMax = jakSzybko;
            }

            Console.WriteLine("Ilosc tankowan: " + Math.Ceiling(iloscTankowan) + " predkosc maksymalna: " + predkoscMax);
        }
    }
}
