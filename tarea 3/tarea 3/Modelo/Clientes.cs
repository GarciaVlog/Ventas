﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_3.Modelo
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        public Clientes(int id, string nombre, string telefono, string direccion, Ciudad ciudad)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad = ciudad;
            CiudadId = ciudad.Id;
        }
    }
}
