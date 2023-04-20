using Entidad;

namespace TestFigurasGeometricas
{
    public class TrianguloTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TrianguloStringNumberAndSpace()
        {
            var area = 0.0;

            double basee = Validacion("     2".Trim());
            double altura = Validacion("   5".Trim());

            Figura figura = new Triangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 5, 0.01);
        }

        [Test]
        public void TrianguloStringLetter()
        {

            var area = 0.0;

            double basee = Validacion(" $");
            double altura = Validacion("@");

            Figura figura = new Triangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 0, 0.01);
        }

        private static double Validacion(string stringNumer)
        {
            double numero = 0;
            try
            {
                numero = Double.Parse(stringNumer);
            }
            catch (Exception e)
            {
                numero = 0;
                //throw;
            }

            return numero;
        }

        [Test]
        public void TrianguloStringNumber()
        {
            var area = 0.0;

            double basee = Double.Parse("2");
            double altura = Double.Parse("2");

            Figura figura = new Triangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 2, 0.01);
        }

        [Test]
        public void TrianguloCorrecto()
        {
            var area = 0.0;

            double basee = 4; 
            double altura = 2;
            
            Figura figura = new Triangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 4, 0.01);
        }
    }
}
