using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace MasFuncional3
{
    internal class clFunc
    {
        public void Ejecutar()
        {
            MessageBox.Show(Multiplicar(12, 6).ToString());

            Func<int, int, int> mult = (a, b) => a > 0 && b > 0 ? a * b : 1;
            // programacion funcional
            MessageBox.Show(mult(12,6).ToString());
            //Func<int, int, int> suma = (a, b) => a + b;
            Operacion((a, b) => a + b);
            Operacion((a, b) => a - b);
            Operacion((a, b) => a * b);
            Operacion((a, b) => a / b);


        }
        private int Multiplicar(int a, int b)
        {

            if (a > 0 && b > 0)
            {
                return a * b;

            }
            else
            {
                return 1;
            }
        }
            private Func<int, int, int> Operacion(Func<int,int,int> a)
             {
            return a;
             }
        
    }
}
