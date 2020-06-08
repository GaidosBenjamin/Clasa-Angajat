using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace ClasaAngajat
{
    class AngajatRepo
    {
        private List<Angajat> lista;
        public const int NUME = 1;
        public const int DATA = 2;

        public AngajatRepo()
        {
            lista = new List<Angajat>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\gaido\source\repos\ClasaAngajat\input.txt"))
                {
                    string line;
                    string[] separated = new string[5];
                    while((line = sr.ReadLine()) != null)
                    {
                        separated = line.Split(' ');
                        
                        Angajat a = new Angajat(separated[0], separated[1], separated[2]);
                        
                        lista.Add(a);
                    }
                }

            } 
            catch(Exception e)
            {
                Console.WriteLine("FIle could not be read!");
                Console.WriteLine(e.ToString());
            }
        }

        public void Add(Angajat a)
        {
            lista.Add(a);
        }

        public void Remove(int index)
        {
            if (lista.Count == 0 || index > lista.Count)
                throw new Exception();
            lista.RemoveAt(index);
        }

        private class NameCompare : IComparer<Angajat>
        {
            public int Compare(Angajat x, Angajat y)
            {
                if (x.getNume() == y.getNume())
                {
                    if (String.Compare(x.getPrenume(), y.getPrenume()) == -1)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else if (String.Compare(x.getNume(), y.getNume()) == -1)
                {
                    return -1;
                }
                else
                    return 1;
            }
        }

        private class DateCompare : IComparer<Angajat>
        {
            public int Compare(Angajat x, Angajat y)
            {
                if (x.getData().getYear() == y.getData().getYear())
                {
                    if (x.getData().getMonth() == y.getData().getMonth())
                    {
                        if (x.getData().getDay() < y.getData().getDay())
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        if (x.getData().getMonth() < y.getData().getMonth())
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
                else
                {
                    if (x.getData().getYear() < y.getData().getYear())
                        return -1;
                    else
                        return 0;
                }
            }
        }

        private DateCompare dupaData()
        {
            return new DateCompare();
        }

        private NameCompare dupaNume()
        {
            return new NameCompare();
        }

        public void Sort(int aux)
        {
            if(aux == 1)
            {
                lista.Sort(dupaNume());
            }
            else
            {
                if(aux == 2)
                {
                    lista.Sort(dupaData());
                }
            }
        }

        public void print(int optiunea)
        {
            try
            {
                StreamWriter sw;
                if (optiunea == 1)
                {
                    lista.Sort(dupaNume());
                    sw = new StreamWriter(@"C:\Users\gaido\source\repos\ClasaAngajat\outputAlfabetic.txt");
                }
                else
                {
                    if (optiunea != 2)
                        throw new Exception();
                    lista.Sort(dupaData());
                    sw = new StreamWriter(@"C:\Users\gaido\source\repos\ClasaAngajat\outputData.txt");
                    
                }
                foreach (Angajat elem in lista)
                {
                    if(optiunea == 1)
                        sw.WriteLine(elem.getNume() + " " + elem.getPrenume());
                    else
                    {
                        if (optiunea == 2)
                            sw.WriteLine(elem);
                    }
                }
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("FIle could not be wrote to!");
                Console.WriteLine(e.ToString());
            }
        }

       
    }
}
