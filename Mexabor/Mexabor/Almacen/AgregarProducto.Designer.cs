namespace Mexabor.Almacen
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            panel1 = new Panel();
            imagenMexabor = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtCantidad = new TextBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(imagenMexabor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 93);
            panel1.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(12, 3);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(115, 87);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 2;
            imagenMexabor.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(208, 26);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Producto";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(12, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 40);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 206);
            label3.Name = "label3";
            label3.Size = new Size(147, 26);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Ideal";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 300);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(12, 352);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 9;
            label4.Text = "Cancelar";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(193, 355);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 10;
            label5.Text = "Guardar cambios";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(13, 235);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(147, 40);
            txtCantidad.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kg.", "Gr." });
            comboBox1.Location = new Point(176, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(64, 38);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Kg.";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(302, 385);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            Load += AgregarProducto_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imagenMexabor;
        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox comboBox1;
    }
}