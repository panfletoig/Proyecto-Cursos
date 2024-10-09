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
			button_ingreso = new Button();
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
			// button_ingreso
			// 
			button_ingreso.Location = new Point(84, 217);
			button_ingreso.Name = "button_ingreso";
			button_ingreso.Size = new Size(152, 23);
			button_ingreso.TabIndex = 4;
			button_ingreso.Text = "Ingresar";
			button_ingreso.UseVisualStyleBackColor = true;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 351);
			Controls.Add(button_ingreso);
			Controls.Add(label_pass);
			Controls.Add(label_user);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Login";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label label_user;
		private Label label_pass;
		private Button button_ingreso;
	}
}