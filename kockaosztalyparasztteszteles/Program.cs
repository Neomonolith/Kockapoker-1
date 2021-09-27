using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kockaosztalyparasztteszteles
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader be = new StreamReader("tesztadatok.txt");

        Console.WriteLine("Hibás értékek: ");
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        int[] szamok = new int[5];

        string[] szam = a[0].Split(',');
        int ertek = Convert.ToInt32(a[1]);

        for (int i = 0; i < 5; i++)
        {
          szamok[i] = Convert.ToInt32(szam[i]);
        }

        Kockak k = new Kockak(szamok);

        if (k.Ertek() != ertek)
        {
          Console.WriteLine($"{k.ErtekSzoveg()} = {k.Ertek()}: {ertek}"); 
        }


      }




      be.Close();

      Console.ReadLine();
    }
  }
}
