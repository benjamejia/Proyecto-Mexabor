namespace Mexabor.Almacen
{
    partial class Productos
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
            txbProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbFolio = new TextBox();
            txbCalidad = new TextBox();
            txbCantidad = new TextBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            btnSiguiente = new Button();
            panel1 = new Panel();
            button1 = new Button();
            rtbObservaciones = new RichTextBox();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txbProducto
            // 
            txbProducto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProducto.Location = new Point(35, 67);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(278, 40);
            txbProducto.TabIndex = 3;
            txbProducto.TextChanged += txbProducto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 121);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 4;
            label2.Text = "Folio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 195);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 5;
            label3.Text = "Empacado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 265);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 6;
            label4.Text = "Calidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 339);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 7;
            label5.Text = "Cantidad Ideal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 418);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 8;
            label6.Text = "Observaciones";
            // 
            // txbFolio
            // 
            txbFolio.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFolio.Location = new Point(35, 147);
            txbFolio.Name = "txbFolio";
            txbFolio.Size = new Size(278, 40);
            txbFolio.TabIndex = 9;
            txbFolio.TextChanged += txbFolio_TextChanged;
            // 
            // txbCalidad
            // 
            txbCalidad.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCalidad.Location = new Point(35, 291);
            txbCalidad.Name = "txbCalidad";
            txbCalidad.Size = new Size(278, 40);
            txbCalidad.TabIndex = 11;
            txbCalidad.TextChanged += txbCalidad_TextChanged;
            // 
            // txbCantidad
            // 
            txbCantidad.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCantidad.Location = new Point(35, 365);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(278, 40);
            txbCantidad.TabIndex = 12;
            txbCantidad.TextChanged += txbCantidad_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kg.", "Gr." });
            comboBox1.Location = new Point(329, 367);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(64, 38);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Kg.";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Font = new Font("Yu Gothic", 18F);
            panel3.Location = new Point(250, 541);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 31);
            panel3.TabIndex = 214;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSiguiente.BackColor = Color.WhiteSmoke;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(255, 541);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(138, 31);
            btnSiguiente.TabIndex = 213;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Font = new Font("Yu Gothic", 18F);
            panel1.Location = new Point(30, 541);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 31);
            panel1.TabIndex = 216;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(35, 541);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 215;
            button1.Text = "Anterior";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rtbObservaciones
            // 
            rtbObservaciones.Location = new Point(35, 453);
            rtbObservaciones.Name = "rtbObservaciones";
            rtbObservaciones.Size = new Size(358, 61);
            rtbObservaciones.TabIndex = 217;
            rtbObservaciones.Text = "";
            rtbObservaciones.TextChanged += rtbObservaciones_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(918, 453);
            dataGridView1.TabIndex = 218;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(255, 24);
            checkBox1.TabIndex = 219;
            checkBox1.Text = "Si/No(Checkeado/No Checkeado)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1396, 597);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(rtbObservaciones);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(btnSiguiente);
            Controls.Add(comboBox1);
            Controls.Add(txbCantidad);
            Controls.Add(txbCalidad);
            Controls.Add(txbFolio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbProducto);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbFolio;
        private TextBox txbCalidad;
        private TextBox txbCantidad;
        private ComboBox comboBox1;
        private Panel panel3;
        private Button btnSiguiente;
        private Panel panel1;
        private Button button1;
        private RichTextBox rtbObservaciones;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
    }
}