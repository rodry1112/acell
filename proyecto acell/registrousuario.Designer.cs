namespace proyecto_acell
{
    partial class registrousuario
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(341, 78);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(157, 22);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(341, 138);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(157, 22);
            this.txtcontrasena.TabIndex = 1;
            this.txtcontrasena.UseSystemPasswordChar = true;
            this.txtcontrasena.TextChanged += new System.EventHandler(this.txtcontrasena_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(373, 209);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // registrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 287);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Name = "registrousuario";
            this.Text = "registrousuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btningresar;
    }
}