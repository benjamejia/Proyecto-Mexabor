namespace App
{
    partial class FormHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Exportar1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.refrescar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnResdaldo = new System.Windows.Forms.Button();
            this.panelBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btn_calendario = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_auditor = new System.Windows.Forms.TextBox();
            this.txb_sucursal = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txb_Gerente = new System.Windows.Forms.TextBox();
            this.txb_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 53);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 643);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btn_Exportar1);
            this.panel4.Controls.Add(this.panel);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.btn_siguiente);
            this.panel4.Controls.Add(this.refrescar);
            this.panel4.Location = new System.Drawing.Point(284, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(921, 625);
            this.panel4.TabIndex = 77;
            // 
            // btn_Exportar1
            // 
            this.btn_Exportar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exportar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exportar1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exportar1.Location = new System.Drawing.Point(800, 559);
            this.btn_Exportar1.Name = "btn_Exportar1";
            this.btn_Exportar1.Size = new System.Drawing.Size(100, 25);
            this.btn_Exportar1.TabIndex = 77;
            this.btn_Exportar1.Text = "Exportar Tabla";
            this.btn_Exportar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exportar1.UseVisualStyleBackColor = true;
            this.btn_Exportar1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.dataGridView2);
            this.panel.Location = new System.Drawing.Point(12, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 186);
            this.panel.TabIndex = 76;
            this.panel.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(157, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 79;
            this.button2.Text = "Exportar Pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 78;
            this.button1.Text = "Exportar Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(764, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(815, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 35);
            this.button3.TabIndex = 76;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 55);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(885, 63);
            this.dataGridView2.TabIndex = 74;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(874, 533);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siguiente.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(817, 590);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(83, 29);
            this.btn_siguiente.TabIndex = 58;
            this.btn_siguiente.Text = "Volver";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // refrescar
            // 
            this.refrescar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refrescar.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrescar.Location = new System.Drawing.Point(391, 559);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(168, 46);
            this.refrescar.TabIndex = 72;
            this.refrescar.Text = "Refrescar";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnResdaldo);
            this.panel3.Controls.Add(this.panelBorrar);
            this.panel3.Controls.Add(this.btnBorrar);
            this.panel3.Controls.Add(this.btnAdmin);
            this.panel3.Controls.Add(this.btn_calendario);
            this.panel3.Controls.Add(this.calendario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txb_auditor);
            this.panel3.Controls.Add(this.txb_sucursal);
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.txb_Gerente);
            this.panel3.Controls.Add(this.txb_fecha);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 643);
            this.panel3.TabIndex = 76;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel5.Location = new System.Drawing.Point(37, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 54);
            this.panel5.TabIndex = 83;
            this.panel5.Visible = false;
            // 
            // btnResdaldo
            // 
            this.btnResdaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResdaldo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnResdaldo.FlatAppearance.BorderSize = 0;
            this.btnResdaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResdaldo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResdaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResdaldo.Location = new System.Drawing.Point(40, 469);
            this.btnResdaldo.Name = "btnResdaldo";
            this.btnResdaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResdaldo.Size = new System.Drawing.Size(171, 54);
            this.btnResdaldo.TabIndex = 82;
            this.btnResdaldo.Text = "Guardar Respaldo de la base de datos";
            this.btnResdaldo.UseVisualStyleBackColor = false;
            this.btnResdaldo.Visible = false;
            this.btnResdaldo.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panelBorrar
            // 
            this.panelBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorrar.BackColor = System.Drawing.Color.Maroon;
            this.panelBorrar.Location = new System.Drawing.Point(37, 541);
            this.panelBorrar.Name = "panelBorrar";
            this.panelBorrar.Size = new System.Drawing.Size(10, 32);
            this.panelBorrar.TabIndex = 81;
            this.panelBorrar.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(37, 541);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(174, 32);
            this.btnBorrar.TabIndex = 80;
            this.btnBorrar.Text = "Borrar Registros";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdmin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(37, 596);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(173, 32);
            this.btnAdmin.TabIndex = 79;
            this.btnAdmin.Text = "Opciones Avanzadas";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_calendario
            // 
            this.btn_calendario.Location = new System.Drawing.Point(242, 171);
            this.btn_calendario.Name = "btn_calendario";
            this.btn_calendario.Size = new System.Drawing.Size(14, 19);
            this.btn_calendario.TabIndex = 69;
            this.btn_calendario.Text = "X";
            this.btn_calendario.UseVisualStyleBackColor = true;
            this.btn_calendario.Visible = false;
            this.btn_calendario.Click += new System.EventHandler(this.Btn_calendario_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(18, 40);
            this.calendario.Name = "calendario";
            this.calendario.ShowTodayCircle = false;
            this.calendario.TabIndex = 68;
            this.calendario.TodayDate = new System.DateTime(2024, 7, 12, 0, 0, 0, 0);
            this.calendario.Visible = false;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Gerente";
            // 
            // txb_auditor
            // 
            this.txb_auditor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txb_auditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txb_auditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_auditor.Location = new System.Drawing.Point(8, 229);
            this.txb_auditor.Name = "txb_auditor";
            this.txb_auditor.Size = new System.Drawing.Size(235, 31);
            this.txb_auditor.TabIndex = 70;
            this.txb_auditor.Click += new System.EventHandler(this.Txb_auditor_Click);
            // 
            // txb_sucursal
            // 
            this.txb_sucursal.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sucursal.FormattingEnabled = true;
            this.txb_sucursal.Items.AddRange(new object[] {
            "Patria",
            "Loma"});
            this.txb_sucursal.Location = new System.Drawing.Point(8, 96);
            this.txb_sucursal.Name = "txb_sucursal";
            this.txb_sucursal.Size = new System.Drawing.Size(235, 35);
            this.txb_sucursal.TabIndex = 73;
            this.txb_sucursal.Click += new System.EventHandler(this.Txb_sucursal_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(8, 282);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(235, 49);
            this.btn_buscar.TabIndex = 59;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txb_Gerente
            // 
            this.txb_Gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Gerente.Location = new System.Drawing.Point(8, 34);
            this.txb_Gerente.Name = "txb_Gerente";
            this.txb_Gerente.Size = new System.Drawing.Size(235, 31);
            this.txb_Gerente.TabIndex = 60;
            this.txb_Gerente.Click += new System.EventHandler(this.Txb_Gerente_Click);
            // 
            // txb_fecha
            // 
            this.txb_fecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txb_fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_fecha.Location = new System.Drawing.Point(8, 159);
            this.txb_fecha.Name = "txb_fecha";
            this.txb_fecha.Size = new System.Drawing.Size(235, 31);
            this.txb_fecha.TabIndex = 62;
            this.txb_fecha.Click += new System.EventHandler(this.Txb_fecha_Click);
            this.txb_fecha.TextChanged += new System.EventHandler(this.Txb_fecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Auditor";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistorial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHistorial_FormClosed);
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            this.Click += new System.EventHandler(this.FormHistorial_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_fecha;
        private System.Windows.Forms.TextBox txb_Gerente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btn_calendario;
        private System.Windows.Forms.TextBox txb_auditor;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.ComboBox txb_sucursal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_Exportar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelBorrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnResdaldo;
    }
}