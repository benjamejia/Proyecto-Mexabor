namespace Mexabor
{
    partial class FormRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistros));
            panel1 = new Panel();
            sucursalFecha = new Label();
            txbSucursal = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            fechaTetxto = new Label();
            txbFecha = new TextBox();
            label1 = new Label();
            lblAuditor = new Label();
            gerenteTexto = new Label();
            txbAuditor = new TextBox();
            txbGerente = new TextBox();
            panel2 = new Panel();
            panelDobleClick = new Panel();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            btnDobleClick = new Button();
            btnExportarExcel = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            imagenMexabor = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelDobleClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(sucursalFecha);
            panel1.Controls.Add(txbSucursal);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(fechaTetxto);
            panel1.Controls.Add(txbFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAuditor);
            panel1.Controls.Add(gerenteTexto);
            panel1.Controls.Add(txbAuditor);
            panel1.Controls.Add(txbGerente);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 48);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 613);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // sucursalFecha
            // 
            sucursalFecha.AutoSize = true;
            sucursalFecha.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sucursalFecha.Location = new Point(54, 33);
            sucursalFecha.Name = "sucursalFecha";
            sucursalFecha.Size = new Size(89, 25);
            sucursalFecha.TabIndex = 19;
            sucursalFecha.Text = "Sucursal";
            // 
            // txbSucursal
            // 
            txbSucursal.BackColor = Color.Gainsboro;
            txbSucursal.BorderStyle = BorderStyle.None;
            txbSucursal.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSucursal.Location = new Point(54, 57);
            txbSucursal.Margin = new Padding(3, 2, 3, 2);
            txbSucursal.Name = "txbSucursal";
            txbSucursal.Size = new Size(276, 30);
            txbSucursal.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(54, 315);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 37);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(35, 512);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 31);
            panel3.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(54, 315);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(276, 37);
            button3.TabIndex = 16;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(35, 512);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(276, 31);
            button2.TabIndex = 15;
            button2.Text = "Ajustes Avanzados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // fechaTetxto
            // 
            fechaTetxto.AutoSize = true;
            fechaTetxto.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaTetxto.Location = new Point(54, 223);
            fechaTetxto.Name = "fechaTetxto";
            fechaTetxto.Size = new Size(66, 25);
            fechaTetxto.TabIndex = 14;
            fechaTetxto.Text = "Fecha";
            // 
            // txbFecha
            // 
            txbFecha.BackColor = Color.Gainsboro;
            txbFecha.BorderStyle = BorderStyle.None;
            txbFecha.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFecha.Location = new Point(54, 248);
            txbFecha.Margin = new Padding(3, 2, 3, 2);
            txbFecha.Name = "txbFecha";
            txbFecha.Size = new Size(276, 30);
            txbFecha.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(220, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 11;
            label1.Text = "Filtrar por dato";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAuditor
            // 
            lblAuditor.AutoSize = true;
            lblAuditor.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuditor.Location = new Point(54, 158);
            lblAuditor.Name = "lblAuditor";
            lblAuditor.Size = new Size(76, 25);
            lblAuditor.TabIndex = 10;
            lblAuditor.Text = "Auditor";
            // 
            // gerenteTexto
            // 
            gerenteTexto.AutoSize = true;
            gerenteTexto.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gerenteTexto.Location = new Point(54, 96);
            gerenteTexto.Name = "gerenteTexto";
            gerenteTexto.Size = new Size(84, 25);
            gerenteTexto.TabIndex = 9;
            gerenteTexto.Text = "Gerente";
            // 
            // txbAuditor
            // 
            txbAuditor.BackColor = Color.Gainsboro;
            txbAuditor.BorderStyle = BorderStyle.None;
            txbAuditor.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAuditor.Location = new Point(54, 185);
            txbAuditor.Margin = new Padding(3, 2, 3, 2);
            txbAuditor.Name = "txbAuditor";
            txbAuditor.Size = new Size(276, 30);
            txbAuditor.TabIndex = 8;
            // 
            // txbGerente
            // 
            txbGerente.BackColor = Color.Gainsboro;
            txbGerente.BorderStyle = BorderStyle.None;
            txbGerente.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbGerente.Location = new Point(54, 121);
            txbGerente.Margin = new Padding(3, 2, 3, 2);
            txbGerente.Name = "txbGerente";
            txbGerente.Size = new Size(276, 30);
            txbGerente.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panelDobleClick);
            panel2.Controls.Add(btnExportarExcel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(362, 48);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 613);
            panel2.TabIndex = 1;
            // 
            // panelDobleClick
            // 
            panelDobleClick.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelDobleClick.BorderStyle = BorderStyle.FixedSingle;
            panelDobleClick.Controls.Add(button4);
            panelDobleClick.Controls.Add(dataGridView2);
            panelDobleClick.Controls.Add(btnDobleClick);
            panelDobleClick.Location = new Point(24, 183);
            panelDobleClick.Name = "panelDobleClick";
            panelDobleClick.Size = new Size(866, 153);
            panelDobleClick.TabIndex = 135;
            panelDobleClick.Visible = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Gainsboro;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(732, 5);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(106, 25);
            button4.TabIndex = 135;
            button4.Text = "Cerrar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.SlateGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(811, 67);
            dataGridView2.TabIndex = 0;
            // 
            // btnDobleClick
            // 
            btnDobleClick.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDobleClick.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDobleClick.Location = new Point(27, 114);
            btnDobleClick.Name = "btnDobleClick";
            btnDobleClick.Size = new Size(140, 23);
            btnDobleClick.TabIndex = 134;
            btnDobleClick.Text = "Exportar Datos Excel";
            btnDobleClick.UseVisualStyleBackColor = true;
            btnDobleClick.Click += button4_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportarExcel.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarExcel.Location = new Point(51, 541);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(140, 23);
            btnExportarExcel.TabIndex = 133;
            btnExportarExcel.Text = "Exportar Datos Excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(592, 14);
            label2.Name = "label2";
            label2.Size = new Size(268, 18);
            label2.TabIndex = 131;
            label2.Text = "Seleccione La tabla que desea mostrar..";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 25);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 132;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Reporte de Restaurante", "Reporte de Almacen", "Productos de Almacen" });
            comboBox1.Location = new Point(617, 32);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 26);
            comboBox1.TabIndex = 130;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Gainsboro;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(734, 572);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(130, 31);
            button5.TabIndex = 129;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 63);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 473);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(334, 572);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(276, 31);
            button1.TabIndex = 6;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1264, 661);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(imagenMexabor);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1264, 48);
            panel6.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(2, 2);
            imagenMexabor.Margin = new Padding(3, 2, 3, 2);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(166, 43);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 2;
            imagenMexabor.TabStop = false;
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 661);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1260, 653);
            Name = "FormRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            WindowState = FormWindowState.Maximized;
            Load += FormRegistros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelDobleClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblAuditor;
        private Label gerenteTexto;
        private TextBox txbAuditor;
        private TextBox txbGerente;
        private Button button1;
        private Label fechaTetxto;
        private TextBox txbFecha;
        private Label label1;
        private Button button3;
        private Button button2;
        private Panel panel4;
        private Panel panel3;
        private Label sucursalFecha;
        private TextBox txbSucursal;
        private Button button5;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dataGridView1;
        private PictureBox imagenMexabor;
        private Label label2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button btnExportarExcel;
        private Button btnDobleClick;
        private Panel panelDobleClick;
        private DataGridView dataGridView2;
        private Button button4;
    }
}