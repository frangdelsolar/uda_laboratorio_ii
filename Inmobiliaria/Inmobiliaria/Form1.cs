using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    LABORATORIO II
    PROF. JESÚS ARCE
    DESAFÍO HERENCIA
    ALUMNO LIC. FRANCISCO JAVIER GONZÁLEZ DEL SOLAR
 */

namespace Inmobiliaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            Inmueble inmueble;
            String direccion = txtDireccion.Text;
            int superficie = Convert.ToInt32(txtSuperficie.Text);
            int precioBase = Convert.ToInt32(txtPrecioBase.Text);
            int antiguedad = Convert.ToInt32(txtAntiguedad.Text);


            if (radioLocal.Checked == true)
            {
                int ventanas = Convert.ToInt32(txtVentanas.Text);
                inmueble = new Local(ventanas, direccion, superficie, precioBase, antiguedad);
            }   
            else // if (radioPiso.Checked == true)
            {
                int piso = Convert.ToInt32(txtPiso.Text);
                inmueble = new Piso(piso, direccion, superficie, precioBase, antiguedad);
            }

            float precio = inmueble.calcPrecio();
            lblPrecioFinal.Text = "El precio final es de $" + Convert.ToString(precio);
        }

        private void radioPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPiso.Checked == true)
            {
                txtPiso.Enabled = true;
            }
            else if (radioPiso.Checked == false)
            {
                txtPiso.Enabled = false;
            }
        }

        private void radioLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLocal.Checked == true)
            {
                txtVentanas.Enabled = true;
            }
            else if (radioLocal.Checked == false)
            {
                txtVentanas.Enabled = false;
            }
        }
    }
}
