using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class ExpresionMatematica
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double suma()
        {
            return num1 + num2;
        }

        public double resta()
        {
            return num1 - num2;
        }

        public double multiplicacion()
        {
            return num1 * num2;
        }

        public double division()
        {
            return num1 / num2;
        }

        public double max()
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public double min()
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
