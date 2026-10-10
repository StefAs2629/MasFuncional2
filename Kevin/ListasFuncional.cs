using System;
using System.Collections.Generic;
using System.Text;

namespace MasFuncional3.Kevin
{
    internal class ListasFuncional
    {
      public static void Ejecutar()
        {
            List<string> amigos = new List<string> { "Noe","Ana","Zuri", "Phani", "Alexei", "hiran", "Evelin", "Maria", "Fidel", "Efren" };

            foreach (string nombre in amigos)
            {
                if(nombre.Length<=3)
                MessageBox.Show(nombre);
            }
            //la vercion funcional para recorer e inprimir los nombres
            Action variable = () => { };
            Action saludar = () => MessageBox.Show("Hola como estas");
            Action<string> Saludopersonal = (texto) => MessageBox.Show(texto);
            Action<string,int> presentacion = (nombre, edad) => MessageBox.Show($"Mellamo{nombre}y tengo{edad}años");

            saludar();
            Saludopersonal("buenos dias");
            Saludopersonal("pagame");
            Saludopersonal("vamos al cine");

            amigos.ForEach((nombre) => MessageBox.Show(nombre
                .ToUpper()
              .ToLower())
            );


            List<string> MinuevaLista = amigos.Where((nombre) => nombre.Length <= 3).ToList();
            MinuevaLista.ForEach((valor) => MessageBox.Show(valor));

            amigos.Where((nombre) => nombre.Length <= 3)
                .ToList()
                .ForEach((otravariable)=>MessageBox.Show(otravariable));
        }
    }
}
