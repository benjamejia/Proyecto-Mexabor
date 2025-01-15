namespace Mexabor
{
    partial class ExportacionFinal
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
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(56, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 43);
            panel3.TabIndex = 52;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.WhiteSmoke;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic", 12F);
            button3.Location = new Point(56, 173);
            button3.Name = "button3";
            button3.Size = new Size(234, 43);
            button3.TabIndex = 55;
            button3.Text = "Exportar Pdf";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(56, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 47);
            panel4.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(56, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 45);
            panel1.TabIndex = 56;
            // 
            // ExportacionFinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(352, 283);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExportacionFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportacionFinal";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Panel panel1;
    }
}