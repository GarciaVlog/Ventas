using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public abstract class Personajes
    {
        public string Nombre { get; set; }
        public string Rango { get; set; }
        public string NiveldePoder { get; set; }
        public string Genero { get; set; }

        //Rangos Hereos: B,C son comunes podrian pelear con villanos tigre, ogro / S,A son superiores podrian pelear con villanos rango Dragon o Dios.
        //Rangos Villanos: tigre, ogro, Dragon, Dios el orden de menor a mayor peligro.


    }
}
