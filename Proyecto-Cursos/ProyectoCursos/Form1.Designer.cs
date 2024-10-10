namespace ProyectoCursos
{
	partial class Login
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label_user = new Label();
			label_pass = new Label();
			btn_ingreso = new Button();
			btn_admin = new Button();
			btn_alumno = new Button();
			btn_profesor = new Button();
			label_Test = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(84, 78);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(152, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(84, 145);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(152, 23);
			textBox2.TabIndex = 1;
			// 
			// label_user
			// 
			label_user.AutoSize = true;
			label_user.Location = new Point(84, 60);
			label_user.Name = "label_user";
			label_user.Size = new Size(50, 15);
			label_user.TabIndex = 2;
			label_user.Text = "Usuario:";
			// 
			// label_pass
			// 
			label_pass.AutoSize = true;
			label_pass.Location = new Point(84, 127);
			label_pass.Name = "label_pass";
			label_pass.Size = new Size(70, 15);
			label_pass.TabIndex = 3;
			label_pass.Text = "Contraseña:";
			// 
			// btn_ingreso
			// 
			btn_ingreso.Location = new Point(84, 217);
			btn_ingreso.Name = "btn_ingreso";
			btn_ingreso.Size = new Size(152, 23);
			btn_ingreso.TabIndex = 4;
			btn_ingreso.Text = "Ingresar";
			btn_ingreso.UseVisualStyleBackColor = true;
			btn_ingreso.Click += btn_ingreso_Click;
			// 
			// btn_admin
			// 
			btn_admin.Location = new Point(12, 302);
			btn_admin.Name = "btn_admin";
			btn_admin.Size = new Size(90, 23);
			btn_admin.TabIndex = 5;
			btn_admin.Text = "Admin";
			btn_admin.UseVisualStyleBackColor = true;
			btn_admin.Click += btn_admin_Click;
			// 
			// btn_alumno
			// 
			btn_alumno.Location = new Point(118, 302);
			btn_alumno.Name = "btn_alumno";
			btn_alumno.Size = new Size(90, 23);
			btn_alumno.TabIndex = 6;
			btn_alumno.Text = "Alumno";
			btn_alumno.UseVisualStyleBackColor = true;
			btn_alumno.Click += btn_alumno_Click;
			// 
			// btn_profesor
			// 
			btn_profesor.Location = new Point(224, 302);
			btn_profesor.Name = "btn_profesor";
			btn_profesor.Size = new Size(88, 23);
			btn_profesor.TabIndex = 7;
			btn_profesor.Text = "Profesor";
			btn_profesor.UseVisualStyleBackColor = true;
			btn_profesor.Click += btn_profesor_Click;
			// 
			// label_Test
			// 
			label_Test.AutoSize = true;
			label_Test.Location = new Point(141, 273);
			label_Test.Name = "label_Test";
			label_Test.Size = new Size(40, 15);
			label_Test.TabIndex = 8;
			label_Test.Text = "Testeo";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 351);
			Controls.Add(label_Test);
			Controls.Add(btn_profesor);
			Controls.Add(btn_alumno);
			Controls.Add(btn_admin);
			Controls.Add(btn_ingreso);
			Controls.Add(label_pass);
			Controls.Add(label_user);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label label_user;
		private Label label_pass;
		private Button btn_ingreso;
		private Button btn_admin;
		private Button btn_alumno;
		private Button btn_profesor;
		private Label label_Test;
	}
}