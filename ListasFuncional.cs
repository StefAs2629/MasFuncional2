using System;
using System.Collections.Generic;
using System.Text;

namespace MasFuncional3
{
    internal class ListasFuncional
    {
        public static void Ejecutar()
        {
            List<string> amigos = new List<string> { "Rober", " ALfredo", "Gerson", "Miguel", "Ruben", "Alexei", "Alian", "Alan" };

            //{"Ana","Noe
            foreach (string nombre in amigos)
            {
                if (nombre .Length <= 3)
                MessageBox.Show(nombre);
            }
                
               

            //La vercion funcional para recorrer e imprimir los nombres
            Action variable = () => { };//Estructura basica de una Action
            Action saludar = () => MessageBox.Show("Hola como estas");
            Action<string> saludopersonal = (texto) => MessageBox.Show(texto);
            Action<string, int> presentacion = (nombre, edad) => MessageBox.Show($"Me llamo {nombre} y tengo {edad} años");

            saludar();
            saludopersonal("buenos dias");
            saludopersonal("Pegame");
            saludopersonal("Vmos al cine");

            amigos.ForEach((nombre) => MessageBox.Show(nombre
                .ToUpper()
                .ToLower())
            );

            List<string> MinuevaLista = amigos .Where((nombre) => nombre.Length <= 3).ToList();
            MinuevaLista.ForEach((valor) => MessageBox.Show(valor));

            amigos.Where((nombre) => nombre.Length <= 3)
                .ToList()
                .ForEach((otravariable) => MessageBox.Show(otravariable));

            

               



        }
    }
}
