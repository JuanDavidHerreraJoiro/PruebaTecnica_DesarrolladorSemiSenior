using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Rectangulo : Figura
    {
        public override double PreCalculo()
        {
            return this.Base * this.Altura;
        }
    }
}
