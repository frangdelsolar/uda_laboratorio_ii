
namespace DesafioFinal
{
    partial class TiendaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupTipoPrenda = new System.Windows.Forms.GroupBox();
            this.checkBoxBermuda = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.groupCalidad = new System.Windows.Forms.GroupBox();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupTipoPrenda.SuspendLayout();
            this.groupCalidad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTipoPrenda
            // 
            this.groupTipoPrenda.Controls.Add(this.checkBoxBermuda);
            this.groupTipoPrenda.Controls.Add(this.checkBoxMangaCorta);
            this.groupTipoPrenda.Controls.Add(this.radioPantalon);
            this.groupTipoPrenda.Controls.Add(this.radioCamisa);
            this.groupTipoPrenda.Location = new System.Drawing.Point(35, 71);
            this.groupTipoPrenda.Name = "groupTipoPrenda";
            this.groupTipoPrenda.Size = new System.Drawing.Size(357, 190);
            this.groupTipoPrenda.TabIndex = 0;
            this.groupTipoPrenda.TabStop = false;
            this.groupTipoPrenda.Text = "Tipo de Prenda";
            // 
            // checkBoxBermuda
            // 
            this.checkBoxBermuda.AutoSize = true;
            this.checkBoxBermuda.Enabled = false;
            this.checkBoxBermuda.Location = new System.Drawing.Point(211, 110);
            this.checkBoxBermuda.Name = "checkBoxBermuda";
            this.checkBoxBermuda.Size = new System.Drawing.Size(100, 24);
            this.checkBoxBermuda.TabIndex = 3;
            this.checkBoxBermuda.Text = "Bermuda";
            this.checkBoxBermuda.UseVisualStyleBackColor = true;
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Enabled = false;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(211, 64);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(124, 24);
            this.checkBoxMangaCorta.TabIndex = 2;
            this.checkBoxMangaCorta.Text = "Manga corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(39, 109);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(97, 24);
            this.radioPantalon.TabIndex = 1;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Location = new System.Drawing.Point(39, 64);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(87, 24);
            this.radioCamisa.TabIndex = 0;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // groupCalidad
            // 
            this.groupCalidad.Controls.Add(this.radioPremium);
            this.groupCalidad.Controls.Add(this.radioStandard);
            this.groupCalidad.Location = new System.Drawing.Point(35, 284);
            this.groupCalidad.Name = "groupCalidad";
            this.groupCalidad.Size = new System.Drawing.Size(357, 104);
            this.groupCalidad.TabIndex = 1;
            this.groupCalidad.TabStop = false;
            this.groupCalidad.Text = "Calidad de la prenda";
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(192, 46);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(96, 24);
            this.radioPremium.TabIndex = 3;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(39, 46);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(100, 24);
            this.radioStandard.TabIndex = 2;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(35, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(23, 47);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 26);
            this.txtPrecio.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Location = new System.Drawing.Point(227, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 104);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(19, 47);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 26);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnCalcularPrecioFinal
            // 
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(35, 577);
            this.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal";
            this.btnCalcularPrecioFinal.Size = new System.Drawing.Size(357, 48);
            this.btnCalcularPrecioFinal.TabIndex = 4;
            this.btnCalcularPrecioFinal.Text = "CalcularPrecioFinal";
            this.btnCalcularPrecioFinal.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioFinal.Click += new System.EventHandler(this.btnCalcularPrecioFinal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "VENTAS AL POR MAYOR - PradBit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TiendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupCalidad);
            this.Controls.Add(this.groupTipoPrenda);
            this.Name = "TiendaForm";
            this.Text = "Ventas al por mayor";
            this.groupTipoPrenda.ResumeLayout(false);
            this.groupTipoPrenda.PerformLayout();
            this.groupCalidad.ResumeLayout(false);
            this.groupCalidad.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTipoPrenda;
        private System.Windows.Forms.CheckBox checkBoxBermuda;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.GroupBox groupCalidad;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcularPrecioFinal;
        private System.Windows.Forms.Label label1;
    }
}

