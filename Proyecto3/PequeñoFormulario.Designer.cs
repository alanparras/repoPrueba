namespace Proyecto3
{
    partial class PequeñoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PequeñoFormulario));
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BSAlir = new System.Windows.Forms.Button();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LTarjetas = new System.Windows.Forms.Label();
            this.CNaranja = new System.Windows.Forms.CheckBox();
            this.CVisa = new System.Windows.Forms.CheckBox();
            this.CMaster = new System.Windows.Forms.CheckBox();
            this.LNuevoCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PSexo = new System.Windows.Forms.PictureBox();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(20, 45);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "* DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(20, 72);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(51, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "* Nombre";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(20, 11);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(92, 13);
            this.LNya.TabIndex = 3;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(20, 98);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(51, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "* Apellido";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(137, 11);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(118, 45);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(118, 71);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 6;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(118, 98);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(36, 338);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 42);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(131, 338);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 42);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BSAlir
            // 
            this.BSAlir.Image = ((System.Drawing.Image)(resources.GetObject("BSAlir.Image")));
            this.BSAlir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSAlir.Location = new System.Drawing.Point(355, 338);
            this.BSAlir.Name = "BSAlir";
            this.BSAlir.Size = new System.Drawing.Size(75, 42);
            this.BSAlir.TabIndex = 10;
            this.BSAlir.Text = "Salir";
            this.BSAlir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSAlir.UseVisualStyleBackColor = true;
            this.BSAlir.Click += new System.EventHandler(this.BSAlir_Click);
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(118, 124);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(100, 20);
            this.TTelefono.TabIndex = 12;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(20, 124);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 11;
            this.LTelefono.Text = "Telefono";
            this.LTelefono.Click += new System.EventHandler(this.label1_Click);
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Location = new System.Drawing.Point(20, 171);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(94, 13);
            this.LTarjetas.TabIndex = 13;
            this.LTarjetas.Text = "Tarjeta de Credito:";
            // 
            // CNaranja
            // 
            this.CNaranja.AutoSize = true;
            this.CNaranja.Location = new System.Drawing.Point(121, 171);
            this.CNaranja.Name = "CNaranja";
            this.CNaranja.Size = new System.Drawing.Size(63, 17);
            this.CNaranja.TabIndex = 14;
            this.CNaranja.Text = "Naranja";
            this.CNaranja.UseVisualStyleBackColor = true;
            // 
            // CVisa
            // 
            this.CVisa.AutoSize = true;
            this.CVisa.Location = new System.Drawing.Point(121, 194);
            this.CVisa.Name = "CVisa";
            this.CVisa.Size = new System.Drawing.Size(46, 17);
            this.CVisa.TabIndex = 15;
            this.CVisa.Text = "Visa";
            this.CVisa.UseVisualStyleBackColor = true;
            // 
            // CMaster
            // 
            this.CMaster.AutoSize = true;
            this.CMaster.Location = new System.Drawing.Point(121, 217);
            this.CMaster.Name = "CMaster";
            this.CMaster.Size = new System.Drawing.Size(79, 17);
            this.CMaster.TabIndex = 16;
            this.CMaster.Text = "Mastercard";
            this.CMaster.UseVisualStyleBackColor = true;
            // 
            // LNuevoCliente
            // 
            this.LNuevoCliente.AutoSize = true;
            this.LNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoCliente.ForeColor = System.Drawing.Color.Blue;
            this.LNuevoCliente.Location = new System.Drawing.Point(183, 19);
            this.LNuevoCliente.Name = "LNuevoCliente";
            this.LNuevoCliente.Size = new System.Drawing.Size(165, 29);
            this.LNuevoCliente.TabIndex = 17;
            this.LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.CMaster);
            this.panel1.Controls.Add(this.CVisa);
            this.panel1.Controls.Add(this.CNaranja);
            this.panel1.Controls.Add(this.LTarjetas);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 244);
            this.panel1.TabIndex = 18;
            // 
            // PSexo
            // 
            this.PSexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PSexo.Location = new System.Drawing.Point(293, 75);
            this.PSexo.Name = "PSexo";
            this.PSexo.Size = new System.Drawing.Size(194, 175);
            this.PSexo.TabIndex = 19;
            this.PSexo.TabStop = false;
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(314, 278);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 20;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(411, 278);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 21;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // PequeñoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 393);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.PSexo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LNuevoCliente);
            this.Controls.Add(this.BSAlir);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Name = "PequeñoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.PequeñoFormulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BSAlir;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTarjetas;
        private System.Windows.Forms.CheckBox CNaranja;
        private System.Windows.Forms.CheckBox CVisa;
        private System.Windows.Forms.CheckBox CMaster;
        private System.Windows.Forms.Label LNuevoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PSexo;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
    }
}

