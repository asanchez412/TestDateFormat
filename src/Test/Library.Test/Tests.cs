using NUnit.Framework;
using DateFormat;

namespace Library.Test
{

    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void CantidadCaracteresCorrecta()
        {
            // en este ejemplo, el resultado es correcto pero no el ingreso
            string testDate = "1270491997";
            
            // en este ejemplo, el resultado es correcto y también lo es el ingreso
            string testDate2 = "12/04/1997";

            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate),"1997-12-04");
            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate2),"1997-12-04");
        }
        public void CantidadCaracteresIncorrecta()
        {
            string testDate = "1611561616161160";
            
            string testDate2 = "1566";

            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate),"Fecha inválida.");
            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate2),"Fecha inválida.");
        }
        [TestCase]
        public void NoEsFecha()
        {   
            // el método devolverá una string modificada de cualquier string con length 10
            // pero en el test debería de fallar siempre que no sea una fecha válida
            string testDate = "12/04/199a";
            string testDate2 = "12hfht1997";
            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate),"199a-04-12");
            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate2),"1997-fh-12.");
        }
        public void NoEsMes()
        {
            // el método devolverá una string modificada de cualquier string con length 10
            // pero en el test debería de fallar siempre que no sea una fecha válida
            string testDate = "12/98/1997";

            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate),"1997-98-12");
        }
        public void NoEsDia()
        {
            // el método devolverá una string modificada de cualquier string con length 10
            // pero en el test debería de fallar siempre que no sea una fecha válida
            string testDate = "54/04/1997";

            Assert.AreEqual(ChangeFormat.ToYYYYMMDD(testDate),"1997-04-54");
        }
    }
}
