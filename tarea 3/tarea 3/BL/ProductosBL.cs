using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea_3.Modelo;

namespace tarea_3.BL
{
    public class ProductosBL
    {
        public List<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new List<Productos>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categorias(1, "Computadoras");
            var categoria2 = new Categorias(2, "accesorios");

            var Producto1 = new Productos(1, "laptop Acer", 15000, categoria1);
            var Producto2 = new Productos(2, "laptops Apple", 20000, categoria1);
            var Producto3 = new Productos(3, "Mouse", 200, categoria2);

            ListadeProductos.Add(Producto1);
            ListadeProductos.Add(Producto2);
            ListadeProductos.Add(Producto3);
        }
    }
}
