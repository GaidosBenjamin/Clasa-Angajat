using System;
using System.Collections.Generic;
using System.Text;

namespace ClasaAngajat
{
    interface IAngajat
    {
        string getNume();
        string getPrenume();
        Data getData();
        void setNume(string nume);
        void setPrenume(string prenume);
        void setData(String data);
    }
}
