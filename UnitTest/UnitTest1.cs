using L06f_Fahrzeugpark;

namespace UnitTest
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_ueber_MaxG()
        {
            PKW pkw = new PKW("Mercedes", 210, 23000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

    }
}