using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea_3.Modelo;

namespace tarea_3.BL
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }

        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Progreso");
            var ciudad2 = new Ciudad(2, "Pimienta");

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
        }
    }
}
