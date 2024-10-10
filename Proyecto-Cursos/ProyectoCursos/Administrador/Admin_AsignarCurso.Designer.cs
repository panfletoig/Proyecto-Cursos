namespace ProyectoCursos.Administrador
{
	partial class Admin_AsignarCurso
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
			label_crearUsuario = new Label();
			panel_Container = new Panel();
			panel5 = new Panel();
			panel1 = new Panel();
			btn_Asignar = new Button();
			label_docentes = new Label();
			label_cursos = new Label();
			panel2 = new Panel();
			label_showName = new Label();
			label_user = new Label();
			cB_cursos = new ComboBox();
			cB_docentes = new ComboBox();
			panel_Container.SuspendLayout();
			panel5.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label_crearUsuario
			// 
			label_crearUsuario.Dock = DockStyle.Top;
			label_crearUsuario.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_crearUsuario.Location = new Point(0, 0);
			label_crearUsuario.Name = "label_crearUsuario";
			label_crearUsuario.Size = new Size(800, 71);
			label_crearUsuario.TabIndex = 2;
			label_crearUsuario.Text = "Asignar Curso";
			label_crearUsuario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel_Container
			// 
			panel_Container.Controls.Add(panel5);
			panel_Container.Controls.Add(panel2);
			panel_Container.Dock = DockStyle.Bottom;
			panel_Container.Location = new Point(0, 89);
			panel_Container.Name = "panel_Container";
			panel_Container.Size = new Size(800, 311);
			panel_Container.TabIndex = 6;
			// 
			// panel5
			// 
			panel5.Controls.Add(panel1);
			panel5.Dock = DockStyle.Left;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(302, 311);
			panel5.TabIndex = 8;
			// 
			// panel1
			// 
			panel1.Controls.Add(cB_docentes);
			panel1.Controls.Add(cB_cursos);
			panel1.Controls.Add(btn_Asignar);
			panel1.Controls.Add(label_docentes);
			panel1.Controls.Add(label_cursos);
			panel1.Location = new Point(12, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(284, 296);
			panel1.TabIndex = 2;
			// 
			// btn_Asignar
			// 
			btn_Asignar.Location = new Point(181, 270);
			btn_Asignar.Name = "btn_Asignar";
			btn_Asignar.Size = new Size(100, 23);
			btn_Asignar.TabIndex = 3;
			btn_Asignar.Text = "Asignar curso";
			btn_Asignar.UseVisualStyleBackColor = true;
			// 
			// label_docentes
			// 
			label_docentes.AutoSize = true;
			label_docentes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_docentes.Location = new Point(3, 70);
			label_docentes.Name = "label_docentes";
			label_docentes.Size = new Size(144, 17);
			label_docentes.TabIndex = 3;
			label_docentes.Text = "Docentes disponibles:";
			// 
			// label_cursos
			// 
			label_cursos.AutoSize = true;
			label_cursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_cursos.Location = new Point(3, 10);
			label_cursos.Name = "label_cursos";
			label_cursos.Size = new Size(139, 17);
			label_cursos.TabIndex = 1;
			label_cursos.Text = "Cursos no asignados:";
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(label_showName);
			panel2.Controls.Add(label_user);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(523, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(277, 311);
			panel2.TabIndex = 3;
			// 
			// label_showName
			// 
			label_showName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label_showName.Location = new Point(3, 28);
			label_showName.Name = "label_showName";
			label_showName.RightToLeft = RightToLeft.No;
			label_showName.Size = new Size(271, 17);
			label_showName.TabIndex = 4;
			label_showName.Text = "La asignación se mostrara aqui";
			// 
			// label_user
			// 
			label_user.AutoSize = true;
			label_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_user.Location = new Point(3, 10);
			label_user.Name = "label_user";
			label_user.Size = new Size(80, 17);
			label_user.TabIndex = 2;
			label_user.Text = "Asignacion:";
			// 
			// cB_cursos
			// 
			cB_cursos.FormattingEnabled = true;
			cB_cursos.Location = new Point(3, 28);
			cB_cursos.Name = "cB_cursos";
			cB_cursos.Size = new Size(278, 23);
			cB_cursos.TabIndex = 9;
			// 
			// cB_docentes
			// 
			cB_docentes.FormattingEnabled = true;
			cB_docentes.Location = new Point(3, 90);
			cB_docentes.Name = "cB_docentes";
			cB_docentes.Size = new Size(278, 23);
			cB_docentes.TabIndex = 10;
			// 
			// Admin_AsignarCurso
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 400);
			Controls.Add(panel_Container);
			Controls.Add(label_crearUsuario);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Admin_AsignarCurso";
			Text = "Admin_AsignarCurso";
			Load += Admin_AsignarCurso_Load;
			panel_Container.ResumeLayout(false);
			panel_Container.PerformLayout();
			panel5.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label_crearUsuario;
		private Panel panel_Container;
		private Panel panel5;
		private Panel panel1;
		private Button btn_Asignar;
		private Label label_docentes;
		private Label label_cursos;
		private Panel panel2;
		private Label label_showName;
		private Label label_user;
		private ComboBox cB_docentes;
		private ComboBox cB_cursos;
	}
}