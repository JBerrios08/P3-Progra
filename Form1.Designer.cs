namespace Parcial3
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblMinimoValor = new System.Windows.Forms.Label();
            this.lblMaximoValor = new System.Windows.Forms.Label();
            this.lblConteoValor = new System.Windows.Forms.Label();
            this.lblPromedioValor = new System.Windows.Forms.Label();
            this.lblMinimoTitulo = new System.Windows.Forms.Label();
            this.lblMaximoTitulo = new System.Windows.Forms.Label();
            this.lblConteoTitulo = new System.Windows.Forms.Label();
            this.lblPromedioTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.panelPrincipal.Controls.Add(this.panelResultados);
            this.panelPrincipal.Controls.Add(this.btnCalcular);
            this.panelPrincipal.Controls.Add(this.txtVentas);
            this.panelPrincipal.Controls.Add(this.lblInstrucciones);
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(43, 39, 43, 39);
            this.panelPrincipal.Size = new System.Drawing.Size(1045, 629);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelResultados
            // 
            this.panelResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResultados.BackColor = System.Drawing.Color.White;
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Controls.Add(this.lblAviso);
            this.panelResultados.Controls.Add(this.lblMinimoValor);
            this.panelResultados.Controls.Add(this.lblMaximoValor);
            this.panelResultados.Controls.Add(this.lblConteoValor);
            this.panelResultados.Controls.Add(this.lblPromedioValor);
            this.panelResultados.Controls.Add(this.lblMinimoTitulo);
            this.panelResultados.Controls.Add(this.lblMaximoTitulo);
            this.panelResultados.Controls.Add(this.lblConteoTitulo);
            this.panelResultados.Controls.Add(this.lblPromedioTitulo);
            this.panelResultados.Location = new System.Drawing.Point(47, 352);
            this.panelResultados.Margin = new System.Windows.Forms.Padding(4);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Padding = new System.Windows.Forms.Padding(32, 30, 32, 30);
            this.panelResultados.Size = new System.Drawing.Size(951, 212);
            this.panelResultados.TabIndex = 4;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblAviso.Location = new System.Drawing.Point(36, 158);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 20);
            this.lblAviso.TabIndex = 8;
            // 
            // lblMinimoValor
            // 
            this.lblMinimoValor.AutoSize = true;
            this.lblMinimoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.lblMinimoValor.Location = new System.Drawing.Point(543, 107);
            this.lblMinimoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimoValor.Name = "lblMinimoValor";
            this.lblMinimoValor.Size = new System.Drawing.Size(24, 28);
            this.lblMinimoValor.TabIndex = 7;
            this.lblMinimoValor.Text = "0";
            // 
            // lblMaximoValor
            // 
            this.lblMaximoValor.AutoSize = true;
            this.lblMaximoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.lblMaximoValor.Location = new System.Drawing.Point(543, 54);
            this.lblMaximoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximoValor.Name = "lblMaximoValor";
            this.lblMaximoValor.Size = new System.Drawing.Size(24, 28);
            this.lblMaximoValor.TabIndex = 6;
            this.lblMaximoValor.Text = "0";
            // 
            // lblConteoValor
            // 
            this.lblConteoValor.AutoSize = true;
            this.lblConteoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.lblConteoValor.Location = new System.Drawing.Point(231, 107);
            this.lblConteoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConteoValor.Name = "lblConteoValor";
            this.lblConteoValor.Size = new System.Drawing.Size(24, 28);
            this.lblConteoValor.TabIndex = 5;
            this.lblConteoValor.Text = "0";
            // 
            // lblPromedioValor
            // 
            this.lblPromedioValor.AutoSize = true;
            this.lblPromedioValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.lblPromedioValor.Location = new System.Drawing.Point(231, 54);
            this.lblPromedioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioValor.Name = "lblPromedioValor";
            this.lblPromedioValor.Size = new System.Drawing.Size(24, 28);
            this.lblPromedioValor.TabIndex = 4;
            this.lblPromedioValor.Text = "0";
            // 
            // lblMinimoTitulo
            // 
            this.lblMinimoTitulo.AutoSize = true;
            this.lblMinimoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMinimoTitulo.Location = new System.Drawing.Point(401, 108);
            this.lblMinimoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimoTitulo.Name = "lblMinimoTitulo";
            this.lblMinimoTitulo.Size = new System.Drawing.Size(120, 23);
            this.lblMinimoTitulo.TabIndex = 3;
            this.lblMinimoTitulo.Text = "Venta mínima:";
            // 
            // lblMaximoTitulo
            // 
            this.lblMaximoTitulo.AutoSize = true;
            this.lblMaximoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaximoTitulo.Location = new System.Drawing.Point(401, 55);
            this.lblMaximoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximoTitulo.Name = "lblMaximoTitulo";
            this.lblMaximoTitulo.Size = new System.Drawing.Size(123, 23);
            this.lblMaximoTitulo.TabIndex = 2;
            this.lblMaximoTitulo.Text = "Venta máxima:";
            // 
            // lblConteoTitulo
            // 
            this.lblConteoTitulo.AutoSize = true;
            this.lblConteoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConteoTitulo.Location = new System.Drawing.Point(36, 108);
            this.lblConteoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConteoTitulo.Name = "lblConteoTitulo";
            this.lblConteoTitulo.Size = new System.Drawing.Size(169, 23);
            this.lblConteoTitulo.TabIndex = 1;
            this.lblConteoTitulo.Text = "Ventas consideradas:";
            // 
            // lblPromedioTitulo
            // 
            this.lblPromedioTitulo.AutoSize = true;
            this.lblPromedioTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPromedioTitulo.Location = new System.Drawing.Point(36, 55);
            this.lblPromedioTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioTitulo.Name = "lblPromedioTitulo";
            this.lblPromedioTitulo.Size = new System.Drawing.Size(166, 23);
            this.lblPromedioTitulo.TabIndex = 0;
            this.lblPromedioTitulo.Text = "Promedio de ventas:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(421, 277);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 50);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVentas.BackColor = System.Drawing.Color.White;
            this.txtVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVentas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtVentas.Location = new System.Drawing.Point(47, 172);
            this.txtVentas.Margin = new System.Windows.Forms.Padding(4);
            this.txtVentas.Multiline = true;
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVentas.Size = new System.Drawing.Size(951, 97);
            this.txtVentas.TabIndex = 2;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(43, 107);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(956, 62);
            this.lblInstrucciones.TabIndex = 1;
            this.lblInstrucciones.Text = "Escribir cada venta separada por coma, espacio o salto de línea (solo se tomará l" +
    "as ventas de 200 en adelante)";
            this.lblInstrucciones.Click += new System.EventHandler(this.lblInstrucciones_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.lblTitulo.Location = new System.Drawing.Point(336, 39);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Promedio de ventas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.panelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 666);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio de Ventas";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Label lblPromedioTitulo;
        private System.Windows.Forms.Label lblMinimoTitulo;
        private System.Windows.Forms.Label lblMaximoTitulo;
        private System.Windows.Forms.Label lblConteoTitulo;
        private System.Windows.Forms.Label lblMinimoValor;
        private System.Windows.Forms.Label lblMaximoValor;
        private System.Windows.Forms.Label lblConteoValor;
        private System.Windows.Forms.Label lblPromedioValor;
        private System.Windows.Forms.Label lblAviso;
    }
}
