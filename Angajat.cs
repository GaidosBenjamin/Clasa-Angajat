using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ClasaAngajat
{
    class Angajat : IAngajat
    {
        private string nume;
        private string prenume;
        private Data data;

        public Angajat(string nume, string prenume, string data)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.data = new Data(data);
        }
            

        public Data getData()
        {
            return data;
        }

        public void setData(string d)
        {
            this.data = new Data(d);
        }

        public string getNume()
        {
            return nume;
        }

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getPrenume()
        {
            return prenume;
        }

        public void setPrenume(string prenume)
        {
            this.prenume = prenume;
        }

        public override string ToString()
        {
            return nume + " " + prenume + " " + data.ToString();
        }

    }
}
