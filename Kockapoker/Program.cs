using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockapoker
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Dictionary<int,int> proba = new Dictionary<int, int>()
       {


       };
     */
      Jatekos gep = new Jatekos("Gép");
      Jatekos ember = new Jatekos("Erik");

      int embernyer = 0;
      int gepnyer = 0;

      string valasz = "";
      do
      {
       
        jatekEgykor(gep, ref gepnyer, ember, ref embernyer);
        jatekAllasa(embernyer, gepnyer);
        Console.Write("Akarsz még játszani? i/n:  ");
        valasz = Console.ReadLine().ToLower();
        Console.WriteLine("-----------");
      } while (valasz == "i");
      Console.Clear();
      Console.WriteLine("Játék vége...");
      Console.ReadKey();
    }

    private static void jatekAllasa(int ember, int gep)
    {
      Console.WriteLine($"Ember: {ember.ToString().PadLeft(2):N2} - Gép: {gep}");
    }

    private static void jatekEgykor(Jatekos gep, ref int gepnyer, Jatekos ember, ref int embernyer)
    {
      Console.WriteLine("Szeretnél kezdeni: (I/N)");
      if (Console.ReadLine().ToLower() == "i")
      {
        ember.Kor();
        Console.WriteLine($"Az ember: {ember.Ertekszoveg}");
        // Console.WriteLine(ember.Ertek);
        gep.Kor();
        Console.WriteLine($"A gép   : {gep.Ertekszoveg}");
        //Console.WriteLine(gep.Ertek);

        EredmenyKiiras(gep, ember, ref gepnyer,  ref embernyer);

      }
      else
      {
        gep.Kor();
        Console.WriteLine($"A gép   : {gep.Ertekszoveg}");
        ember.Kor();
        Console.WriteLine($"Az ember: {ember.Ertekszoveg}");

        EredmenyKiiras(gep, ember, ref gepnyer, ref embernyer);
      }
    }

    private static void EredmenyKiiras(Jatekos gep, Jatekos ember, ref int gepnyer, ref int embernyer)
    {
      ConsoleColor eredetiszin = Console.ForegroundColor;
      if (ember.Ertek == gep.Ertek)
      {
      Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Az állás döntetlen");
      }
      else if (ember.Ertek > gep.Ertek)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A gép vesztett");
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A gép nyert");
      }
      Console.ForegroundColor = eredetiszin;
    }
  }
}
