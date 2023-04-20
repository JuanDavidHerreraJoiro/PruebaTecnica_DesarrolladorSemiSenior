namespace Entidad
{
    public abstract class Figura : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return PreCalculo();
        }

        public abstract double PreCalculo();
    }
}