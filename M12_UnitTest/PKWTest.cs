//Um auf ein anderes Projekt zugreifen zu k�nnen (hier: Fahrzeugpark) muss dieses zu den Abh�ngigkeiten (Dependencies) des aktuellen
//Projekts hinzugef�gt werden. Die using-Anweisung gew�hrt dann einen verk�rzten Zugriff.
using L06f_Fahrzeugpark;

//Mittels UNIT-Tests k�nnen Klassen kleinteilig langfristig getestet werden.
namespace UnitTest
{
    [TestClass]
    public class PKW_Test
    {
        //Test-Methoden werden durch den TestExplorer von VisualStudio als solche erkannt und k�nnen �ber diesen ausgef�hrt werden.
        [TestMethod]
        public void Beschleunige_ueber_MaxG()
        {
            PKW pkw = new PKW("Mercedes", 210, 23000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1);

            //Jede Test-Methode ben�tigt mindestens einen Aufruf der ASSERT-Klasse, in welcher die Erfolgsbedingung des Tests �berpr�ft wird
            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            PKW pkw = new PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(200);
            pkw.Beschleunige(-300);

            Assert.AreEqual(0, pkw.AktGeschwindigkeit);
        }
    }
}