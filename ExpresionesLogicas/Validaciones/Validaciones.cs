using ExpresionesLogicas.ManejadorErrores;
using System;
using System.Collections.Generic;

namespace ExpresionesLogicas
{
    public static class Validaciones
    {
        /// <summary>
        /// Se recibe una lista de caracteres y si encuentra un operador seguido de otro operador se retorna false, por ejemplo: (POOP) retorna false, (POP) retorna true.
        /// </summary>
        /// <param name="caracteres"></param>
        /// <returns>Retorna un booleano</returns>
        public static bool ValidarOperadores(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count-1)
                {
                    if (caracteres[i].Equals(caracteres[i + 1]) && caracteres[i].Equals("O"))
                    {
                        GestorErrores.Reportar(Error.Operadores);
                        return false;
                    }
                    
                }
            }
            return true;
        }
        /// <summary>
        /// Se recibe una lista de caracteres y si encuentra una proposicion seguida de otra se retorna false, por ejemplo: (PPOP) retorna false, (POP) retorna true.
        /// </summary>
        /// <param name="caracteres"></param>
        /// <returns>Se retorna un booleano</returns>
        public static bool ValidarProposiciones(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count - 1)
                {
                    if (caracteres[i].Equals(caracteres[i + 1]) && caracteres[i].Equals("P"))
                    {
                        GestorErrores.Reportar(Error.Proposiciones);
                        return false;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// Si encuentra las siguientes esctructuras () )( en la lista de caraceteres se retorna false
        /// </summary>
        /// <param name="caracteres"></param>
        /// <returns>Se retorna un booleano</returns>
        public static bool ValidarParentesis(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count - 1)
                {
                    if (caracteres[i].Equals("(") && caracteres[i+1].Equals(")"))
                    {
                        GestorErrores.Reportar(Error.ParentesisAbreCierra);
                        return false;
                    }

                    if (caracteres[i].Equals(")") && caracteres[i + 1].Equals("("))
                    {
                        GestorErrores.Reportar(Error.ParentesisAbreCierra);
                        return false;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// Permite verificar que la cantidad de parentesis que abran sea igual  la cantidad de parentesis que cierran
        /// </summary>
        /// <param name="caracteres"></param>
        /// <returns>Se returna un booleano</returns>
        public static bool ValidarBalanceoParentesis (List<string> caracteres) 
        {
            List<string> parentesisAbre = new List<string>();
            List<string> parentesisCierra = new List<string>();
            foreach (var item in caracteres)
            {
                if (item.Equals("("))
                {
                    parentesisAbre.Add(item);
                }
                if (item.Equals(")"))
                {
                    parentesisCierra.Add(item);
                }
            }

            if (parentesisAbre.Count != parentesisCierra.Count)
            {
                GestorErrores.Reportar(Error.Parentesis);
                return false;
            }
            return true;
        }

       /// <summary>
       /// Permite determinar que una  lista ingresada no tenga la expresion vacia y de esta maneraa se retorna true
       /// </summary>
       /// <param name="caracteres"></param>
       /// <returns>Se retorna un booleano</returns>
        public static bool ValidarExpresionNoVacia (List<string> caracteres)
        {
           if(caracteres.Count==0)
            {
                GestorErrores.Reportar(Error.ExpresionVacia);
                return false;
            }
            return true;
        }

    }
}
