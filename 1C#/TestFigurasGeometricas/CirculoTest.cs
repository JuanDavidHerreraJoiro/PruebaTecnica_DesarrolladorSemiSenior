using Entidad;

namespace TestFigurasGeometricas
{
    public class CirculoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CirculoRadioStringNumberAndSpace()
        {
            double radio = Double.Parse("    10".Trim());
            var area = 0.0;
            var circulo = new Circulo();

            circulo.Radio = radio;

            area = circulo.CalcularArea();

            Assert.AreEqual(area, 314.16, 0.01);
        }

        [Test]
        public void CirculoRadioStringLetter()
        {
            double radio = 0;
            string mess = "";
            try
            {
                radio = Double.Parse("s");
            }
            catch (Exception e)
            {
                mess = e.Message;
            }

            double area = 0.0;
            var circulo = new Circulo();

            circulo.Radio = radio;

            area = circulo.CalcularArea();

            Assert.AreEqual(area, 0, 0.01);
        }

        [Test]
        public void CirculoRadioStringNumber()
        {
            double radio = Double.Parse("3");
            var area = 0.0;
            var circulo = new Circulo();

            circulo.Radio = radio;

            area = circulo.CalcularArea();

            Assert.AreEqual(area, 28.27, 0.01);
        }

        [Test]
        public void CirculoCorrecto()
        {
            double radio = 3;
            var area = 0.0;
            var circulo = new Circulo();

            circulo.Radio = radio;

            area = circulo.CalcularArea();

            Assert.AreEqual(area,28.27, 0.01);
        }
    }
}