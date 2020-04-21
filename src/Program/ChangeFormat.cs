using System;

namespace DateFormat
{
    public class ChangeFormat
    {   
        public static string ToYYYYMMDD(string year)
        {
            if ((year.Length == 10) && (HaveLetters.TieneLetras(year) == 0))
            {
                int month = Int32.Parse(year.Substring(3,2));
                int day = Int32.Parse(year.Substring(0,2));
                if ((month > 0) && (month <= 12) && (day > 0) && (day <= 31))
                {
                    return year.Substring(6) + "-" + year.Substring(3,2) + "-" + year.Substring(0,2);
                }
                else
                {
                    return "Fecha inválida.";
                }
            }
            else
            {
                return "Fecha inválida.";
            }
        }

        public static string ToDDMMYYYY(string year)
        {
            if ((year.Length == 10) && (HaveLetters.TieneLetras(year) == 0))
            {
                int month = Int32.Parse(year.Substring(3,2));
                int day = Int32.Parse(year.Substring(0,2));
                if ((month > 0) && (month <= 12) && (day > 0) && (day <= 31))
                {
                    return year.Substring(6) + "-" + year.Substring(3,2) + "-" + year.Substring(0,2);
                }
                else
                {
                    return "Fecha inválida.";
                }
            }
            else
            {
                return "Fecha inválida.";
            }
        }
        
    }
}
