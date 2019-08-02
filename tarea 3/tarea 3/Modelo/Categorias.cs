using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_3.Modelo
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categorias(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
