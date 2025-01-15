namespace Mexabor
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            imagenMexabor = new PictureBox();
            btnIniciarSesion = new Button();
            txb_Usuario = new TextBox();
            txb_Clave = new TextBox();
            ususarioTexto = new Label();
            contraseñaTexto = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(imagenMexabor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 186);
            panel1.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(3, 34);
            imagenMexabor.Margin = new Padding(3, 2, 3, 2);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(281, 110);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 0;
            imagenMexabor.TabStop = false;
            imagenMexabor.Click += imagenMexabor_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.WhiteSmoke;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(374, 142);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(151, 25);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += button1_Click;
            // 
            // txb_Usuario
            // 
            txb_Usuario.BackColor = Color.LightGray;
            txb_Usuario.BorderStyle = BorderStyle.None;
            txb_Usuario.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Usuario.Location = new Point(333, 41);
            txb_Usuario.Margin = new Padding(3, 2, 3, 2);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(220, 26);
            txb_Usuario.TabIndex = 2;
            txb_Usuario.KeyDown += txb_Usuario_KeyDown;
            // 
            // txb_Clave
            // 
            txb_Clave.BackColor = Color.LightGray;
            txb_Clave.BorderStyle = BorderStyle.None;
            txb_Clave.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Clave.Location = new Point(333, 93);
            txb_Clave.Margin = new Padding(3, 2, 3, 2);
            txb_Clave.Name = "txb_Clave";
            txb_Clave.Size = new Size(220, 26);
            txb_Clave.TabIndex = 3;
            txb_Clave.TextChanged += txb_Clave_TextChanged;
            txb_Clave.KeyDown += txb_Clave_KeyDown;
            // 
            // ususarioTexto
            // 
            ususarioTexto.AutoSize = true;
            ususarioTexto.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ususarioTexto.Location = new Point(333, 22);
            ususarioTexto.Name = "ususarioTexto";
            ususarioTexto.Size = new Size(58, 18);
            ususarioTexto.TabIndex = 4;
            ususarioTexto.Text = "Usuario";
            // 
            // contraseñaTexto
            // 
            contraseñaTexto.AutoSize = true;
            contraseñaTexto.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaTexto.Location = new Point(333, 74);
            contraseñaTexto.Name = "contraseñaTexto";
            contraseñaTexto.Size = new Size(83, 18);
            contraseñaTexto.TabIndex = 5;
            contraseñaTexto.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(574, 186);
            Controls.Add(contraseñaTexto);
            Controls.Add(ususarioTexto);
            Controls.Add(txb_Clave);
            Controls.Add(txb_Usuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imagenMexabor;
        private Button btnIniciarSesion;
        private TextBox txb_Usuario;
        private TextBox txb_Clave;
        private Label ususarioTexto;
        private Label contraseñaTexto;
    }
}
