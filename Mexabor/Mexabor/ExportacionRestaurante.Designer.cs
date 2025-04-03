namespace Mexabor
{
    partial class ExportacionRestaurante
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
            button1 = new Button();
            button2 = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 12F);
            button1.Location = new Point(56, 41);
            button1.Name = "button1";
            button1.Size = new Size(234, 45);
            button1.TabIndex = 51;
            button1.Text = "Volver al Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 12F);
            button2.Location = new Point(56, 104);
            button2.Name = "button2";
            button2.Size = new Size(234, 47);
            button2.TabIndex = 53;
            button2.Text = "Exportar Excel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(56, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 47);
            panel4.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(56, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 45);
            panel1.TabIndex = 56;
            // 
            // ExportacionRestaurante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(352, 181);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExportacionRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportacion Restaurante";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Panel panel1;
    }
}