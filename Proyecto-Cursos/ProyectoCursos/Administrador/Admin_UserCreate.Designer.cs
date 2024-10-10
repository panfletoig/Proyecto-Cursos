namespace ProyectoCursos.Administrador
{
	partial class Admin_UserCreate
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
			label_Nombre = new Label();
			panel1 = new Panel();
			tb_nombre = new TextBox();
			panel2 = new Panel();
			panel6 = new Panel();
			btn_copy = new Button();
			label_ShowPass = new Label();
			label_ShowUser = new Label();
			label_pass = new Label();
			label_user = new Label();
			panel_Container = new Panel();
			panel5 = new Panel();
			panel4 = new Panel();
			btn_administrativo = new Button();
			btn_docente = new Button();
			btn_alumno = new Button();
			label_Options = new Label();
			panel3 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel_Container.SuspendLayout();
			panel5.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// label_crearUsuario
			// 
			label_crearUsuario.Dock = DockStyle.Top;
			label_crearUsuario.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_crearUsuario.Location = new Point(0, 0);
			label_crearUsuario.Name = "label_crearUsuario";
			label_crearUsuario.Size = new Size(958, 71);
			label_crearUsuario.TabIndex = 0;
			label_crearUsuario.Text = "Crear Usuario";
			label_crearUsuario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label_Nombre
			// 
			label_Nombre.AutoSize = true;
			label_Nombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_Nombre.Location = new Point(3, 10);
			label_Nombre.Name = "label_Nombre";
			label_Nombre.Size = new Size(62, 17);
			label_Nombre.TabIndex = 1;
			label_Nombre.Text = "Nombre:";
			// 
			// panel1
			// 
			panel1.Controls.Add(tb_nombre);
			panel1.Controls.Add(label_Nombre);
			panel1.Location = new Point(12, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(284, 61);
			panel1.TabIndex = 2;
			// 
			// tb_nombre
			// 
			tb_nombre.Location = new Point(3, 28);
			tb_nombre.Name = "tb_nombre";
			tb_nombre.Size = new Size(278, 23);
			tb_nombre.TabIndex = 2;
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(panel6);
			panel2.Controls.Add(btn_copy);
			panel2.Controls.Add(label_ShowPass);
			panel2.Controls.Add(label_ShowUser);
			panel2.Controls.Add(label_pass);
			panel2.Controls.Add(label_user);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(678, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(280, 311);
			panel2.TabIndex = 3;
			// 
			// panel6
			// 
			panel6.Location = new Point(229, 3);
			panel6.Name = "panel6";
			panel6.Size = new Size(48, 296);
			panel6.TabIndex = 7;
			// 
			// btn_copy
			// 
			btn_copy.Location = new Point(85, 146);
			btn_copy.Name = "btn_copy";
			btn_copy.Size = new Size(138, 23);
			btn_copy.TabIndex = 6;
			btn_copy.Text = "Copiar al portapapeles";
			btn_copy.UseVisualStyleBackColor = true;
			// 
			// label_ShowPass
			// 
			label_ShowPass.AutoSize = true;
			label_ShowPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label_ShowPass.Location = new Point(3, 73);
			label_ShowPass.Name = "label_ShowPass";
			label_ShowPass.Size = new Size(192, 17);
			label_ShowPass.TabIndex = 5;
			label_ShowPass.Text = "La contraseña se mostrara aqui";
			// 
			// label_ShowUser
			// 
			label_ShowUser.AutoSize = true;
			label_ShowUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label_ShowUser.Location = new Point(3, 28);
			label_ShowUser.Name = "label_ShowUser";
			label_ShowUser.Size = new Size(168, 17);
			label_ShowUser.TabIndex = 4;
			label_ShowUser.Text = "El usuario se mostrara aqui";
			// 
			// label_pass
			// 
			label_pass.AutoSize = true;
			label_pass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_pass.Location = new Point(3, 56);
			label_pass.Name = "label_pass";
			label_pass.Size = new Size(81, 17);
			label_pass.TabIndex = 3;
			label_pass.Text = "Contraseña:";
			// 
			// label_user
			// 
			label_user.AutoSize = true;
			label_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_user.Location = new Point(3, 10);
			label_user.Name = "label_user";
			label_user.Size = new Size(59, 17);
			label_user.TabIndex = 2;
			label_user.Text = "Usuario:";
			// 
			// panel_Container
			// 
			panel_Container.Controls.Add(panel5);
			panel_Container.Controls.Add(panel2);
			panel_Container.Dock = DockStyle.Bottom;
			panel_Container.Location = new Point(0, 81);
			panel_Container.Name = "panel_Container";
			panel_Container.Size = new Size(958, 311);
			panel_Container.TabIndex = 4;
			// 
			// panel5
			// 
			panel5.Controls.Add(panel4);
			panel5.Controls.Add(panel1);
			panel5.Dock = DockStyle.Left;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(302, 311);
			panel5.TabIndex = 8;
			// 
			// panel4
			// 
			panel4.Controls.Add(btn_administrativo);
			panel4.Controls.Add(btn_docente);
			panel4.Controls.Add(btn_alumno);
			panel4.Controls.Add(label_Options);
			panel4.Location = new Point(12, 70);
			panel4.Name = "panel4";
			panel4.Size = new Size(284, 116);
			panel4.TabIndex = 7;
			// 
			// btn_administrativo
			// 
			btn_administrativo.Location = new Point(3, 84);
			btn_administrativo.Name = "btn_administrativo";
			btn_administrativo.Size = new Size(278, 23);
			btn_administrativo.TabIndex = 5;
			btn_administrativo.Text = "Administrador";
			btn_administrativo.UseVisualStyleBackColor = true;
			// 
			// btn_docente
			// 
			btn_docente.Location = new Point(3, 55);
			btn_docente.Name = "btn_docente";
			btn_docente.Size = new Size(278, 23);
			btn_docente.TabIndex = 4;
			btn_docente.Text = "Docente";
			btn_docente.UseVisualStyleBackColor = true;
			// 
			// btn_alumno
			// 
			btn_alumno.Location = new Point(3, 26);
			btn_alumno.Name = "btn_alumno";
			btn_alumno.Size = new Size(278, 23);
			btn_alumno.TabIndex = 3;
			btn_alumno.Text = "Alumno";
			btn_alumno.UseVisualStyleBackColor = true;
			// 
			// label_Options
			// 
			label_Options.AutoSize = true;
			label_Options.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_Options.Location = new Point(3, 6);
			label_Options.Name = "label_Options";
			label_Options.Size = new Size(189, 17);
			label_Options.TabIndex = 2;
			label_Options.Text = "Seleccione el tipo de usuario:\r\n";
			// 
			// panel3
			// 
			panel3.Controls.Add(label_crearUsuario);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(958, 71);
			panel3.TabIndex = 5;
			// 
			// Admin_UserCreate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(958, 400);
			Controls.Add(panel_Container);
			Controls.Add(panel3);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Admin_UserCreate";
			Text = "Admin_UserCreate";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel_Container.ResumeLayout(false);
			panel_Container.PerformLayout();
			panel5.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label_crearUsuario;
		private Label label_Nombre;
		private Panel panel1;
		private TextBox tb_nombre;
		private Panel panel2;
		private Label label_ShowUser;
		private Label label_pass;
		private Label label_user;
		private Button btn_copy;
		private Label label_ShowPass;
		private Panel panel_Container;
		private Panel panel4;
		private Label label_Options;
		private Button btn_administrativo;
		private Button btn_docente;
		private Button btn_alumno;
		private Panel panel3;
		private Panel panel5;
		private Panel panel6;
	}
}