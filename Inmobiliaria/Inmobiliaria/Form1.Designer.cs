
namespace Inmobiliaria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.radioPiso = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Dirección = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVentanas);
            this.panel1.Controls.Add(this.txtPiso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioLocal);
            this.panel1.Controls.Add(this.radioPiso);
            this.panel1.Location = new System.Drawing.Point(98, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 250);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // txtVentanas
            // 
            this.txtVentanas.Enabled = false;
            this.txtVentanas.Location = new System.Drawing.Point(245, 166);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(81, 26);
            this.txtVentanas.TabIndex = 5;
            // 
            // txtPiso
            // 
            this.txtPiso.Enabled = false;
            this.txtPiso.Location = new System.Drawing.Point(67, 166);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(81, 26);
            this.txtPiso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro de ventanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Piso Nro";
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(245, 74);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(72, 24);
            this.radioLocal.TabIndex = 1;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            this.radioLocal.CheckedChanged += new System.EventHandler(this.radioLocal_CheckedChanged);
            // 
            // radioPiso
            // 
            this.radioPiso.AutoSize = true;
            this.radioPiso.Location = new System.Drawing.Point(67, 74);
            this.radioPiso.Name = "radioPiso";
            this.radioPiso.Size = new System.Drawing.Size(64, 24);
            this.radioPiso.TabIndex = 0;
            this.radioPiso.TabStop = true;
            this.radioPiso.Text = "Piso";
            this.radioPiso.UseVisualStyleBackColor = true;
            this.radioPiso.CheckedChanged += new System.EventHandler(this.radioPiso_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de inmueble";
            // 
            // Dirección
            // 
            this.Dirección.AutoSize = true;
            this.Dirección.Location = new System.Drawing.Point(54, 348);
            this.Dirección.Name = "Dirección";
            this.Dirección.Size = new System.Drawing.Size(75, 20);
            this.Dirección.TabIndex = 4;
            this.Dirección.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Superficie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "m2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Antigüedad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "años";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio base";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(54, 646);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 20);
            this.lblPrecioFinal.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(58, 388);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(522, 26);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(76, 482);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(103, 26);
            this.txtSuperficie.TabIndex = 11;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(263, 482);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(103, 26);
            this.txtAntiguedad.TabIndex = 12;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(460, 482);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(103, 26);
            this.txtPrecioBase.TabIndex = 13;
            // 
            // btnCalcularPrecioFinal
            // 
            this.btnCalcularPrecioFinal.Location = new System.Drawing.Point(59, 551);
            this.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal";
            this.btnCalcularPrecioFinal.Size = new System.Drawing.Size(521, 52);
            this.btnCalcularPrecioFinal.TabIndex = 14;
            this.btnCalcularPrecioFinal.Text = "Calcular precio final";
            this.btnCalcularPrecioFinal.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioFinal.Click += new System.EventHandler(this.btnCalcularPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 727);
            this.Controls.Add(this.btnCalcularPrecioFinal);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dirección);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.RadioButton radioPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dirección;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Button btnCalcularPrecioFinal;
    }
}

