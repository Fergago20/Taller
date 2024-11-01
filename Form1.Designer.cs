namespace Taller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbSeguro = new System.Windows.Forms.CheckBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.cbReparacion = new System.Windows.Forms.ComboBox();
            this.tbSeguro = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btmLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btmSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taller EL COYOTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca del Automóvil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matrícula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Reparación:";
            // 
            // chbSeguro
            // 
            this.chbSeguro.AutoSize = true;
            this.chbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSeguro.Location = new System.Drawing.Point(184, 297);
            this.chbSeguro.Name = "chbSeguro";
            this.chbSeguro.Size = new System.Drawing.Size(77, 20);
            this.chbSeguro.TabIndex = 6;
            this.chbSeguro.Text = "Seguro?";
            this.chbSeguro.UseVisualStyleBackColor = true;
            this.chbSeguro.CheckedChanged += new System.EventHandler(this.chbSeguro_CheckedChanged);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(288, 73);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(132, 20);
            this.tbMarca.TabIndex = 7;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(288, 118);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(132, 20);
            this.tbModelo.TabIndex = 8;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(288, 162);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(132, 20);
            this.tbAño.TabIndex = 9;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(288, 203);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(132, 20);
            this.tbMatricula.TabIndex = 10;
            // 
            // cbReparacion
            // 
            this.cbReparacion.FormattingEnabled = true;
            this.cbReparacion.Location = new System.Drawing.Point(288, 247);
            this.cbReparacion.Name = "cbReparacion";
            this.cbReparacion.Size = new System.Drawing.Size(132, 21);
            this.cbReparacion.TabIndex = 11;
            // 
            // tbSeguro
            // 
            this.tbSeguro.Location = new System.Drawing.Point(288, 297);
            this.tbSeguro.Name = "tbSeguro";
            this.tbSeguro.Size = new System.Drawing.Size(132, 20);
            this.tbSeguro.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.btmLimpiar,
            this.toolStripLabel2,
            this.btmSalir,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "btmGuardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Guardar";
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btmLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btmLimpiar.Image")));
            this.btmLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "Limpiar";
            // 
            // btmSalir
            // 
            this.btmSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btmSalir.Image = ((System.Drawing.Image)(resources.GetObject("btmSalir.Image")));
            this.btmSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(23, 22);
            this.btmSalir.Text = "toolStripButton2";
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "Salir";
            // 
            // dgvSalida
            // 
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(475, 73);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.Size = new System.Drawing.Size(313, 195);
            this.dgvSalida.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbSeguro);
            this.Controls.Add(this.cbReparacion);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.chbSeguro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbSeguro;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.ComboBox cbReparacion;
        private System.Windows.Forms.TextBox tbSeguro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btmLimpiar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btmSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView dgvSalida;
    }
}

