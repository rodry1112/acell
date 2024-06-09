namespace proyecto_acell
{
    partial class inventario
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
            this.txtproductos = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciun = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgproductos = new System.Windows.Forms.DataGridView();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnintroducir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtproductos
            // 
            this.txtproductos.Location = new System.Drawing.Point(117, 97);
            this.txtproductos.Name = "txtproductos";
            this.txtproductos.Size = new System.Drawing.Size(100, 22);
            this.txtproductos.TabIndex = 0;
            this.txtproductos.TextChanged += new System.EventHandler(this.txtproductos_TextChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(402, 97);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "precio unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "marca";
            // 
            // txtpreciun
            // 
            this.txtpreciun.Location = new System.Drawing.Point(143, 428);
            this.txtpreciun.Name = "txtpreciun";
            this.txtpreciun.Size = new System.Drawing.Size(100, 22);
            this.txtpreciun.TabIndex = 6;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(612, 97);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 22);
            this.txtmarca.TabIndex = 7;
            this.txtmarca.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(888, 97);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 22);
            this.txtmodelo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "modelo";
            // 
            // dtgproductos
            // 
            this.dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproductos.Location = new System.Drawing.Point(25, 130);
            this.dtgproductos.Name = "dtgproductos";
            this.dtgproductos.RowHeadersWidth = 51;
            this.dtgproductos.RowTemplate.Height = 24;
            this.dtgproductos.Size = new System.Drawing.Size(1030, 274);
            this.dtgproductos.TabIndex = 12;
            this.dtgproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproductos_CellClick);
            this.dtgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproductos_CellContentClick);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(612, 431);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 22);
            this.txttipo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "tipo";
            // 
            // btnintroducir
            // 
            this.btnintroducir.Location = new System.Drawing.Point(1082, 353);
            this.btnintroducir.Name = "btnintroducir";
            this.btnintroducir.Size = new System.Drawing.Size(114, 23);
            this.btnintroducir.TabIndex = 15;
            this.btnintroducir.Text = "introducir datos";
            this.btnintroducir.UseVisualStyleBackColor = true;
            this.btnintroducir.Click += new System.EventHandler(this.btnintroducir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(862, 445);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(114, 23);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(1098, 445);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(1098, 277);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 496);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnintroducir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.dtgproductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtpreciun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtproductos);
            this.MaximizeBox = false;
            this.Name = "inventario";
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproductos;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreciun;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgproductos;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnintroducir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
    }
}

