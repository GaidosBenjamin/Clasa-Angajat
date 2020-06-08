using System;
using System.Collections.Generic;
using System.Text;

namespace ClasaAngajat
{
    class Data
    {
        private readonly int  day;
        private readonly int month;
        private readonly int year;

        public Data(string data)
        {
            try
            {
                string[] aux = data.Split('-');
                day = int.Parse(aux[0]);
                month = int.Parse(aux[1]);
                year = int.Parse(aux[2]);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int getDay() { return day; }

        public int getMonth() { return month; }

        public int getYear() { return year; }

        public override string ToString()
        {
            return day.ToString() + "/" + month.ToString() + "/" + year.ToString();
        }
    }
}
