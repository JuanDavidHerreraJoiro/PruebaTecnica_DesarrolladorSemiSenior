using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Triangulo : Figura
    {
        public override double PreCalculo()
        {
            try
            {
                return (this.Base * this.Altura) / 2;
            }
            catch (Exception)
            {
                return (0 * 0) / 2;
            }
            
        }
    }
}
