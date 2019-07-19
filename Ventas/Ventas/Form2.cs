using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ciudad1 = new Ciudad();
                Ciudad1.Id = 1;
                Ciudad1.Descripcion = "Choloma";

            Ciudad Ciudad2 = new Ciudad();
                Ciudad2.Id = 2;
                Ciudad2.Descripcion = "Tegucigalpa";

            Ciudad Ciudad3 = new Ciudad();
                Ciudad3.Id = 1;
                Ciudad3.Descripcion = "Yoro";
            
            var Clientes1 = new Clientes();
                Clientes1.Id = 1;
                Clientes1.Nombre = "Josue Martinez";
                Clientes1.Telefono = "9568-5594";
                Clientes1.Ciudad = Ciudad1;

            Clientes Clientes2 = new Clientes();
                Clientes2.Id = 2;
                Clientes2.Nombre = "Maria Martinez";
                Clientes2.Telefono = "9568-5794";
                Clientes2.Ciudad = Ciudad2;

            Clientes Clientes3 = new Clientes();
                Clientes3.Id = 3;
                Clientes3.Nombre = "Jose Martinez";
                Clientes3.Telefono = "9568-4894";
                Clientes3.Ciudad = Ciudad3;


            var ListadeClientes = new List<Clientes>();
                ListadeClientes.Add(Clientes1);
                ListadeClientes.Add(Clientes2);
                ListadeClientes.Add(Clientes3);

            foreach (var Clientes in ListadeClientes)
            {
                MessageBox.Show("\n" + "Nombre" + ": " + Clientes.Nombre + "\n" + "Cuidad" + ": " + Clientes.Ciudad.Descripcion + "\n" + "Telefono" + ": " + Clientes.Telefono);
            }

        
    }
    }
}
