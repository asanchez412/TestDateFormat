using NUnit.Framework;
using DateFormat;

namespace Library.Test
{
    [TestFixture]
    public class Tests_ToDDMMYYYY
    {
        [TestCase]
        public void CantidadCaracteresCorrecta()
        {
            // en este ejemplo, el resultado es correcto pero no el ingreso
            string testDate = "1270491997";
            
            // en este ejemplo, el resultado es correcto y también lo es el ingreso
            string testDate2 = "12/04/1997";

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"12-04-1997");
            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate2),"12-04-1997");
        }
        [TestCase]
        public void CantidadCaracteresIncorrecta()
        {
            string testDate = "1611561616161160";
            
            string testDate2 = "1566";

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate2),"Fecha inválida.");
        }
        [TestCase]
        public void NoEsFecha()
        {   
            string testDate = "12/04/199a";
            string testDate2 = "12hfht1997";
            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate2),"Fecha inválida.");
        }
        [TestCase]
        public void NoEsMes()
        {
            string testDate = "12/98/1997";

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
        }
        [TestCase]
        public void NoEsDia()
        {
            string testDate = "54/04/1997";

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
        }
        public void Empty()
        {
            string testDate = string.Empty;

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
        }
        public void IsNull()
        {
            // el método devuelve la excepción que no existe instancia
            // debería de contenerse la excepción
            string testDate = null;

            Assert.AreEqual(ChangeFormat.ToDDMMYYYY(testDate),"Fecha inválida.");
        }
    }
}
