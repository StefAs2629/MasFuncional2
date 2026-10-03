using System;
using System.Collections.Generic;
using System.Text;

namespace MasFuncional3
{
    internal class clAction
    {
        public static void Ejecutar() // como tiene void no necesita return le agregamos el static es para quitar lineas
        {
            Saludar();

            Action saludo = () => MessageBox.Show("buenas tardes");
            Action<String> saludarMensaje = (mensaje) => MessageBox.Show(mensaje);
            saludo();
            saludarMensaje("Buenas noches");
        }

        private static void Saludar()
        {
            MessageBox.Show("Buenas tardes");
        }

        private static void SaludarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
           
        }
    }
}
