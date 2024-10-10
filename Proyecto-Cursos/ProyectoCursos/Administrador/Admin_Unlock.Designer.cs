namespace ProyectoCursos.Administrador
{
	partial class Admin_Unlock
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
			tb_nombre = new TextBox();
			label_Nombre = new Label();
			btn_alumno = new Button();
			panel2 = new Panel();
			panel6 = new Panel();
			btn_copy = new Button();
			label_ShowPass = new Label();
			label_ShowUser = new Label();
			label_pass = new Label();
			label_user = new Label();
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
			label_crearUsuario.TabIndex = 1;
			label_crearUsuario.Text = "Desbloquear Usuario";
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
			panel_Container.TabIndex = 7;
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
			panel1.Controls.Add(tb_nombre);
			panel1.Controls.Add(label_Nombre);
			panel1.Controls.Add(btn_alumno);
			panel1.Location = new Point(12, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(284, 296);
			panel1.TabIndex = 2;
			// 
			// tb_nombre
			// 
			tb_nombre.Location = new Point(3, 28);
			tb_nombre.Name = "tb_nombre";
			tb_nombre.Size = new Size(278, 23);
			tb_nombre.TabIndex = 2;
			// 
			// label_Nombre
			// 
			label_Nombre.AutoSize = true;
			label_Nombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_Nombre.Location = new Point(3, 10);
			label_Nombre.Name = "label_Nombre";
			label_Nombre.Size = new Size(59, 17);
			label_Nombre.TabIndex = 1;
			label_Nombre.Text = "Usuario:";
			// 
			// btn_alumno
			// 
			btn_alumno.Location = new Point(131, 143);
			btn_alumno.Name = "btn_alumno";
			btn_alumno.Size = new Size(150, 23);
			btn_alumno.TabIndex = 3;
			btn_alumno.Text = "Reiniciar credenciales";
			btn_alumno.UseVisualStyleBackColor = true;
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
			panel2.Location = new Point(520, 0);
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
			// Admin_Unlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 400);
			Controls.Add(panel_Container);
			Controls.Add(label_crearUsuario);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Admin_Unlock";
			Text = "Admin_Unlock";
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
		private Button btn_alumno;
		private Panel panel1;
		private TextBox tb_nombre;
		private Label label_Nombre;
		private Panel panel2;
		private Panel panel6;
		private Button btn_copy;
		private Label label_ShowPass;
		private Label label_ShowUser;
		private Label label_pass;
		private Label label_user;
	}
}