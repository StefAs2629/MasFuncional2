using System;
using System.Collections.Generic;
using System.Text;

namespace MasFuncional3.Zurii
{
    internal class ListasFuncional
    {
        public static void Ejecutar()
        {
            List<string>amigos= new List<string> 
            { "Sayra","noe", "liz", "Mayra", "Anubis", "Alan", "Osiris", "Ismael", "Blank", "Cris"};
            foreach (string nombre in amigos)
            {
                if(nombre.Length <= 3)
                MessageBox.Show(nombre);
            }
             

            //Version funcional
            //Action<string> mensaje = (texto) => MessageBox.Show(texto);
            //amigos.ForEach(Action)

            Action<string, int> presentacion = (nombre, edad) => MessageBox.Show($"Me llamo{nombre} y tengo {edad} años");
            Action<string> saludopersonal = (texto) => MessageBox.Show(texto);
            saludopersonal("Vaamos al cine");

            amigos.ForEach((nombre) => MessageBox.Show(nombre.ToUpper().ToLower()));

            //funcional option 
            List<string>MinuevaLista = amigos.Where((nombre) => nombre.Length <= 3).ToList();
            MinuevaLista.ForEach((valor)=>MessageBox.Show(valor));

            //funcional pro opción 
            amigos.Where((nombre) => nombre.Length <= 3)
                .ToList()
                .ForEach((otravariable)=> MessageBox.Show(otravariable));

            bdatos.Where(fila.)
                .quitarEspacios()
                .FormatoCorreo()
                .FormaatoTelefono()

        }

    }
}
