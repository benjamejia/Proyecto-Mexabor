namespace Mexabor.Almacen
{
    partial class RevisionInventario
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
            panel2 = new Panel();
            label4 = new Label();
            txbEmpacados = new TextBox();
            txbProducto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtObservacion = new RichTextBox();
            label20 = new Label();
            label18 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 61);
            panel2.TabIndex = 256;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(414, 31);
            label4.TabIndex = 0;
            label4.Text = "Revision de Productos del Inventario";
            // 
            // txbEmpacados
            // 
            txbEmpacados.BackColor = Color.Gainsboro;
            txbEmpacados.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEmpacados.Location = new Point(12, 174);
            txbEmpacados.Margin = new Padding(3, 2, 3, 2);
            txbEmpacados.Name = "txbEmpacados";
            txbEmpacados.Size = new Size(276, 33);
            txbEmpacados.TabIndex = 260;
            // 
            // txbProducto
            // 
            txbProducto.BackColor = Color.Gainsboro;
            txbProducto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProducto.Location = new Point(12, 101);
            txbProducto.Margin = new Padding(3, 2, 3, 2);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(276, 33);
            txbProducto.TabIndex = 259;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 258;
            label2.Text = "Productos empacados correctamente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 257;
            label1.Text = "Productos que se revisaron";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtObservacion);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label18);
            panel1.Location = new Point(446, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 331);
            panel1.TabIndex = 261;
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacion.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacion.Location = new Point(17, 51);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(655, 244);
            txtObservacion.TabIndex = 250;
            txtObservacion.Text = "";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(17, 298);
            label20.Name = "label20";
            label20.Size = new Size(131, 15);
            label20.TabIndex = 249;
            label20.Text = "Maximo 500 caracteres.";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ButtonHighlight;
            label18.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(483, 12);
            label18.Name = "label18";
            label18.Size = new Size(189, 21);
            label18.TabIndex = 244;
            label18.Text = "Agregar Observaciones";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1003, 569);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 33);
            button1.TabIndex = 263;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 569);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(151, 33);
            button2.TabIndex = 262;
            button2.Text = "Anterior";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Font = new Font("Yu Gothic", 15.75F);
            panel3.Location = new Point(12, 569);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 33);
            panel3.TabIndex = 264;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Font = new Font("Yu Gothic", 15.75F);
            panel4.Location = new Point(1003, 569);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 33);
            panel4.TabIndex = 170;
            // 
            // RevisionInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1166, 613);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(txbEmpacados);
            Controls.Add(txbProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "RevisionInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RevisionInventario";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private TextBox txbEmpacados;
        private TextBox txbProducto;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label18;
        private RichTextBox txtObservacion;
        private Label label20;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
    }
}