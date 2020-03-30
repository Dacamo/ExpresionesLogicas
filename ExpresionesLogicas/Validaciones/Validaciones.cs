using ExpresionesLogicas.ManejadorErrores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExpresionesLogicas
{
    public class Validaciones
    {
        public static bool ValidarOperadores(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count-1)
                {
                    if (caracteres[i].Equals(caracteres[i + 1]) && caracteres[i].Equals("O"))
                    {
                        GestorErrores.Reportar(Error.OPERADORES);
                        return false;
                    }
                    
                }
            }
            return true;
        }

        public static bool ValidarProposiciones(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count - 1)
                {
                    if (caracteres[i].Equals(caracteres[i + 1]) && caracteres[i].Equals("P"))
                    {
                        GestorErrores.Reportar(Error.PROPOSICIONES);
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ValidarParentesis(List<string> caracteres)
        {
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (i < caracteres.Count - 1)
                {
                    if (caracteres[i].Equals("(") && caracteres[i+1].Equals(")"))
                    {
                        GestorErrores.Reportar(Error.PARENTESIS_ABRE_CIERRA);
                        return false;
                    }

                    if (caracteres[i].Equals(")") && caracteres[i + 1].Equals("("))
                    {
                        GestorErrores.Reportar(Error.PARENTESIS_ABRE_CIERRA);
                        return false;
                    }
                }
            }

            return true;
        }

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
                GestorErrores.Reportar(Error.PARENTESIS);
                return false;
            }
            return true;
        }


       

        public static bool ValidarBalanceoExpresion (List<string> caracteres)
        {
            return true;
        }

       
        public static bool ValidarExpresionNoVacia (List<string> caracteres)
        {
           if(caracteres.Count==0)
            {
                GestorErrores.Reportar(Error.EXPRESION_VACIA);
                return false;
            }
            return true;
        }

        // validar minimo una expresion y maximo 6 proposiciones
        // validar que no ingresen solo un caracter
        // validar que antes o despues de un parentesis no exista una p

    }
}
