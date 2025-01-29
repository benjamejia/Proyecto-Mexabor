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
            btnBuscar = new Button();
            fechaTetxto = new Label();
            txbFecha = new TextBox();
            label1 = new Label();
            lblAuditor = new Label();
            gerenteTexto = new Label();
            txbAuditor = new TextBox();
            txbGerente = new TextBox();
            panel2 = new Panel();
            panelDobleClick = new Panel();
            button6 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            btnDobleClick = new Button();
            btnExportarExcel = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            btnCerrar = new Button();
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
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(fechaTetxto);
            panel1.Controls.Add(txbFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAuditor);
            panel1.Controls.Add(gerenteTexto);
            panel1.Controls.Add(txbAuditor);
            panel1.Controls.Add(txbGerente);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 818);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // sucursalFecha
            // 
            sucursalFecha.AutoSize = true;
            sucursalFecha.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sucursalFecha.Location = new Point(62, 44);
            sucursalFecha.Name = "sucursalFecha";
            sucursalFecha.Size = new Size(104, 30);
            sucursalFecha.TabIndex = 19;
            sucursalFecha.Text = "Sucursal";
            // 
            // txbSucursal
            // 
            txbSucursal.BackColor = Color.Gainsboro;
            txbSucursal.BorderStyle = BorderStyle.None;
            txbSucursal.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSucursal.Location = new Point(62, 76);
            txbSucursal.Name = "txbSucursal";
            txbSucursal.Size = new Size(315, 37);
            txbSucursal.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(62, 420);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 49);
            panel4.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Gainsboro;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Yu Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(62, 420);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(315, 49);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button3_Click;
            // 
            // fechaTetxto
            // 
            fechaTetxto.AutoSize = true;
            fechaTetxto.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaTetxto.Location = new Point(62, 297);
            fechaTetxto.Name = "fechaTetxto";
            fechaTetxto.Size = new Size(77, 30);
            fechaTetxto.TabIndex = 14;
            fechaTetxto.Text = "Fecha";
            // 
            // txbFecha
            // 
            txbFecha.BackColor = Color.Gainsboro;
            txbFecha.BorderStyle = BorderStyle.None;
            txbFecha.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFecha.Location = new Point(62, 331);
            txbFecha.Name = "txbFecha";
            txbFecha.Size = new Size(315, 37);
            txbFecha.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(251, 40);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 11;
            label1.Text = "Filtrar por dato";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAuditor
            // 
            lblAuditor.AutoSize = true;
            lblAuditor.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuditor.Location = new Point(62, 211);
            lblAuditor.Name = "lblAuditor";
            lblAuditor.Size = new Size(89, 30);
            lblAuditor.TabIndex = 10;
            lblAuditor.Text = "Auditor";
            // 
            // gerenteTexto
            // 
            gerenteTexto.AutoSize = true;
            gerenteTexto.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gerenteTexto.Location = new Point(62, 128);
            gerenteTexto.Name = "gerenteTexto";
            gerenteTexto.Size = new Size(98, 30);
            gerenteTexto.TabIndex = 9;
            gerenteTexto.Text = "Gerente";
            // 
            // txbAuditor
            // 
            txbAuditor.BackColor = Color.Gainsboro;
            txbAuditor.BorderStyle = BorderStyle.None;
            txbAuditor.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbAuditor.Location = new Point(62, 247);
            txbAuditor.Name = "txbAuditor";
            txbAuditor.Size = new Size(315, 37);
            txbAuditor.TabIndex = 8;
            // 
            // txbGerente
            // 
            txbGerente.BackColor = Color.Gainsboro;
            txbGerente.BorderStyle = BorderStyle.None;
            txbGerente.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbGerente.Location = new Point(62, 161);
            txbGerente.Name = "txbGerente";
            txbGerente.Size = new Size(315, 37);
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
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(413, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 818);
            panel2.TabIndex = 1;
            // 
            // panelDobleClick
            // 
            panelDobleClick.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelDobleClick.BorderStyle = BorderStyle.FixedSingle;
            panelDobleClick.Controls.Add(button6);
            panelDobleClick.Controls.Add(button4);
            panelDobleClick.Controls.Add(dataGridView2);
            panelDobleClick.Controls.Add(btnDobleClick);
            panelDobleClick.Location = new Point(27, 245);
            panelDobleClick.Margin = new Padding(3, 4, 3, 4);
            panelDobleClick.Name = "panelDobleClick";
            panelDobleClick.Size = new Size(990, 203);
            panelDobleClick.TabIndex = 135;
            panelDobleClick.Visible = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(198, 152);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(200, 31);
            button6.TabIndex = 136;
            button6.Text = "Exportar Datos Desglozados";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Gainsboro;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(838, 7);
            button4.Name = "button4";
            button4.Size = new Size(121, 33);
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
            dataGridView2.Location = new Point(31, 55);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(928, 89);
            dataGridView2.TabIndex = 0;
            // 
            // btnDobleClick
            // 
            btnDobleClick.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDobleClick.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDobleClick.Location = new Point(31, 152);
            btnDobleClick.Margin = new Padding(3, 4, 3, 4);
            btnDobleClick.Name = "btnDobleClick";
            btnDobleClick.Size = new Size(160, 31);
            btnDobleClick.TabIndex = 134;
            btnDobleClick.Text = "Exportar Datos Excel";
            btnDobleClick.UseVisualStyleBackColor = true;
            btnDobleClick.Click += button4_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportarExcel.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarExcel.Location = new Point(58, 722);
            btnExportarExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(160, 31);
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
            label2.Location = new Point(678, 19);
            label2.Name = "label2";
            label2.Size = new Size(319, 22);
            label2.TabIndex = 131;
            label2.Text = "Seleccione La tabla que desea mostrar..";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(647, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 45);
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
            comboBox1.Location = new Point(706, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 31);
            comboBox1.TabIndex = 130;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Gainsboro;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(840, 764);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(149, 41);
            btnCerrar.TabIndex = 129;
            btnCerrar.Text = "Volver";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(930, 632);
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
            button1.Location = new Point(383, 764);
            button1.Name = "button1";
            button1.Size = new Size(315, 41);
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
            panel5.Name = "panel5";
            panel5.Size = new Size(1445, 881);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(imagenMexabor);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1445, 63);
            panel6.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(2, 3);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(190, 57);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 2;
            imagenMexabor.TabStop = false;
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 881);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1437, 855);
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
        private Button btnBuscar;
        private Panel panel4;
        private Label sucursalFecha;
        private TextBox txbSucursal;
        private Button btnCerrar;
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
        private Button button6;
    }
}