using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class TiendaForm : Form
    {
        public TiendaForm()
        {
            InitializeComponent();
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMangaCorta.Enabled = radioCamisa.Checked;
        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBermuda.Enabled = radioPantalon.Checked;
        }

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {

            if (!isInputValid()) return;

            Prenda prenda = null;

            float precioBase = float.Parse(txtPrecio.Text);
            int cantidadPrendas = Convert.ToInt32(txtCantidad.Text);
            bool esPremium = radioPremium.Checked;

            if (radioCamisa.Checked == true)
            {
                bool esMangaCorta = checkBoxMangaCorta.Checked;
                prenda = new Camisa(esMangaCorta, esPremium, precioBase);
            } else
            {
                bool esBermuda = checkBoxBermuda.Checked;
                prenda = new Pantalon(esBermuda, esPremium, precioBase);
            }

            float precioFinal = prenda.CalcularPrecioFinal(cantidadPrendas);
            MessageBox.Show("El precio total de la compra es de $" + precioFinal, "Precio Final");
        }

        private bool isInputValid()
        {

            // Validación de datos
            bool precioValid = txtPrecio.Text != "";
            bool cantidadValid = txtCantidad.Text != "";
            bool tipoPrendaValid = radioCamisa.Checked || radioPantalon.Checked;
            bool calidadValid = radioPremium.Checked || radioStandard.Checked;

            txtPrecio.BackColor = default(Color);
            txtCantidad.BackColor = default(Color);
            groupTipoPrenda.BackColor = default(Color);
            groupCalidad.BackColor = default(Color);

            if (!precioValid) txtPrecio.BackColor = Color.FromArgb(200, 20, 20);
            if (!cantidadValid) txtCantidad.BackColor = Color.FromArgb(200, 20, 20);
            if (!tipoPrendaValid) groupTipoPrenda.BackColor = Color.FromArgb(200, 20, 20);
            if (!calidadValid) groupCalidad.BackColor = Color.FromArgb(200, 20, 20);

            if (!precioValid || !cantidadValid || !tipoPrendaValid || !calidadValid)
                return false;
            else
                return true;
        }
    }
}
