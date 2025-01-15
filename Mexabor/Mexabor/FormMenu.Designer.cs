namespace Mexabor
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            btn_Auditoria = new Button();
            btnRegistros = new Button();
            lblCerrarSesion = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnRedtaurante = new Button();
            btnCedis = new Button();
            lblVolver = new LinkLabel();
            iconoAdmin = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconoAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Auditoria
            // 
            btn_Auditoria.BackColor = Color.WhiteSmoke;
            btn_Auditoria.FlatAppearance.BorderSize = 0;
            btn_Auditoria.FlatStyle = FlatStyle.Flat;
            btn_Auditoria.Font = new Font("Yu Gothic", 13.8F);
            btn_Auditoria.Location = new Point(128, 26);
            btn_Auditoria.Name = "btn_Auditoria";
            btn_Auditoria.Size = new Size(255, 41);
            btn_Auditoria.TabIndex = 2;
            btn_Auditoria.Text = "Iniciar Auditoria";
            btn_Auditoria.UseVisualStyleBackColor = false;
            btn_Auditoria.Click += btn_Auditoria_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.WhiteSmoke;
            btnRegistros.FlatAppearance.BorderSize = 0;
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Yu Gothic", 13.8F);
            btnRegistros.Location = new Point(128, 89);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(255, 41);
            btnRegistros.TabIndex = 3;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += button2_Click;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCerrarSesion.LinkColor = Color.FromArgb(64, 64, 64);
            lblCerrarSesion.Location = new Point(203, 153);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(100, 20);
            lblCerrarSesion.TabIndex = 4;
            lblCerrarSesion.TabStop = true;
            lblCerrarSesion.Text = "Cerrar Sesion";
            lblCerrarSesion.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(128, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(14, 41);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(128, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 41);
            panel2.TabIndex = 6;
            // 
            // btnRedtaurante
            // 
            btnRedtaurante.BackColor = Color.WhiteSmoke;
            btnRedtaurante.FlatAppearance.BorderSize = 0;
            btnRedtaurante.FlatStyle = FlatStyle.Flat;
            btnRedtaurante.Font = new Font("Yu Gothic", 13.8F);
            btnRedtaurante.Location = new Point(128, 27);
            btnRedtaurante.Name = "btnRedtaurante";
            btnRedtaurante.Size = new Size(255, 41);
            btnRedtaurante.TabIndex = 8;
            btnRedtaurante.Text = "Restaurante";
            btnRedtaurante.UseVisualStyleBackColor = false;
            btnRedtaurante.Visible = false;
            btnRedtaurante.Click += btnRedtaurante_Click;
            // 
            // btnCedis
            // 
            btnCedis.BackColor = Color.WhiteSmoke;
            btnCedis.FlatAppearance.BorderSize = 0;
            btnCedis.FlatStyle = FlatStyle.Flat;
            btnCedis.Font = new Font("Yu Gothic", 13.8F);
            btnCedis.Location = new Point(128, 89);
            btnCedis.Name = "btnCedis";
            btnCedis.Size = new Size(255, 41);
            btnCedis.TabIndex = 7;
            btnCedis.Text = "Cedis";
            btnCedis.UseVisualStyleBackColor = false;
            btnCedis.Visible = false;
            btnCedis.Click += btnCedis_Click;
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.LinkColor = Color.Gray;
            lblVolver.Location = new Point(231, 152);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(50, 20);
            lblVolver.TabIndex = 9;
            lblVolver.TabStop = true;
            lblVolver.Text = "Volver";
            lblVolver.Visible = false;
            lblVolver.LinkClicked += lblVolver_LinkClicked;
            // 
            // iconoAdmin
            // 
            iconoAdmin.Image = (Image)resources.GetObject("iconoAdmin.Image");
            iconoAdmin.Location = new Point(411, 65);
            iconoAdmin.Name = "iconoAdmin";
            iconoAdmin.Size = new Size(73, 47);
            iconoAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            iconoAdmin.TabIndex = 10;
            iconoAdmin.TabStop = false;
            iconoAdmin.Visible = false;
            iconoAdmin.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(496, 194);
            Controls.Add(pictureBox1);
            Controls.Add(iconoAdmin);
            Controls.Add(lblVolver);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnRedtaurante);
            Controls.Add(btnCedis);
            Controls.Add(lblCerrarSesion);
            Controls.Add(btnRegistros);
            Controls.Add(btn_Auditoria);
            Name = "FormMenu";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion";
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)iconoAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Auditoria;
        private Button btnRegistros;
        private LinkLabel lblCerrarSesion;
        private Panel panel1;
        private Panel panel2;
        private Button btnRedtaurante;
        private Button btnCedis;
        private LinkLabel lblVolver;
        private PictureBox iconoAdmin;
        private PictureBox pictureBox1;
    }
}