namespace Mapaches_Bigoton
{
    partial class AgendarCita
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
            panel1 = new Panel();
            txtFecha = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            button1 = new Button();
            cmbServicio = new ComboBox();
            cmbHora = new ComboBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegresar = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbServicio);
            panel1.Controls.Add(cmbHora);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            panel1.Location = new Point(182, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 318);
            panel1.TabIndex = 0;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(139, 162);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(110, 25);
            txtFecha.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(61, 162);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 11;
            label5.Text = "Fecha:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(389, 269);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 34);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(103, 269);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 34);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(139, 202);
            cmbServicio.Margin = new Padding(3, 2, 3, 2);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(122, 25);
            cmbServicio.TabIndex = 8;
            // 
            // cmbHora
            // 
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(139, 122);
            cmbHora.Margin = new Padding(3, 2, 3, 2);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(122, 25);
            cmbHora.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(139, 82);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 25);
            txtTelefono.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 25);
            txtNombre.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(313, 23);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(61, 204);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 3;
            label4.Text = "Servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(61, 122);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "Hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(59, 82);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(61, 46);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(41, 280);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 34);
            btnRegresar.TabIndex = 11;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.lovepik_long_hairdressing_png_image_401903843_wh1200;
            pictureBox1.Location = new Point(10, 92);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 23);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 13;
            label6.Text = "AGENDAR CITAS";
            // 
            // AgendarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(756, 338);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgendarCita";
            Text = "AgendarCita";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Button button1;
        private ComboBox cmbServicio;
        private ComboBox cmbHora;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Button btnRegresar;
        private PictureBox pictureBox1;
        private TextBox txtFecha;
        private Label label5;
        private Label label6;
    }
}