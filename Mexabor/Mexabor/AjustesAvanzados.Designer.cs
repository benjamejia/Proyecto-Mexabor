namespace Mexabor
{
    partial class AjustesAvanzados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustesAvanzados));
            panel2 = new Panel();
            label3 = new Label();
            cbCredenciales = new ComboBox();
            txtClave = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            imagenMexabor = new PictureBox();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbCredenciales);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 369);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 226);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 62;
            label3.Text = "Tipo de Usuario";
            // 
            // cbCredenciales
            // 
            cbCredenciales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCredenciales.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCredenciales.FormattingEnabled = true;
            cbCredenciales.Items.AddRange(new object[] { "administrador", "usuario" });
            cbCredenciales.Location = new Point(51, 251);
            cbCredenciales.Name = "cbCredenciales";
            cbCredenciales.Size = new Size(258, 29);
            cbCredenciales.TabIndex = 61;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(51, 189);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(258, 33);
            txtClave.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 166);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 59;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(51, 132);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 33);
            txtUsuario.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 109);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 57;
            label1.Text = "Usuario";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(62, 343);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 56;
            label4.Text = "Cancelar";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 304);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(228, 345);
            label5.Name = "label5";
            label5.Size = new Size(94, 13);
            label5.TabIndex = 54;
            label5.Text = "Guardar cambios";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 304);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(360, 106);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(imagenMexabor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 67);
            panel1.TabIndex = 2;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(0, 0);
            imagenMexabor.Margin = new Padding(3, 2, 3, 2);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(101, 65);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 3;
            imagenMexabor.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(173, 9);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(190, 30);
            label6.TabIndex = 63;
            label6.Text = "Para eliminar haga doble clic en el \r\nusuario que desea eliminar\r\n";
            // 
            // AjustesAvanzados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(366, 441);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjustesAvanzados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario";
            Load += AjustesAvanzados_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox imagenMexabor;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox txtUsuario;
        private Label label1;
        private Label label3;
        private ComboBox cbCredenciales;
        private TextBox txtClave;
        private Label label2;
        private Label label6;
    }
}