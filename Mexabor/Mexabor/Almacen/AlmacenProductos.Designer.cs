namespace Mexabor.Almacen
{
    partial class AlmacenProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmacenProductos));
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 626);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Location = new Point(613, 551);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 218;
            button3.Text = "actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 33);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 217;
            label1.Text = "Agregar Producto";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 216;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1359, 453);
            dataGridView1.TabIndex = 215;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Font = new Font("Yu Gothic", 18F);
            panel4.Location = new Point(33, 561);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 44);
            panel4.TabIndex = 214;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic", 18F);
            button2.Location = new Point(33, 561);
            button2.Name = "button2";
            button2.Size = new Size(173, 44);
            button2.TabIndex = 213;
            button2.Text = "Anterior";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Font = new Font("Yu Gothic", 18F);
            panel3.Location = new Point(1221, 561);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 44);
            panel3.TabIndex = 212;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 18F);
            button1.Location = new Point(1221, 561);
            button1.Name = "button1";
            button1.Size = new Size(173, 44);
            button1.TabIndex = 211;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AlmacenProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1424, 626);
            Controls.Add(panel1);
            Name = "AlmacenProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlmacenProductos";
            WindowState = FormWindowState.Maximized;
            Load += AlmacenProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button button2;
        private Panel panel3;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
    }
}