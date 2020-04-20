using System;
// Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma
// “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
// Ej.: 10/11/1977 -> 1977­‐11­‐10
//
// La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la
// clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de
// entrada del programa.

namespace DateFormat
{
    public class ChangeFormat
    {
        public static string ToYYYYMMDD(string year)
        {
            if (year.Length == 10)
            {
                return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
            }
            else
            {
                return "Fecha inválida.";
            }
        }
    }
}
