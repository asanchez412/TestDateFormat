using System;

namespace DateFormat
{
    public class ChangeFormat
    {
        public static string ToYYYYMMDD(string year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
    }
}
