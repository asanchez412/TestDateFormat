using System;
using DateFormat;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDate = "10/01/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat.ToYYYYMMDD(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat.ToDDMMYYYY(testDate));
        }
    }
}
