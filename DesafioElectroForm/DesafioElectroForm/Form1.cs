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
 *  Laboratorio II
 *  Prof. Jesús Arce
 *  
 *  Desafío de herencia II
 *  
 *  Autor: Lic. Francisco Javier González del Solar
 * 
 */

namespace DesafioElectroForm
{
    public partial class Form1 : Form
    {

        List<Electrodomestico> electroList = new List<Electrodomestico>();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioLavadora_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLavadora.Checked == true) {
                panLavadora.Enabled = true;
                panTV.Enabled = false;
            }
            else if (radioTV.Checked == true)
            {
                panLavadora.Enabled = false;
                panTV.Enabled = true;
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {

            if (radioTV.Checked == false && radioLavadora.Checked == false)
            {
                MessageBox.Show("Debe seleccionar el tipo de electrodoméstico que desea añadir.", "Antes de continuar");
                return;
            }

            Electrodomestico electro = null;

            // Default values
            // Electro
            int precioBase = 100;
            int peso = 5;
            String color = "blanco";
            String consumo = "F";
            // TV
            int resolucion = 20;
            bool sintonizador = false;
            // Lavadora
            int carga = 5;

            // Check actual values
            if (txtPrecio.Text != "") precioBase = Convert.ToInt32(txtPrecio.Text);
            if (txtPeso.Text != "") peso = Convert.ToInt32(txtPeso.Text);
            if (comboColor.Text != "") color = comboColor.Text;
            if (comboConsumo.Text != "") consumo = comboConsumo.Text;

            if (radioTV.Checked == true)
            {
                if (txtResol.Text != "") resolucion = Convert.ToInt32(txtResol.Text);

                sintonizador = chcSintonizador.Checked;

                electro = new Television(resolucion, sintonizador, precioBase, color, consumo, peso);

            }
            else if (radioLavadora.Checked == true)
            {
                if (txtCarga.Text != "") carga = Convert.ToInt32(txtCarga.Text);

                electro = new Lavadora(carga, precioBase, color, consumo, peso);

            }

            int precioFinal = electro.precioBase;

            electroList.Add(electro);

            ListViewItem item = new ListViewItem(electro.tipo);
            item.SubItems.Add(color);   
            item.SubItems.Add(consumo);
            item.SubItems.Add(Convert.ToString(peso));
            item.SubItems.Add(Convert.ToString(carga));
            item.SubItems.Add(Convert.ToString(resolucion));
            item.SubItems.Add(Convert.ToString(sintonizador));
            item.SubItems.Add(Convert.ToString(precioBase));
            item.SubItems.Add(Convert.ToString(precioFinal));
            listElectrodomesticos.Items.Add(item);

            CalcularTotales();
        }

        public void CalcularTotales()
        {
            int totalTV = 0;
            int totalLavadora = 0;
            int total = 0;

            foreach(Electrodomestico electro in electroList)
            {
                total += electro.precioBase;
                if (electro.tipo == "TV") totalTV += electro.precioBase;
                if (electro.tipo == "Lavadora") totalLavadora += electro.precioBase;
            }

            lblTotalTV.Text = "Total TV: $" + totalTV;
            lblTotalLavadoras.Text = "Total Lavadoras: $" + totalLavadora;
            lblTotalElectro.Text = "Total: $" + total;

        }


    }
}
