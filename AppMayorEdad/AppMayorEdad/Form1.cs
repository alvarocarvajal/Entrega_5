using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMayorEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(txtNombre.Text, int.Parse(txtEdad.Text));

            if (persona1.Edad >= 18)
            {
                MessageBox.Show(" La Edad De " + persona1.Nombre + " Es " + persona1.Edad + " Y Es Mayor De 18 Años. ");

            }

            else
            {
                MessageBox.Show(" La Edad De " + persona1.Nombre + " Es " + persona1.Edad + " Y Es Menor De 18 Años. ");
               
            }

        }
    }
}
