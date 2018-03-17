using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Validador
    {
        public bool esEntero(string a)
        {
            bool res = false;
            int numero;
            try
            {
                numero = int.Parse(a);
                if ((numero < 0) || (numero > 100))
                {
                    res = true;
                }
            }
            catch { }
            return res;
        }
        public bool esDecimal(string a)
        {
            bool res=false;
            double nu;
            int n;
            try
            {
                nu = double.Parse(a);
                try
                {
                    n = int.Parse(a);
                }
                catch
                {
                    res = true;
                }
                
            }
            catch { }         
            return res;
        }
        public bool esEdad(String a)
        {
            bool res = false;
            int nu;
            try
            {
                nu = int.Parse(a);
                if ((nu > 0) && (nu < 100))
                {
                    res = true;
                }
            }
            catch { }
            return res;
        }
        public bool esDigito(string a)
        {
            bool res = false;
            string min = a.ToLower();
            if (min.Equals("cero"))
            {
                res = true;
            }
            else if (min.Equals("uno"))
            {
                res = true;
            }
            else if (min.Equals("dos"))
            {
                res = true;
            }
            else if (min.Equals("tres"))
            {
                res = true;
            }
            else if (min.Equals("cuatro"))
            {
                res = true;
            }
            else if (min.Equals("cinco"))
            {
                res = true;
            }
            else if (min.Equals("seis"))
            {
                res = true;
            }
            else if (min.Equals("siete"))
            {
                res = true;
            }
            else if (min.Equals("ocho"))
            {
                res = true;
            }
            else if (min.Equals("nueve"))
            {
                res = true;
            }

            return res;
        }
    }
}
