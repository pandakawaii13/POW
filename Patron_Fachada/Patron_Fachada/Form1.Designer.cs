namespace Patron_Fachada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEvaluaCredito = new System.Windows.Forms.Button();
            this.textResultadoValidacion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.textValorPrestamo = new System.Windows.Forms.TextBox();
            this.textPuntajeDatacredito = new System.Windows.Forms.TextBox();
            this.textValorCesantias = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textValorCesantias);
            this.groupBox1.Controls.Add(this.textPuntajeDatacredito);
            this.groupBox1.Controls.Add(this.textValorPrestamo);
            this.groupBox1.Controls.Add(this.textNombreCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos cliente: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor préstamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puntaje datacrédito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor cesantías:";
            // 
            // btnEvaluaCredito
            // 
            this.btnEvaluaCredito.Location = new System.Drawing.Point(141, 230);
            this.btnEvaluaCredito.Name = "btnEvaluaCredito";
            this.btnEvaluaCredito.Size = new System.Drawing.Size(97, 23);
            this.btnEvaluaCredito.TabIndex = 1;
            this.btnEvaluaCredito.Text = "Evaluar crédito";
            this.btnEvaluaCredito.UseVisualStyleBackColor = true;
            this.btnEvaluaCredito.Click += new System.EventHandler(this.btnEvaluaCredito_Click);
            // 
            // textResultadoValidacion
            // 
            this.textResultadoValidacion.Location = new System.Drawing.Point(9, 19);
            this.textResultadoValidacion.Multiline = true;
            this.textResultadoValidacion.Name = "textResultadoValidacion";
            this.textResultadoValidacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResultadoValidacion.Size = new System.Drawing.Size(341, 110);
            this.textResultadoValidacion.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textResultadoValidacion);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado evaluación:";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(128, 24);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(189, 20);
            this.textNombreCliente.TabIndex = 4;
            // 
            // textValorPrestamo
            // 
            this.textValorPrestamo.Location = new System.Drawing.Point(128, 59);
            this.textValorPrestamo.Name = "textValorPrestamo";
            this.textValorPrestamo.Size = new System.Drawing.Size(189, 20);
            this.textValorPrestamo.TabIndex = 5;
            // 
            // textPuntajeDatacredito
            // 
            this.textPuntajeDatacredito.Location = new System.Drawing.Point(128, 100);
            this.textPuntajeDatacredito.Name = "textPuntajeDatacredito";
            this.textPuntajeDatacredito.Size = new System.Drawing.Size(189, 20);
            this.textPuntajeDatacredito.TabIndex = 6;
            // 
            // textValorCesantias
            // 
            this.textValorCesantias.Location = new System.Drawing.Point(128, 142);
            this.textValorCesantias.Name = "textValorCesantias";
            this.textValorCesantias.Size = new System.Drawing.Size(189, 20);
            this.textValorCesantias.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEvaluaCredito);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Préstamos Hipotecarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textValorCesantias;
        private System.Windows.Forms.TextBox textPuntajeDatacredito;
        private System.Windows.Forms.TextBox textValorPrestamo;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Button btnEvaluaCredito;
        private System.Windows.Forms.TextBox textResultadoValidacion;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

