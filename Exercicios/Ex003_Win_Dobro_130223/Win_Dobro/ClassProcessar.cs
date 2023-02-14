using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Dobro
{
    internal class ClassProcessar
    {
        private double dobro;

        public double Dobro
        {
            get { return dobro; }
            set { dobro = value; }
        }

        public double CalcDobro(double x)
        {
            return x * 2;
        }
    }
}
