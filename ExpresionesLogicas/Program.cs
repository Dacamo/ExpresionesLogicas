using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ExpresionesLogicas
{
    class Program
    {
     
        static void Main(string[] args)
        {
            
            //agregar las validaciones

            Dictionary<string, List<string>> diccionarioOrigen = new Dictionary<string, List<string>>();
            string expresion = "((((p=q)|r)&r))";
            var caracteres = Utilidades.ReconocerCaracteres(expresion);
            diccionarioOrigen = Utilidades.ReconocerProposiciones(expresion);
            diccionarioOrigen= Utilidades.RecorrerExpresion(caracteres, expresion, diccionarioOrigen);
            Utilidades.ImprimirDiccionario(diccionarioOrigen);


        }
    }
}
