using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_RaizQuadrada
{
    public class ClassProcessar
    {
        private double raiz;

        public double Raiz
        {
            get { 
                return raiz; 
            }
            set { 
                raiz = value; 
            }
        }

        public double CalcRaiz(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
