using System;

namespace DateFormat
{
    public class HaveLetters
    {
        public static int TieneLetras(string palabra)
        {
            int controlador = 0;
            foreach (char caracter in palabra)
            {
                if (char.IsLetter(caracter))
                {
                    controlador++;
                }
            }
            return controlador;
        }
    }
}