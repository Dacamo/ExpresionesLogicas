﻿using ExpresionesLogicas.ManejadorErrores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpresionesLogicas
{
    public class Analizador
    {   
        public static Dictionary<string, List<string>> AnalizarExpresion (string expresion)
        {
            Dictionary<string, List<string>> diccionarioOrigen = new Dictionary<string, List<string>>();
        
            var caracteres = Utilidades.ReconocerCaracteres(expresion);
            diccionarioOrigen = Utilidades.ReconocerProposiciones(expresion);
            diccionarioOrigen = Utilidades.RecorrerExpresion(caracteres, expresion, diccionarioOrigen);
            return diccionarioOrigen;
        }


        public static bool  ValidarExpresion(string expresion) 
        {
            var caracteres = Utilidades.ReconocerCaracteres(expresion);
            return (Validaciones.ValidarOperadores(caracteres) 
                && Validaciones.ValidarProposiciones(caracteres) 
                && Validaciones.ValidarParentesis(caracteres) 
                && Validaciones.ValidarBalanceoParentesis(caracteres) 
                && Validaciones.ValidarExpresionNoVacia(caracteres));
        }

        public static string ObtenerValorById(string id)
        {
            return Utilidades.ObtenerValorById(id);
        }

        public static List<string> ObtenerErrores ()
        {
            return GestorErrores.ObtenerErrores();
        }

        public static void LimpiarErrores()
        {
            GestorErrores.LimpiarErrores();
        }

        public static void LimpiarValores()
        {
            Utilidades.LimpiarValores();
        }

        public static string ArmarExpresion (string expresion)
        {
            return Utilidades.ArmarExpresionFinal(expresion);
        }

    }
}
