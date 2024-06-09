namespace proyecto_acell
{
    partial class crearnuevoempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearnuevoempleado));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtci = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregistrarempleado = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.combturno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(164, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(164, 122);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(100, 22);
            this.txtci.TabIndex = 1;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(164, 185);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.txtdireccion.TabIndex = 2;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(164, 247);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 22);
            this.txttelefono.TabIndex = 3;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(164, 312);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 22);
            this.txtcorreo.TabIndex = 4;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "direccion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ci";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(558, 234);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 22);
            this.txtusuario.TabIndex = 10;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(558, 288);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 22);
            this.txtcontrasena.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "usuario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "contraseña";
            // 
            // btnregistrarempleado
            // 
            this.btnregistrarempleado.Location = new System.Drawing.Point(690, 380);
            this.btnregistrarempleado.Name = "btnregistrarempleado";
            this.btnregistrarempleado.Size = new System.Drawing.Size(75, 23);
            this.btnregistrarempleado.TabIndex = 15;
            this.btnregistrarempleado.Text = "registrar";
            this.btnregistrarempleado.UseVisualStyleBackColor = true;
            this.btnregistrarempleado.Click += new System.EventHandler(this.btnregistrarempleado_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(546, 380);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(499, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 149);
            this.panel1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "turno";
            // 
            // combturno
            // 
            this.combturno.FormattingEnabled = true;
            this.combturno.Items.AddRange(new object[] {
            "M",
            "T",
            "N"});
            this.combturno.Location = new System.Drawing.Point(164, 354);
            this.combturno.Name = "combturno";
            this.combturno.Size = new System.Drawing.Size(121, 24);
            this.combturno.TabIndex = 19;
            // 
            // crearnuevoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combturno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrarempleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.txtnombre);
            this.Name = "crearnuevoempleado";
            this.Tag = "";
            this.Text = "crearnuevoempleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregistrarempleado;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combturno;
    }
}