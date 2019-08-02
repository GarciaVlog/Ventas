using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea_3.Modelo;

namespace tarea_3.BL
{
    public class CategoriaBL
    {
        public List<Categorias> ListadeCategoria { get; set; }

        public CategoriaBL()
        {
            ListadeCategoria = new List<Categorias>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categorias(1, "laptops");
            var categoria2 = new Categorias(2, "accesorios");

            ListadeCategoria.Add(categoria1);
            ListadeCategoria.Add(categoria2);
        }
    }
}
