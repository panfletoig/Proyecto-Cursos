namespace ProyectoCursos.Alumno
{
	partial class Alumno_Main
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
            lblVisualizacionDeCursos = new Label();
            lblInformacionDeCurso = new Label();
            lblNoAsignado = new Label();
            lblBusquedaDeCursos = new Label();
            Cursos = new ListBox();
            maskedTextBox1 = new MaskedTextBox();
            noAsignados = new ListBox();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            BusquedaHecha = new ListBox();
            lblNombreCurso = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblVisualizacionDeCursos
            // 
            lblVisualizacionDeCursos.AutoSize = true;
            lblVisualizacionDeCursos.Location = new Point(12, 9);
            lblVisualizacionDeCursos.Name = "lblVisualizacionDeCursos";
            lblVisualizacionDeCursos.Size = new Size(130, 15);
            lblVisualizacionDeCursos.TabIndex = 0;
            lblVisualizacionDeCursos.Text = "Visualización de Cursos";
            // 
            // lblInformacionDeCurso
            // 
            lblInformacionDeCurso.AutoSize = true;
            lblInformacionDeCurso.Location = new Point(701, 9);
            lblInformacionDeCurso.Name = "lblInformacionDeCurso";
            lblInformacionDeCurso.Size = new Size(122, 15);
            lblInformacionDeCurso.TabIndex = 1;
            lblInformacionDeCurso.Text = "Información de Curso";
            // 
            // lblNoAsignado
            // 
            lblNoAsignado.AutoSize = true;
            lblNoAsignado.Location = new Point(12, 191);
            lblNoAsignado.Name = "lblNoAsignado";
            lblNoAsignado.Size = new Size(259, 15);
            lblNoAsignado.TabIndex = 2;
            lblNoAsignado.Text = "No Asignado / No ha llegado al límite de cursos";
            // 
            // lblBusquedaDeCursos
            // 
            lblBusquedaDeCursos.AutoSize = true;
            lblBusquedaDeCursos.Location = new Point(709, 166);
            lblBusquedaDeCursos.Name = "lblBusquedaDeCursos";
            lblBusquedaDeCursos.Size = new Size(114, 15);
            lblBusquedaDeCursos.TabIndex = 3;
            lblBusquedaDeCursos.Text = "Búsqueda de Cursos";
            // 
            // Cursos
            // 
            Cursos.FormattingEnabled = true;
            Cursos.ItemHeight = 15;
            Cursos.Location = new Point(12, 27);
            Cursos.Name = "Cursos";
            Cursos.Size = new Size(310, 154);
            Cursos.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(516, 57);
            maskedTextBox1.Mask = "descripcioncurso";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(307, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // noAsignados
            // 
            noAsignados.FormattingEnabled = true;
            noAsignados.ItemHeight = 15;
            noAsignados.Location = new Point(12, 219);
            noAsignados.Name = "noAsignados";
            noAsignados.Size = new Size(310, 109);
            noAsignados.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(642, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(748, 191);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // BusquedaHecha
            // 
            BusquedaHecha.FormattingEnabled = true;
            BusquedaHecha.ItemHeight = 15;
            BusquedaHecha.Location = new Point(516, 219);
            BusquedaHecha.Name = "BusquedaHecha";
            BusquedaHecha.Size = new Size(307, 124);
            BusquedaHecha.TabIndex = 10;
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Location = new Point(738, 39);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new Size(85, 15);
            lblNombreCurso.TabIndex = 11;
            lblNombreCurso.Text = "Nombre Curso";
            // 
            // button1
            // 
            button1.Location = new Point(328, 243);
            button1.Name = "button1";
            button1.Size = new Size(94, 59);
            button1.TabIndex = 12;
            button1.Text = "Asignar Curso Seleccionado";
            button1.UseVisualStyleBackColor = true;
            // 
            // Alumno_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 351);
            Controls.Add(button1);
            Controls.Add(lblNombreCurso);
            Controls.Add(BusquedaHecha);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(noAsignados);
            Controls.Add(maskedTextBox1);
            Controls.Add(Cursos);
            Controls.Add(lblBusquedaDeCursos);
            Controls.Add(lblNoAsignado);
            Controls.Add(lblInformacionDeCurso);
            Controls.Add(lblVisualizacionDeCursos);
            Name = "Alumno_Main";
            Text = "Alumno_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVisualizacionDeCursos;
        private Label lblInformacionDeCurso;
        private Label lblNoAsignado;
        private Label lblBusquedaDeCursos;
        private ListBox Cursos;
        private MaskedTextBox maskedTextBox1;
        private ListBox noAsignados;
        private TextBox textBox1;
        private Button btnBuscar;
        private ListBox BusquedaHecha;
        private Label lblNombreCurso;
        private Button button1;
    }
}