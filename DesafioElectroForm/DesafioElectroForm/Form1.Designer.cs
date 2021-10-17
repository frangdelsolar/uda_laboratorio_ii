
namespace DesafioElectroForm
{
    partial class Form1
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
            this.lblTotalTV = new System.Windows.Forms.Label();
            this.lblTotalLavadoras = new System.Windows.Forms.Label();
            this.lblTotalElectro = new System.Windows.Forms.Label();
            this.listElectrodomesticos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.panLavadora = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panTV = new System.Windows.Forms.Panel();
            this.chcSintonizador = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboConsumo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioLavadora = new System.Windows.Forms.RadioButton();
            this.radioTV = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panLavadora.SuspendLayout();
            this.panTV.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalTV
            // 
            this.lblTotalTV.AutoSize = true;
            this.lblTotalTV.Location = new System.Drawing.Point(25, 686);
            this.lblTotalTV.Name = "lblTotalTV";
            this.lblTotalTV.Size = new System.Drawing.Size(80, 20);
            this.lblTotalTV.TabIndex = 0;
            this.lblTotalTV.Text = "Total TVs:";
            // 
            // lblTotalLavadoras
            // 
            this.lblTotalLavadoras.AutoSize = true;
            this.lblTotalLavadoras.Location = new System.Drawing.Point(25, 718);
            this.lblTotalLavadoras.Name = "lblTotalLavadoras";
            this.lblTotalLavadoras.Size = new System.Drawing.Size(126, 20);
            this.lblTotalLavadoras.TabIndex = 1;
            this.lblTotalLavadoras.Text = "Total Lavadoras:";
            // 
            // lblTotalElectro
            // 
            this.lblTotalElectro.AutoSize = true;
            this.lblTotalElectro.Location = new System.Drawing.Point(25, 748);
            this.lblTotalElectro.Name = "lblTotalElectro";
            this.lblTotalElectro.Size = new System.Drawing.Size(48, 20);
            this.lblTotalElectro.TabIndex = 2;
            this.lblTotalElectro.Text = "Total:";
            // 
            // listElectrodomesticos
            // 
            this.listElectrodomesticos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listElectrodomesticos.HideSelection = false;
            this.listElectrodomesticos.Location = new System.Drawing.Point(29, 436);
            this.listElectrodomesticos.Name = "listElectrodomesticos";
            this.listElectrodomesticos.Size = new System.Drawing.Size(984, 221);
            this.listElectrodomesticos.TabIndex = 3;
            this.listElectrodomesticos.UseCompatibleStateImageBehavior = false;
            this.listElectrodomesticos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Electrodomestico";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Consumo";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Peso";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Carga";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Resolucion";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sintonizador";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio Base";
            this.columnHeader8.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAnadir);
            this.panel1.Controls.Add(this.panLavadora);
            this.panel1.Controls.Add(this.panTV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(29, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 357);
            this.panel1.TabIndex = 4;
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(735, 105);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(246, 58);
            this.buttonAnadir.TabIndex = 22;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // panLavadora
            // 
            this.panLavadora.Controls.Add(this.label11);
            this.panLavadora.Controls.Add(this.txtCarga);
            this.panLavadora.Controls.Add(this.label12);
            this.panLavadora.Enabled = false;
            this.panLavadora.Location = new System.Drawing.Point(37, 277);
            this.panLavadora.Name = "panLavadora";
            this.panLavadora.Size = new System.Drawing.Size(313, 79);
            this.panLavadora.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Kg";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(23, 39);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(230, 26);
            this.txtCarga.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ingrese carga";
            // 
            // panTV
            // 
            this.panTV.Controls.Add(this.chcSintonizador);
            this.panTV.Controls.Add(this.label9);
            this.panTV.Controls.Add(this.txtResol);
            this.panTV.Controls.Add(this.label10);
            this.panTV.Enabled = false;
            this.panTV.Location = new System.Drawing.Point(367, 278);
            this.panTV.Name = "panTV";
            this.panTV.Size = new System.Drawing.Size(498, 78);
            this.panTV.TabIndex = 20;
            // 
            // chcSintonizador
            // 
            this.chcSintonizador.AutoSize = true;
            this.chcSintonizador.Location = new System.Drawing.Point(321, 38);
            this.chcSintonizador.Name = "chcSintonizador";
            this.chcSintonizador.Size = new System.Drawing.Size(158, 24);
            this.chcSintonizador.TabIndex = 19;
            this.chcSintonizador.Text = "Sintonizador TDT";
            this.chcSintonizador.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Inch";
            // 
            // txtResol
            // 
            this.txtResol.Location = new System.Drawing.Point(21, 38);
            this.txtResol.Name = "txtResol";
            this.txtResol.Size = new System.Drawing.Size(230, 26);
            this.txtResol.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ingrese resolución";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kg";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(435, 175);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 26);
            this.txtPrecio.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ingrese peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "$";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(455, 94);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(230, 26);
            this.txtPeso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingrese precio base";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboConsumo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(236, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 106);
            this.panel4.TabIndex = 6;
            // 
            // comboConsumo
            // 
            this.comboConsumo.FormattingEnabled = true;
            this.comboConsumo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboConsumo.Location = new System.Drawing.Point(11, 55);
            this.comboConsumo.Name = "comboConsumo";
            this.comboConsumo.Size = new System.Drawing.Size(151, 28);
            this.comboConsumo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione consumo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboColor);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(236, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 106);
            this.panel3.TabIndex = 1;
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Rojo",
            "Azul",
            "Gris"});
            this.comboColor.Location = new System.Drawing.Point(11, 55);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(152, 28);
            this.comboColor.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione color";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioLavadora);
            this.panel2.Controls.Add(this.radioTV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 173);
            this.panel2.TabIndex = 0;
            // 
            // radioLavadora
            // 
            this.radioLavadora.AutoSize = true;
            this.radioLavadora.Location = new System.Drawing.Point(11, 96);
            this.radioLavadora.Name = "radioLavadora";
            this.radioLavadora.Size = new System.Drawing.Size(100, 24);
            this.radioLavadora.TabIndex = 2;
            this.radioLavadora.TabStop = true;
            this.radioLavadora.Text = "Lavadora";
            this.radioLavadora.UseVisualStyleBackColor = true;
            this.radioLavadora.CheckedChanged += new System.EventHandler(this.radioLavadora_CheckedChanged);
            // 
            // radioTV
            // 
            this.radioTV.AutoSize = true;
            this.radioTV.Location = new System.Drawing.Point(11, 66);
            this.radioTV.Name = "radioTV";
            this.radioTV.Size = new System.Drawing.Size(54, 24);
            this.radioTV.TabIndex = 1;
            this.radioTV.TabStop = true;
            this.radioTV.Text = "TV";
            this.radioTV.UseVisualStyleBackColor = true;
            this.radioTV.CheckedChanged += new System.EventHandler(this.radioLavadora_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione tipo *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Añadir Electrodoméstico";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Precio Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 802);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listElectrodomesticos);
            this.Controls.Add(this.lblTotalElectro);
            this.Controls.Add(this.lblTotalLavadoras);
            this.Controls.Add(this.lblTotalTV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panLavadora.ResumeLayout(false);
            this.panLavadora.PerformLayout();
            this.panTV.ResumeLayout(false);
            this.panTV.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalTV;
        private System.Windows.Forms.Label lblTotalLavadoras;
        private System.Windows.Forms.Label lblTotalElectro;
        private System.Windows.Forms.ListView listElectrodomesticos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioLavadora;
        private System.Windows.Forms.RadioButton radioTV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.Panel panLavadora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panTV;
        private System.Windows.Forms.CheckBox chcSintonizador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.ComboBox comboConsumo;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

