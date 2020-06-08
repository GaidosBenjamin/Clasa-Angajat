using System;
using System.Runtime.InteropServices;

namespace ClasaAngajat
{
    class Program
    {
        static void Main(string[] args)
        {
            AngajatRepo ar = new AngajatRepo();

            ar.print(AngajatRepo.DATA);

            Angajat a = new Angajat("Harrison", "Ford", "11-11-1989");
            ar.Add(a);
            ar.Remove(2);
          
            ar.print(AngajatRepo.NUME);


        }
    }
}
