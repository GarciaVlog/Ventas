using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_3.Modelo
{
    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categorias Categoria { get; set; }

        public Productos(int id, string descripcion, double precio, Categorias categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }
    }
}
