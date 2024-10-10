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
            lblBusquedaDeCursos.Location = new Point(701, 191);
            lblBusquedaDeCursos.Name = "lblBusquedaDeCursos";
            lblBusquedaDeCursos.Size = new Size(114, 15);
            lblBusquedaDeCursos.TabIndex = 3;
            lblBusquedaDeCursos.Text = "Búsqueda de Cursos";
            // 
            // Alumno_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 351);
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
    }
}