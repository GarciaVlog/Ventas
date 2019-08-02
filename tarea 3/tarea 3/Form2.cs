using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_3.BL;

namespace tarea_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var clienteBL = new ClientesBL();
            listadeClienteBindingSource.DataSource = clienteBL.ListadeCliente;

            var ciudadBL = new CiudadBL();
            listadeCiudadBindingSource.DataSource = ciudadBL.ListadeCiudad;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
