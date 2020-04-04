using ExpresionesLogicas.ManejadorErrores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpresionesLogicas
{
    public class Utilidades
    {
        static List<string> ids = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        static List<string> valores = new List<string>();
        static List<string> valoresFinales = new List<string>();

        /// <summary>
        /// Metodo que reconoce los caracteres de una expresion y los agrega a una lista de caracteres en el cual
        /// si es un operador logico se agrega un caracter "O" que indica Operador logico y si es una preposicion se agrega una "P"
        /// </summary>
        /// <param name="expresion">expresion  </param>
        /// <returns> retorna una lista de tipo string </returns>
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
        /// <summary>
        /// Metodo que reconoce las proposiciones y las guarda en un diccionario del tipo clave y valor,
        /// en donde la clave será la proposicion y en valor una lista que indica la tabla de verdad correspondiente
        /// </summary>
        /// <param name="expresion"></param>
        /// <returns> retorna un diccionario con clave: proposicion y valor: tabla de verdad</returns>
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
            if(proposicionesDefecto.Count == 1)
            {
                proposiciones.Add(proposicionesDefecto[0], new List<string> { "V","F" });
            }
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
        /// <summary>
        /// Recorre la expresion completa en busca de expresiones del tipo (P O P) ->( proposicion operadorLogico preposicion)
        /// para ser reemplazada por un id y así ir resolviendo recursivamente las expresiones del tipo (P O P)
        /// </summary>
        /// <param name="caracteres"></param>
        /// <param name="expresion"></param>
        /// <param name="diccionario"></param>
        /// <returns>retorna un diccionario</returns>
        public static Dictionary<string, List<string>> RecorrerExpresion (List<string> caracteres, string expresion, Dictionary<string, List<string>> diccionario)
        {

            List<string> expresionDestino = new List<string>();
            ids = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

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

            if (expresionDestino.Count > 3)
            {
                GestorErrores.Reportar("Expresion no balanceada, se resuelve parcialmente");            
            }
            valoresFinales = valores;
            return diccionario;
        }
        /// <summary>
        /// Opera una expresion del tipo (P O P) y el resultado lo agrega al diccionario con su key respectivo
        /// </summary>
        /// <param name="diccionarioOrigen"></param>
        /// <param name="expresionSimple"></param>
        /// <param name="key"></param>
        /// <returns> Retorna un diccionario con key = proposcion y value: tabla de valores correspondiente</returns>
        public static Dictionary<string, List<string>> AgregarExpresionDiccionario (Dictionary<string, List<string>> diccionarioOrigen, string expresionSimple, string key)
        {
            List<string> proposicion1 = new List<string>();
            List<string> proposicion2 = new List<string>();

            foreach (var item in diccionarioOrigen)
            {
                if(item.Key == expresionSimple[1].ToString())
                {
                    proposicion1 = item.Value;
                }

                if (item.Key == expresionSimple[3].ToString())
                {
                    proposicion2 = item.Value;
                }
            }
            
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
        /// <summary>
        /// Realizar la operacion de una expresion booleana de acuerdo al operador ingresado por ejemplo 
        /// izq=V, der= V operador= | entonces se obtiene el resultado de operar V|V= V
        /// </summary>
        /// <param name="izq"></param>
        /// <param name="der"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion de la expresion booleana</returns>
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
        /// <summary>
        /// Reemplaza un valor dentro de una expresion, por ejemplo se recibe la expresion ((p|q)|r)
        /// inicio = 1, aux = "A" entonces se opera asi: (A|r)
        /// </summary>
        /// <param name="expresion"></param>
        /// <param name="inicio"></param>
        /// <param name="aux"></param>
        /// <returns>Retorna una lista de tipo string</returns>
        public static List<string> ReemplazarExpresion (List<string> expresion, int inicio, string aux) 
        {
            expresion.RemoveRange(inicio, 5);
            expresion.Insert(inicio, aux);
            return expresion;

        }
        /// <summary>
        /// De la lista de valores se obtiene el respectivo valor con el id que se recibe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string ObtenerValorById(string id)
        {
            var index = ids.IndexOf(id);
            if (index >= 0)
            {
                return valores[index];
            }
            return null;
            
        }
        /// <summary>
        /// Permite limpiar todos los valores que se encuentran en la tabla valores
        /// </summary>
        public static void LimpiarValores ()
        {
            valores.Clear();
        }

        /// <summary>
        /// Permite construir una expresion  que se encuentra simplificada en una expresion completa,
        /// por ejemplo: a= (p|q), b= (p&r) se necesta armar (a|b) entonces el resultado debe ser ((p|q)|(r&r))
        /// </summary>
        /// <param name="expresion"></param>
        /// <returns></returns>
        public static string ArmarExpresionFinal (string expresion)
        {
            string nuevaExpresion = "";
            int index = 0;
           
            foreach (var item in expresion)
            {
                if(char.IsLetter(item) && item != 'p' && item != 'q' && item != 'r' )
                {
                    index = ids.IndexOf(item.ToString());
                    nuevaExpresion += valores[index];
                    
                }
                else
                {
                    nuevaExpresion += item;
                }
            }
            
             valores[valores.IndexOf(expresion)] = nuevaExpresion;
            
            
            return nuevaExpresion;

        }

        


    } 
}
