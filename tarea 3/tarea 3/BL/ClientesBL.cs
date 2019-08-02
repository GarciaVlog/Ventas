using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea_3.Modelo;

namespace tarea_3.BL
{
    public class ClientesBL
    {
        public List<Clientes> ListadeCliente { get; set; }

        public ClientesBL()
        {
            ListadeCliente = new List<Clientes>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Progreso");
            var ciudad2 = new Ciudad(2, "Pimienta");

            var Cliente1 = new Clientes(1, "Orlando Fuentes", "9999-9999", "calle JP2", ciudad1);
            var Cliente2 = new Clientes(2, "Kerly Mendienta", "8888-8888", "7 calle", ciudad2);


            ListadeCliente.Add(Cliente1);
            ListadeCliente.Add(Cliente2);

        }
    }
}
