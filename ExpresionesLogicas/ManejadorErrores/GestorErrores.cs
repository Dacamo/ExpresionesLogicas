using System;
using System.Collections.Generic;
using System.Text;

namespace ExpresionesLogicas.ManejadorErrores
{
    public class GestorErrores
    {
        private static List<string> errores = new List<string>();

        public static List<string> ObtenerErrores()
        {
            return errores;
        }

        public static void Reportar(string error)
        {
            if (error != null)
            {
                errores.Add(error);
            }
        }

        public static void LimpiarErrores()
        {
            errores.Clear();
        }
    }
}
