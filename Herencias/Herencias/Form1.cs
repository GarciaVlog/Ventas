using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Nombre = "Saitama";
            heroe1.Rango = "C";
            heroe1.NiveldePoder = "1000000";
            heroe1.Genero = "Masculino";
            heroe1.SuperFuerza = true;
            heroe1.Velocidad = true;
            heroe1.Volar = false;
            heroe1.Telequinesis = false;
            heroe1.NiveldeFama = 500;

            var heroe2 = new Heroe();
            heroe2.Nombre = "Genos";
            heroe2.Rango = "S";
            heroe2.NiveldePoder = "40000";
            heroe2.Genero = "Masculino";
            heroe2.SuperFuerza = true;
            heroe2.Velocidad = true;
            heroe2.Volar = true;
            heroe2.Telequinesis = false;
            heroe2.NiveldeFama = 5000;

            var heroe3 = new Heroe();
            heroe3.Nombre = "Sweet Mask";
            heroe3.Rango = "A";
            heroe3.NiveldePoder = "25000";
            heroe3.Genero = "Masculino";
            heroe3.SuperFuerza = true;
            heroe3.Velocidad = true;
            heroe3.Volar = false;
            heroe3.Telequinesis = true;
            heroe3.NiveldeFama = 150000;
            MessageBox.Show("\nNombre:" + heroe1.Nombre +"\nRango:  " + heroe1.Rango + "\nNivel De Poder:" + heroe1.NiveldePoder + "\nGenero:" + heroe1.Genero + "\nSuper Fuerza:" + heroe1.SuperFuerza + "\nVuela:" + heroe1.Volar + "\nTelequinesis:" + heroe1.Telequinesis + "\nVelocidad:" + heroe1.Velocidad + "\nFama:" + heroe1.NiveldeFama);
            MessageBox.Show("\nNombre:" + heroe2.Nombre +"\nRango:  " + heroe2.Rango + "\nNivel De Poder:" + heroe2.NiveldePoder + "\nGenero:" + heroe2.Genero + "\nSuper Fuerza:" + heroe2.SuperFuerza + "\nVuela:" + heroe2.Volar + "\nTelequinesis:" + heroe2.Telequinesis + "\nVelocidad:" + heroe2.Velocidad + "\nFama:" + heroe2.NiveldeFama);
            MessageBox.Show("\nNombre:" + heroe3.Nombre +"\nRango:  " + heroe3.Rango + "\nNivel De Poder:" + heroe3.NiveldePoder + "\nGenero:" + heroe3.Genero + "\nSuper Fuerza:" + heroe3.SuperFuerza + "\nVuela:" + heroe3.Volar + "\nTelequinesis:" + heroe3.Telequinesis + "\nVelocidad:" + heroe3.Velocidad + "\nFama:" + heroe3.NiveldeFama);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var villano1 = new Villano();
            villano1.Nombre = "Orochi";
            villano1.NiveldePoder = "900000";
            villano1.Rango = "Dragon";
            villano1.Genero = "Masculino";
            villano1.SuperFuerza = true;
            villano1.Telequinesis = true;
            villano1.Volar = false;
            villano1.Velocidad = false;
            villano1.NiveldeMaldad = 100000;

            var villano2 = new Villano();
            villano2.Nombre = "Garou";
            villano2.NiveldePoder = "700000";
            villano2.Rango = "Dragon/Dios";
            villano2.Genero = "Masculino";
            villano2.SuperFuerza = true;
            villano2.Telequinesis = false;
            villano2.Volar = false;
            villano2.Velocidad = true;
            villano2.NiveldeMaldad = 100000;

            var villano3 = new Villano();
            villano3.Nombre = "Speed-o'-Sound Sonic";
            villano3.NiveldePoder = "30000";
            villano3.Rango = "Tigre";
            villano3.Genero = "Masculino";
            villano3.SuperFuerza = false;
            villano3.Telequinesis = false;
            villano3.Volar = false;
            villano3.Velocidad = true;
            villano3.NiveldeMaldad = 1000;

            MessageBox.Show("\nNombre:" + villano1.Nombre + "\nRango:  " + villano1.Rango + "\nNivel De Poder:" + villano1.NiveldePoder + "\nGenero:" + villano1.Genero + "\nSuper Fuerza:" + villano1.SuperFuerza + "\nVuela:" + villano1.Volar + "\nTelequinesis:" + villano1.Telequinesis + "\nVelocidad:" + villano1.Velocidad + "\nMaldas:" + villano1.NiveldeMaldad);
            MessageBox.Show("\nNombre:" + villano2.Nombre + "\nRango:  " + villano2.Rango + "\nNivel De Poder:" + villano2.NiveldePoder + "\nGenero:" + villano2.Genero + "\nSuper Fuerza:" + villano2.SuperFuerza + "\nVuela:" + villano2.Volar + "\nTelequinesis:" + villano2.Telequinesis + "\nVelocidad:" + villano2.Velocidad + "\nMaldas:" + villano2.NiveldeMaldad);
            MessageBox.Show("\nNombre:" + villano3.Nombre + "\nRango:  " + villano3.Rango + "\nNivel De Poder:" + villano3.NiveldePoder + "\nGenero:" + villano3.Genero + "\nSuper Fuerza:" + villano3.SuperFuerza + "\nVuela:" + villano3.Volar + "\nTelequinesis:" + villano3.Telequinesis + "\nVelocidad:" + villano3.Velocidad + "\nMaldas:" + villano3.NiveldeMaldad);
        }
    }
}
