namespace App
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
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_iniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.Location = new System.Drawing.Point(270, 139);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(124, 27);
            this.btn_iniciarSesion.TabIndex = 1;
            this.btn_iniciarSesion.Text = "Iniciar Sesion";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(240, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txb_usuario
            // 
            this.txb_usuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_usuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario.Location = new System.Drawing.Point(243, 63);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(169, 21);
            this.txb_usuario.TabIndex = 5;
            this.txb_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_usuario_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(267, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 31);
            this.panel2.TabIndex = 7;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_contraseña.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_contraseña.Location = new System.Drawing.Point(243, 102);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(169, 21);
            this.txb_contraseña.TabIndex = 9;
            this.txb_contraseña.TextChanged += new System.EventHandler(this.txb_contraseña_TextChanged_1);
            this.txb_contraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_contraseña_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(240, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(437, 199);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

