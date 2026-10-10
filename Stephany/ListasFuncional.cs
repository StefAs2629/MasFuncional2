using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MasFuncional3.Stephany
{
    internal class ListasFuncional
    {
        public static void Ejecutar()
        {
            List<string>amigos =new List<string> { "Noe", "Ivan","Maria","Ana","Kevin","Hiram","Alexei","Zuri"};
            foreach (string nombre in amigos)
            {
                if (nombre.Length <=3)
                MessageBox.Show(nombre);

            }



            // la version funcional para recorrer e imprimir los numeros
            Action variable = () => { };
            Action saludar = () => MessageBox.Show("Hola como estas");
            Action<string> saludopersonal = (texto) => MessageBox.Show(texto);
            Action<string, int> presentacion = (nombre, edad) => MessageBox.Show($"Me llamo {nombre} y tengo {edad}");
            saludar();
            saludopersonal("Buenos dias");
            saludopersonal("pagame");
            saludopersonal("ya vamonos");

            amigos.ForEach((nombre) => MessageBox.Show(nombre.
                ToUpper()
               .ToLower())
            );

            List<string> Minuevalista = amigos.Where((nombre) => nombre.Length <= 3).ToList(); // saca el resultado en una lista
            Minuevalista.ForEach((valor) => MessageBox.Show(valor));

            amigos.Where((nombre) => nombre.Length <= 3)
                .ToList()
                .ForEach((otravariable)=>MessageBox.Show(otravariable));

        }
        
    }
}
