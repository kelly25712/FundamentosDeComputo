namespace Mapaches_Bigoton
{
    partial class Menu
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
            btnAgendar = new Button();
            btnCitas = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAgendar
            // 
            btnAgendar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAgendar.Location = new Point(96, 57);
            btnAgendar.Margin = new Padding(3, 2, 3, 2);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(110, 38);
            btnAgendar.TabIndex = 0;
            btnAgendar.Text = "Agendar Cita";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCitas
            // 
            btnCitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCitas.Location = new Point(96, 126);
            btnCitas.Margin = new Padding(3, 2, 3, 2);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(110, 37);
            btnCitas.TabIndex = 1;
            btnCitas.Text = "Tabla de citas";
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(346, 58);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSalir.Location = new Point(96, 190);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Cerrar Sesion";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.cerrar_sesion;
            pictureBox4.Location = new Point(24, 190);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.vision;
            pictureBox2.Location = new Point(24, 126);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.calendario;
            pictureBox3.Location = new Point(24, 58);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 223);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 51);
            textBox1.TabIndex = 9;
            textBox1.Text = "Teléfono: \r\nDirección:\r\nHorario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 30);
            label1.TabIndex = 10;
            label1.Text = "El Mapache Bigotón";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(545, 293);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnCitas);
            Controls.Add(btnAgendar);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgendar;
        private Button btnCitas;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private Label label1;
    }
}