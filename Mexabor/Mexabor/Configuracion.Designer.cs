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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 63);
            panel1.TabIndex = 0;
            // 
            // imagenMexabor
            // 
            imagenMexabor.Image = (Image)resources.GetObject("imagenMexabor.Image");
            imagenMexabor.Location = new Point(10, 0);
            imagenMexabor.Margin = new Padding(3, 2, 3, 2);
            imagenMexabor.Name = "imagenMexabor";
            imagenMexabor.Size = new Size(101, 65);
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
            btnCedis.Location = new Point(10, 145);
            btnCedis.Margin = new Padding(3, 2, 3, 2);
            btnCedis.Name = "btnCedis";
            btnCedis.Size = new Size(107, 27);
            btnCedis.TabIndex = 8;
            btnCedis.Text = "Volver";
            btnCedis.UseVisualStyleBackColor = false;
            btnCedis.Click += btnCedis_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(10, 88);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(252, 26);
            button1.TabIndex = 10;
            button1.Text = "Agregar Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(10, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 27);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(10, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 27);
            panel3.TabIndex = 12;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(296, 182);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(btnCedis);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Configuracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "-";
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
    }
}