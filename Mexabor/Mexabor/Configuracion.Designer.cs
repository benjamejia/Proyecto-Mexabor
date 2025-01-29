namespace Mexabor
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            panel1 = new Panel();
            imagenMexabor = new PictureBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            btnCedis = new Button();
            btnAjustesAvanzados = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(imagenMexabor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 84);
            panel1.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(12, 0);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(115, 87);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 3;
            imagenMexabor.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(366, 26);
            label1.TabIndex = 1;
            label1.Text = "Doble confirmacion al pasar de pagina";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(431, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnCedis
            // 
            btnCedis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCedis.BackColor = Color.WhiteSmoke;
            btnCedis.FlatAppearance.BorderSize = 0;
            btnCedis.FlatStyle = FlatStyle.Flat;
            btnCedis.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCedis.Location = new Point(12, 219);
            btnCedis.Name = "btnCedis";
            btnCedis.Size = new Size(122, 27);
            btnCedis.TabIndex = 8;
            btnCedis.Text = "Volver";
            btnCedis.UseVisualStyleBackColor = false;
            btnCedis.Click += btnCedis_Click;
            // 
            // btnAjustesAvanzados
            // 
            btnAjustesAvanzados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAjustesAvanzados.BackColor = Color.WhiteSmoke;
            btnAjustesAvanzados.FlatAppearance.BorderSize = 0;
            btnAjustesAvanzados.FlatStyle = FlatStyle.Flat;
            btnAjustesAvanzados.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustesAvanzados.Location = new Point(259, 219);
            btnAjustesAvanzados.Name = "btnAjustesAvanzados";
            btnAjustesAvanzados.Size = new Size(218, 27);
            btnAjustesAvanzados.TabIndex = 9;
            btnAjustesAvanzados.Text = "Ajustes Avanzados";
            btnAjustesAvanzados.UseVisualStyleBackColor = false;
            btnAjustesAvanzados.Click += btnAjustesAvanzados_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(489, 258);
            Controls.Add(btnAjustesAvanzados);
            Controls.Add(btnCedis);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Configuracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion";
            Load += Configuracion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imagenMexabor;
        private Label label1;
        private CheckBox checkBox1;
        private Button btnCedis;
        private Button btnAjustesAvanzados;
    }
}