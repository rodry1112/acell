namespace proyecto_acell
{
    partial class mainformacell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainformacell));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarNuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btninventario = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbci = new System.Windows.Forms.Label();
            this.lbturno = new System.Windows.Forms.Label();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoEmpleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarNuevoEmpleadoToolStripMenuItem
            // 
            this.registrarNuevoEmpleadoToolStripMenuItem.Name = "registrarNuevoEmpleadoToolStripMenuItem";
            this.registrarNuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.registrarNuevoEmpleadoToolStripMenuItem.Text = "registrar nuevo empleado";
            this.registrarNuevoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoEmpleadoToolStripMenuItem_Click);
            // 
            // btninventario
            // 
            this.btninventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btninventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninventario.Image = ((System.Drawing.Image)(resources.GetObject("btninventario.Image")));
            this.btninventario.Location = new System.Drawing.Point(263, 128);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(283, 238);
            this.btninventario.TabIndex = 2;
            this.btninventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // btnventa
            // 
            this.btnventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnventa.Image = ((System.Drawing.Image)(resources.GetObject("btnventa.Image")));
            this.btnventa.Location = new System.Drawing.Point(567, 128);
            this.btnventa.Margin = new System.Windows.Forms.Padding(8);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(273, 238);
            this.btnventa.TabIndex = 3;
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "almacen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "venta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbusuario);
            this.panel1.Controls.Add(this.lbtelefono);
            this.panel1.Controls.Add(this.lbturno);
            this.panel1.Controls.Add(this.lbci);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbnombre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 437);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(49, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 125);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "ci";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(67, 208);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(15, 16);
            this.lbnombre.TabIndex = 5;
            this.lbnombre.Text = "d";
            this.lbnombre.Click += new System.EventHandler(this.lbnombre_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "telefono";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbci
            // 
            this.lbci.AutoSize = true;
            this.lbci.Location = new System.Drawing.Point(67, 256);
            this.lbci.Name = "lbci";
            this.lbci.Size = new System.Drawing.Size(16, 16);
            this.lbci.TabIndex = 7;
            this.lbci.Text = "w";
            // 
            // lbturno
            // 
            this.lbturno.AutoSize = true;
            this.lbturno.Location = new System.Drawing.Point(93, 315);
            this.lbturno.Name = "lbturno";
            this.lbturno.Size = new System.Drawing.Size(16, 16);
            this.lbturno.TabIndex = 8;
            this.lbturno.Text = "w";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Location = new System.Drawing.Point(45, 357);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(15, 16);
            this.lbtelefono.TabIndex = 9;
            this.lbtelefono.Text = "d";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(45, 402);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(15, 16);
            this.lbusuario.TabIndex = 10;
            this.lbusuario.Text = "d";
            // 
            // mainformacell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainformacell";
            this.Text = "mainformacell";
            this.Load += new System.EventHandler(this.mainformacell_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbturno;
        private System.Windows.Forms.Label lbci;
    }
}