using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;

namespace vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validador da = new Validador();
            string cadena = "";
            if (da.esEntero(txtEntero.Text))
            {
                cadena += "Entero : " + txtEntero.Text + "\n";
            }
            if (da.esDecimal(txtDecimal.Text))
            {
                cadena += "Decimal : " + txtDecimal.Text+"\n";
            }
            if (da.esEdad(txtEdad.Text))
            {
                cadena += "Edad : " + txtEdad.Text + "\n";
            }
            if (cadena.Equals(""))
            {
                MessageBox.Show("Todas rechazadas");
            }
            else
            {
                MessageBox.Show("Aceptadas \n" + cadena);
            }
        }
    }
}
