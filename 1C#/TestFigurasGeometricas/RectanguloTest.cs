using Entidad;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFigurasGeometricas
{
    public class RectanguloTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RectanguloStringNumberAndSpace()
        {
            var area = 0.0;

            double basee = Validacion("     5".Trim());
            double altura = Validacion("   5".Trim());

            Figura figura = new Rectangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 25, 0.01);
        }

        [Test]
        public void RectanguloStringLetter()
        {

            var area = 0.0;

            double basee = Validacion(" $");
            double altura = Validacion("@");

            Figura figura = new Rectangulo();

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
        public void RectanguloStringNumber()
        {
            var area = 0.0;

            double basee = Double.Parse("2");
            double altura = Double.Parse("2");

            Figura figura = new Rectangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 4, 0.01);
        }

        [Test]
        public void RectanguloCorrecto()
        {
            var area = 0.0;

            double basee = 4; 
            double altura = 2;
            
            Figura figura = new Rectangulo();

            figura.Altura = altura;
            figura.Base = basee;

            area = figura.CalcularArea();

            Assert.AreEqual(area, 8, 0.01);
        }
    }
}
