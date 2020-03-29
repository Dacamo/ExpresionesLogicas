﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpresionesLogicas
{
    public class Utilidades
    {
        //validar las letras con expresion regular o is char
        public static List<string> ReconocerCaracteres(string expresion) {
            
            List<string> caracteres = new List<string>();

            foreach (var item in expresion)
            {
                if (item.Equals('|') || item.Equals('&') || item.Equals('>') || item.Equals('='))
                {
                    caracteres.Add("O");
                }
                else if(item.Equals('p') || item.Equals('q') || item.Equals('r'))
                {
                    caracteres.Add("P");
                }
                else
                {
                    caracteres.Add(item.ToString());
                }   
            }
            return caracteres;
        }

        public static Dictionary<string, List<string>> ReconocerProposiciones(string expresion) {

            Dictionary<string, List<string>> proposiciones = new Dictionary<string, List<string>>();
            List<string> proposicionesDefecto = new List<string>();

            foreach (var proposicion in expresion)
            {
                if(proposicion.Equals('p') || proposicion.Equals('q') || proposicion.Equals('r'))
                {
                    if(!proposicionesDefecto.Contains(proposicion.ToString()))
                    {
                        proposicionesDefecto.Add(proposicion.ToString());
                    }
                    
                }
            }
            //llenar los valores iniciales de tabla de verdad
            if (proposicionesDefecto.Count == 2) 
            {
                proposiciones.Add(proposicionesDefecto[0], new List<string> { "V", "V", "F", "F" });
                proposiciones.Add(proposicionesDefecto[1], new List<string> { "V", "F", "V", "F" });
            }

            if (proposicionesDefecto.Count == 3)
            {
                proposiciones.Add(proposicionesDefecto[0], new List<string> { "V", "V", "V", "V", "F", "F", "F", "F" });
                proposiciones.Add(proposicionesDefecto[1], new List<string> { "V", "V", "F", "F", "V", "V", "F", "F" });
                proposiciones.Add(proposicionesDefecto[2], new List<string> { "V", "F", "V", "F", "V", "F", "V", "F" });
            }

            return proposiciones;
        }

        public static void ImprimirDiccionario(Dictionary<string, List<string>> diccionario)
        {
            foreach (var item in diccionario)
            {
                Console.WriteLine("-->" + item.Key);
                var lista = item.Value;
                foreach (var item2 in lista)
                {
                    Console.WriteLine(item2);
                }
            }
        }

        public static Dictionary<string, List<string>> RecorrerExpresion (List<string> caracteres, string expresion, Dictionary<string, List<string>> diccionario)
        {
            List<string> expresionDestino = new List<string>();
            List<string> ids = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            List<string> valores = new List<string>();

            int auxNumber = 0;
            bool resetear = false;

            foreach (var item in expresion)
            {
                expresionDestino.Add(item.ToString());
            }


            for (int i = 0; i < caracteres.Count; i++)
            {
                if (resetear)
                {
                    i = 0;
                    resetear = false;
                }
                if (caracteres[i] == "(" && caracteres[i + 1] == "P" && caracteres[i + 2] == "O" && caracteres[i + 3] == "P" && caracteres[i+4]== ")")
                {
                    string expresionSimple = expresionDestino[i] + expresionDestino[i + 1] + expresionDestino[i + 2] + expresionDestino[i + 3] + expresionDestino[i+4];

                    valores.Add(expresionSimple);

                    diccionario = AgregarExpresionDiccionario(diccionario, expresionSimple, ids[auxNumber]);

                    //actualizar caracteres y reiniciar los valores
                    caracteres = ReemplazarExpresion(caracteres, i, "P");
                    expresionDestino = ReemplazarExpresion(expresionDestino, i, ids[auxNumber]);
                    resetear = true;
                    auxNumber++;
                    
                }
               
            }

            return diccionario;
        }

        public static Dictionary<string, List<string>> AgregarExpresionDiccionario (Dictionary<string, List<string>> diccionarioOrigen, string expresionSimple, string key)
        {
          

            //hacer operaciones
            var proposicion1 = diccionarioOrigen.GetValueOrDefault(expresionSimple[1].ToString());
            var proposicion2 = diccionarioOrigen.GetValueOrDefault(expresionSimple[3].ToString());
            
            List<string> resultado = new List<string>();

            for (int i = 0; i < proposicion1.Count; i++)
            {
                resultado.Add(OperarExpresionBooleana(proposicion1[i], proposicion2[i], expresionSimple[2].ToString()));
                
            }

            //agregar al diccionario
            if (!diccionarioOrigen.ContainsKey(expresionSimple))
            {
                diccionarioOrigen.Add(key, resultado);
            }
            

            return diccionarioOrigen;
        }

        public static string OperarExpresionBooleana (string izq, string der, string operador)
        {
           
            if (operador == "|")
            {
               if(izq == "V" && der == "V")
                {
                    return ("V");
                }

                if (izq == "V" && der == "F")
                {
                    return ("V");
                }

                if (izq == "F" && der == "V")
                {
                    return ("V");
                }

                if (izq == "F" && der == "F")
                {
                    return ("F");
                }
            }
            if (operador == "&")
            {
                if (izq == "V" && der == "V")
                {
                    return ("V");
                }

                if (izq == "V" && der == "F")
                {
                    return ("F");
                }

                if (izq == "F" && der == "V")
                {
                    return ("F");
                }

                if (izq == "F" && der == "F")
                {
                    return ("F");
                }

            }
            if (operador == ">")
            {
                if (izq == "V" && der == "V")
                {
                    return ("V");
                }

                if (izq == "V" && der == "F")
                {
                    return ("F");
                }

                if (izq == "F" && der == "V")
                {
                    return ("V");
                }

                if (izq == "F" && der == "F")
                {
                    return ("V");
                }
            }
            if (operador == "=")
            {
                if (izq == "V" && der == "V")
                {
                    return ("V");
                }

                if (izq == "V" && der == "F")
                {
                    return ("F");
                }

                if (izq == "F" && der == "V")
                {
                    return ("F");
                }

                if (izq == "F" && der == "F")
                {
                    return ("V");
                }
            }

            return null;
        }

        public static List<string> ReemplazarExpresion (List<string> expresion, int inicio, string aux) 
        {
            expresion.RemoveRange(inicio, 5);
            expresion.Insert(inicio, aux);
            return expresion;

        }
        

    } 
}