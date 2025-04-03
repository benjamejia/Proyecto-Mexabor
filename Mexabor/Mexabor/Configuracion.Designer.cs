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
            btnCedis = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
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
            panel1.Size = new Size(338, 84);
            panel1.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(11, 0);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(115, 87);
            imagenMexabor.SizeMode = PictureBoxSizeMode.Zoom;
            imagenMexabor.TabIndex = 3;
            imagenMexabor.TabStop = false;
            // 
            // btnCedis
            // 
            btnCedis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCedis.BackColor = Color.WhiteSmoke;
            btnCedis.FlatAppearance.BorderSize = 0;
            btnCedis.FlatStyle = FlatStyle.Flat;
            btnCedis.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCedis.Location = new Point(11, 284);
            btnCedis.Name = "btnCedis";
            btnCedis.Size = new Size(122, 36);
            btnCedis.TabIndex = 8;
            btnCedis.Text = "Volver";
            btnCedis.UseVisualStyleBackColor = false;
            btnCedis.Click += btnCedis_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 117);
            button1.Name = "button1";
            button1.Size = new Size(288, 35);
            button1.TabIndex = 10;
            button1.Text = "Agregar Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(11, 284);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 36);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(11, 117);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 36);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(11, 178);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 36);
            panel4.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(11, 178);
            button2.Name = "button2";
            button2.Size = new Size(288, 35);
            button2.TabIndex = 13;
            button2.Text = "Ponderaciones";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(338, 334);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(btnCedis);
            Controls.Add(panel1);
            Name = "Configuracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "-";
            FormClosing += Configuracion_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenMexabor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox imagenMexabor;
        private Button btnCedis;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
    }
}