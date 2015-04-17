using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbRojo.Items.Add(" Rojo ");
            cmbRojo.Items.Add(" Azul ");
            cmbRojo.Items.Add(" Negro ");
            cmbRojo.Items.Add(" Blanco ");
            cmbRojo.Items.Add(" Verde ");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAzul.Text = cmbRojo.SelectedItem.ToString();
           
        }

        private void cmbRojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
