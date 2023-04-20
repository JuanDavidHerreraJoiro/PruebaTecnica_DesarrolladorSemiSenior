using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }
        public double Pi = 3.1416;

        public double CalcularArea()
        {
            try
            {
                return this.Pi * Math.Pow(this.Radio, 2);
            }
            catch (Exception)
            {
                return this.Pi * Math.Pow(0, 2);
            }
        }
    }
}
