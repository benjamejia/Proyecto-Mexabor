namespace Mexabor.Almacen
{
    partial class RevisionProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label20 = new Label();
            txtObservacion = new RichTextBox();
            label18 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txbProducto = new TextBox();
            txbEmpacados = new TextBox();
            txbCalidad = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 90);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 226;
            label1.Text = "Productos que se revisaron";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 163);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 239;
            label2.Text = "Productos empacados correctamente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 241);
            label3.Name = "label3";
            label3.Size = new Size(239, 20);
            label3.TabIndex = 241;
            label3.Text = "Productos que con buena calidad";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(16, 187);
            label20.Name = "label20";
            label20.Size = new Size(75, 15);
            label20.TabIndex = 248;
            label20.Text = "Maximo 200.";
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacion.Location = new Point(16, 43);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(657, 141);
            txtObservacion.TabIndex = 246;
            txtObservacion.Text = "Sin obersevaciones.";
            txtObservacion.TextChanged += txtObservacion_TextChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ButtonHighlight;
            label18.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(484, 9);
            label18.Name = "label18";
            label18.Size = new Size(189, 21);
            label18.TabIndex = 243;
            label18.Text = "Agregar Observaciones";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(txtObservacion);
            panel1.Location = new Point(383, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 227);
            panel1.TabIndex = 249;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 331);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(151, 33);
            button2.TabIndex = 250;
            button2.Text = "Anterior";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(917, 331);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 33);
            button1.TabIndex = 251;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txbProducto
            // 
            txbProducto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProducto.Location = new Point(22, 112);
            txbProducto.Margin = new Padding(3, 2, 3, 2);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(276, 33);
            txbProducto.TabIndex = 252;
            // 
            // txbEmpacados
            // 
            txbEmpacados.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEmpacados.Location = new Point(22, 185);
            txbEmpacados.Margin = new Padding(3, 2, 3, 2);
            txbEmpacados.Name = "txbEmpacados";
            txbEmpacados.Size = new Size(276, 33);
            txbEmpacados.TabIndex = 253;
            // 
            // txbCalidad
            // 
            txbCalidad.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCalidad.Location = new Point(22, 261);
            txbCalidad.Margin = new Padding(3, 2, 3, 2);
            txbCalidad.Name = "txbCalidad";
            txbCalidad.Size = new Size(276, 33);
            txbCalidad.TabIndex = 254;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 61);
            panel2.TabIndex = 255;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(400, 31);
            label4.TabIndex = 0;
            label4.Text = "Revision de Productos del Almacen";
            // 
            // RevisionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1080, 375);
            Controls.Add(panel2);
            Controls.Add(txbCalidad);
            Controls.Add(txbEmpacados);
            Controls.Add(txbProducto);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1096, 414);
            Name = "RevisionProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revision de Productos";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label20;
        private RichTextBox txtObservacion;
        private Label label18;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox txbProducto;
        private TextBox txbEmpacados;
        private TextBox txbCalidad;
        private Panel panel2;
        private Label label4;
    }
}