namespace ProyectoCursos.Administrador
{
	partial class Admin_share
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
			label_enviar = new Label();
			panel_Container = new Panel();
			panel5 = new Panel();
			panel1 = new Panel();
			textBox_send = new TextBox();
			cB_cursos = new ComboBox();
			label_docentes = new Label();
			label_cursos = new Label();
			panel2 = new Panel();
			btn_enviar = new Button();
			textBox_Message = new TextBox();
			label1 = new Label();
			label_user = new Label();
			textBox_topic = new TextBox();
			panel_Container.SuspendLayout();
			panel5.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label_enviar
			// 
			label_enviar.Dock = DockStyle.Top;
			label_enviar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_enviar.Location = new Point(0, 0);
			label_enviar.Name = "label_enviar";
			label_enviar.Size = new Size(800, 71);
			label_enviar.TabIndex = 3;
			label_enviar.Text = "Enviar Informacion";
			label_enviar.TextAlign = ContentAlignment.MiddleCenter;
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
			panel1.Controls.Add(textBox_send);
			panel1.Controls.Add(cB_cursos);
			panel1.Controls.Add(label_docentes);
			panel1.Controls.Add(label_cursos);
			panel1.Location = new Point(12, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(284, 296);
			panel1.TabIndex = 2;
			// 
			// textBox_send
			// 
			textBox_send.Location = new Point(3, 90);
			textBox_send.Name = "textBox_send";
			textBox_send.Size = new Size(278, 23);
			textBox_send.TabIndex = 10;
			// 
			// cB_cursos
			// 
			cB_cursos.FormattingEnabled = true;
			cB_cursos.Location = new Point(3, 28);
			cB_cursos.Name = "cB_cursos";
			cB_cursos.Size = new Size(278, 23);
			cB_cursos.TabIndex = 9;
			// 
			// label_docentes
			// 
			label_docentes.AutoSize = true;
			label_docentes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_docentes.Location = new Point(3, 70);
			label_docentes.Name = "label_docentes";
			label_docentes.Size = new Size(167, 17);
			label_docentes.TabIndex = 3;
			label_docentes.Text = "Usuario a enviar mensaje:";
			// 
			// label_cursos
			// 
			label_cursos.AutoSize = true;
			label_cursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_cursos.Location = new Point(3, 10);
			label_cursos.Name = "label_cursos";
			label_cursos.Size = new Size(176, 17);
			label_cursos.TabIndex = 1;
			label_cursos.Text = "Cursos a enviar el mensaje:";
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(btn_enviar);
			panel2.Controls.Add(textBox_Message);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(label_user);
			panel2.Controls.Add(textBox_topic);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(532, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(268, 311);
			panel2.TabIndex = 3;
			// 
			// btn_enviar
			// 
			btn_enviar.Location = new Point(165, 273);
			btn_enviar.Name = "btn_enviar";
			btn_enviar.Size = new Size(100, 23);
			btn_enviar.TabIndex = 11;
			btn_enviar.Text = "Enviar";
			btn_enviar.UseVisualStyleBackColor = true;
			// 
			// textBox_Message
			// 
			textBox_Message.Location = new Point(3, 93);
			textBox_Message.Multiline = true;
			textBox_Message.Name = "textBox_Message";
			textBox_Message.Size = new Size(262, 172);
			textBox_Message.TabIndex = 7;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 73);
			label1.Name = "label1";
			label1.Size = new Size(80, 17);
			label1.TabIndex = 6;
			label1.Text = "Mensaje:";
			// 
			// label_user
			// 
			label_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label_user.Location = new Point(3, 10);
			label_user.Name = "label_user";
			label_user.Size = new Size(80, 17);
			label_user.TabIndex = 2;
			label_user.Text = "Asunto:";
			// 
			// textBox_topic
			// 
			textBox_topic.Location = new Point(3, 27);
			textBox_topic.Name = "textBox_topic";
			textBox_topic.Size = new Size(262, 23);
			textBox_topic.TabIndex = 5;
			// 
			// Admin_share
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 400);
			Controls.Add(panel_Container);
			Controls.Add(label_enviar);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Admin_share";
			Text = "Admin_share";
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

		private Label label_enviar;
		private Panel panel_Container;
		private Panel panel5;
		private Panel panel1;
		private TextBox textBox_send;
		private ComboBox cB_cursos;
		private Label label_docentes;
		private Label label_cursos;
		private Panel panel2;
		private Label label_user;
		private TextBox textBox_topic;
		private Button btn_enviar;
		private TextBox textBox_Message;
		private Label label1;
	}
}