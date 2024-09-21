namespace Mapaches_Bigoton
{
    partial class Citas
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
            btnRegresar = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnCerrar = new Button();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(45, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Numero, Hora, Fecha, Servicio, Costo });
            dataGridView1.Location = new Point(72, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 316);
            dataGridView1.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombres";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Numero
            // 
            Numero.HeaderText = "Numeros";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.Width = 125;
            // 
            // Hora
            // 
            Hora.HeaderText = "Horas";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            Hora.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fechas";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicios";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.Width = 125;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costos";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 20);
            label1.TabIndex = 2;
            label1.Text = "AGENDA DE CITAS EL MAPACHE BIGOTON";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(545, 409);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(252, 409);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar datos";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargar);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRegresar);
            Name = "Citas";
            Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Costo;
        private Label label1;
        private Button btnCerrar;
        private Button btnCargar;
    }
}