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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            label1 = new Label();
            txbProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbFolio = new TextBox();
            txbCantidad = new TextBox();
            comboBox1 = new ComboBox();
            rtbObservaciones = new RichTextBox();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            cbxCalidad = new ComboBox();
            btnRefrescar = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txbProducto
            // 
            txbProducto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProducto.Location = new Point(31, 50);
            txbProducto.Margin = new Padding(3, 2, 3, 2);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(244, 33);
            txbProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 91);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Folio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 146);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Empacado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 199);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Calidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 254);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 7;
            label5.Text = "Cantidad Ideal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 314);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 8;
            label6.Text = "Observaciones";
            // 
            // txbFolio
            // 
            txbFolio.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFolio.Location = new Point(31, 110);
            txbFolio.Margin = new Padding(3, 2, 3, 2);
            txbFolio.Name = "txbFolio";
            txbFolio.Size = new Size(244, 33);
            txbFolio.TabIndex = 9;
            // 
            // txbCantidad
            // 
            txbCantidad.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbCantidad.Location = new Point(31, 274);
            txbCantidad.Margin = new Padding(3, 2, 3, 2);
            txbCantidad.Name = "txbCantidad";
            txbCantidad.Size = new Size(244, 33);
            txbCantidad.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kg.", "Gr." });
            comboBox1.Location = new Point(288, 275);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(56, 31);
            comboBox1.TabIndex = 14;
            // 
            // rtbObservaciones
            // 
            rtbObservaciones.Location = new Point(31, 340);
            rtbObservaciones.Margin = new Padding(3, 2, 3, 2);
            rtbObservaciones.Name = "rtbObservaciones";
            rtbObservaciones.Size = new Size(314, 47);
            rtbObservaciones.TabIndex = 217;
            rtbObservaciones.Text = "";
            rtbObservaciones.TextChanged += rtbObservaciones_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 54);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 333);
            dataGridView1.TabIndex = 218;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(36, 170);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(206, 19);
            checkBox1.TabIndex = 219;
            checkBox1.Text = "Si/No(Checkeado/No Checkeado)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(178, 404);
            label7.Name = "label7";
            label7.Size = new Size(97, 26);
            label7.TabIndex = 221;
            label7.Text = "Guardar cambios \r\nen el producto";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 391);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 220;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(449, 20);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 223;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 222;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(450, 14);
            button1.Name = "button1";
            button1.Size = new Size(157, 31);
            button1.TabIndex = 224;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // cbxCalidad
            // 
            cbxCalidad.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCalidad.FormattingEnabled = true;
            cbxCalidad.Items.AddRange(new object[] { "Bueno", "Malo" });
            cbxCalidad.Location = new Point(31, 221);
            cbxCalidad.Margin = new Padding(3, 2, 3, 2);
            cbxCalidad.Name = "cbxCalidad";
            cbxCalidad.Size = new Size(244, 31);
            cbxCalidad.TabIndex = 225;
            cbxCalidad.SelectedIndexChanged += cbxCalidad_SelectedIndexChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Bottom;
            btnRefrescar.BackColor = SystemColors.ButtonFace;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(724, 392);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(157, 31);
            btnRefrescar.TabIndex = 226;
            btnRefrescar.Text = "Refrescar ";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(926, 37);
            label9.Name = "label9";
            label9.Size = new Size(279, 15);
            label9.TabIndex = 227;
            label9.Text = "Haga doble click para editar o eliminar un producto";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1222, 455);
            Controls.Add(label9);
            Controls.Add(btnRefrescar);
            Controls.Add(cbxCalidad);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(rtbObservaciones);
            Controls.Add(comboBox1);
            Controls.Add(txbCantidad);
            Controls.Add(txbFolio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbProducto);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox txbCantidad;
        private ComboBox comboBox1;
        private RichTextBox rtbObservaciones;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private Button button1;
        private ComboBox cbxCalidad;
        private Button btnRefrescar;
        private Label label9;
    }
}