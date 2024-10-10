namespace ProyectoCursos.Administrador
{
	partial class Admin_Main
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
			components = new System.ComponentModel.Container();
			panel_header = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			pic_close = new PictureBox();
			pic_menu = new PictureBox();
			btn_menu = new Button();
			label_header_administrator = new Label();
			btn_close = new Button();
			flp_nav = new FlowLayoutPanel();
			panel_nav_container_1 = new Panel();
			btn_nav_1 = new Button();
			panel_nav_container_2 = new Panel();
			btn_nav_2 = new Button();
			panel_nav_container_3 = new Panel();
			btn_nav_3 = new Button();
			panel_nav_container_4 = new Panel();
			btn_nav_4 = new Button();
			panel_nav_container_5 = new Panel();
			btn_nav_5 = new Button();
			menuTransition = new System.Windows.Forms.Timer(components);
			panel_header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pic_close).BeginInit();
			((System.ComponentModel.ISupportInitialize)pic_menu).BeginInit();
			flp_nav.SuspendLayout();
			panel_nav_container_1.SuspendLayout();
			panel_nav_container_2.SuspendLayout();
			panel_nav_container_3.SuspendLayout();
			panel_nav_container_4.SuspendLayout();
			panel_nav_container_5.SuspendLayout();
			SuspendLayout();
			// 
			// panel_header
			// 
			panel_header.BackColor = SystemColors.ActiveCaption;
			panel_header.Controls.Add(flowLayoutPanel1);
			panel_header.Controls.Add(pic_close);
			panel_header.Controls.Add(pic_menu);
			panel_header.Controls.Add(btn_menu);
			panel_header.Controls.Add(label_header_administrator);
			panel_header.Controls.Add(btn_close);
			panel_header.Dock = DockStyle.Top;
			panel_header.Location = new Point(0, 0);
			panel_header.Margin = new Padding(0);
			panel_header.Name = "panel_header";
			panel_header.Size = new Size(800, 37);
			panel_header.TabIndex = 1;
			panel_header.MouseDown += panel_header_MouseDown;
			panel_header.MouseMove += panel_header_MouseMove;
			panel_header.MouseUp += panel_header_MouseUp;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(0, 37);
			flowLayoutPanel1.Margin = new Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(200, 404);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// pic_close
			// 
			pic_close.AccessibleRole = AccessibleRole.None;
			pic_close.BackColor = Color.Transparent;
			pic_close.BackgroundImageLayout = ImageLayout.Stretch;
			pic_close.Enabled = false;
			pic_close.Image = Properties.Resources.Close;
			pic_close.Location = new Point(765, 2);
			pic_close.Name = "pic_close";
			pic_close.Padding = new Padding(6);
			pic_close.Size = new Size(33, 33);
			pic_close.SizeMode = PictureBoxSizeMode.StretchImage;
			pic_close.TabIndex = 5;
			pic_close.TabStop = false;
			// 
			// pic_menu
			// 
			pic_menu.AccessibleRole = AccessibleRole.None;
			pic_menu.BackColor = Color.Transparent;
			pic_menu.BackgroundImageLayout = ImageLayout.Stretch;
			pic_menu.Enabled = false;
			pic_menu.Image = Properties.Resources.Menu;
			pic_menu.Location = new Point(2, 2);
			pic_menu.Name = "pic_menu";
			pic_menu.Padding = new Padding(7);
			pic_menu.Size = new Size(32, 32);
			pic_menu.SizeMode = PictureBoxSizeMode.StretchImage;
			pic_menu.TabIndex = 4;
			pic_menu.TabStop = false;
			// 
			// btn_menu
			// 
			btn_menu.BackColor = Color.Black;
			btn_menu.BackgroundImageLayout = ImageLayout.Stretch;
			btn_menu.CausesValidation = false;
			btn_menu.Cursor = Cursors.Hand;
			btn_menu.Dock = DockStyle.Left;
			btn_menu.FlatAppearance.BorderSize = 0;
			btn_menu.FlatStyle = FlatStyle.Flat;
			btn_menu.ForeColor = Color.Transparent;
			btn_menu.Location = new Point(0, 0);
			btn_menu.Margin = new Padding(0);
			btn_menu.Name = "btn_menu";
			btn_menu.Size = new Size(37, 37);
			btn_menu.TabIndex = 3;
			btn_menu.UseVisualStyleBackColor = false;
			btn_menu.Click += btn_menu_Click;
			btn_menu.MouseEnter += btn_menu_MouseEnter;
			btn_menu.MouseLeave += btn_menu_MouseLeave;
			// 
			// label_header_administrator
			// 
			label_header_administrator.AutoSize = true;
			label_header_administrator.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label_header_administrator.Location = new Point(40, 9);
			label_header_administrator.Name = "label_header_administrator";
			label_header_administrator.Size = new Size(91, 17);
			label_header_administrator.TabIndex = 2;
			label_header_administrator.Text = "Administrador";
			// 
			// btn_close
			// 
			btn_close.BackColor = Color.Black;
			btn_close.BackgroundImageLayout = ImageLayout.Stretch;
			btn_close.CausesValidation = false;
			btn_close.Cursor = Cursors.Hand;
			btn_close.Dock = DockStyle.Right;
			btn_close.FlatAppearance.BorderSize = 0;
			btn_close.FlatStyle = FlatStyle.Flat;
			btn_close.ForeColor = Color.Transparent;
			btn_close.Location = new Point(763, 0);
			btn_close.Margin = new Padding(0);
			btn_close.Name = "btn_close";
			btn_close.Size = new Size(37, 37);
			btn_close.TabIndex = 6;
			btn_close.UseVisualStyleBackColor = false;
			btn_close.Click += btn_close_Click;
			btn_close.MouseEnter += btn_close_MouseEnter;
			btn_close.MouseLeave += btn_close_MouseLeave;
			// 
			// flp_nav
			// 
			flp_nav.BackColor = SystemColors.AppWorkspace;
			flp_nav.Controls.Add(panel_nav_container_1);
			flp_nav.Controls.Add(panel_nav_container_2);
			flp_nav.Controls.Add(panel_nav_container_3);
			flp_nav.Controls.Add(panel_nav_container_4);
			flp_nav.Controls.Add(panel_nav_container_5);
			flp_nav.Dock = DockStyle.Left;
			flp_nav.Location = new Point(0, 37);
			flp_nav.Margin = new Padding(0);
			flp_nav.Name = "flp_nav";
			flp_nav.Size = new Size(37, 413);
			flp_nav.TabIndex = 2;
			// 
			// panel_nav_container_1
			// 
			panel_nav_container_1.BackColor = SystemColors.ActiveCaptionText;
			panel_nav_container_1.Controls.Add(btn_nav_1);
			panel_nav_container_1.Location = new Point(0, 0);
			panel_nav_container_1.Margin = new Padding(0);
			panel_nav_container_1.Name = "panel_nav_container_1";
			panel_nav_container_1.Size = new Size(200, 50);
			panel_nav_container_1.TabIndex = 3;
			// 
			// btn_nav_1
			// 
			btn_nav_1.BackColor = SystemColors.AppWorkspace;
			btn_nav_1.Cursor = Cursors.Hand;
			btn_nav_1.FlatAppearance.BorderSize = 0;
			btn_nav_1.FlatStyle = FlatStyle.Flat;
			btn_nav_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_nav_1.Image = Properties.Resources.user;
			btn_nav_1.ImageAlign = ContentAlignment.MiddleLeft;
			btn_nav_1.Location = new Point(3, -11);
			btn_nav_1.Name = "btn_nav_1";
			btn_nav_1.RightToLeft = RightToLeft.No;
			btn_nav_1.Size = new Size(194, 76);
			btn_nav_1.TabIndex = 0;
			btn_nav_1.Text = "         Crear Usuario";
			btn_nav_1.TextAlign = ContentAlignment.MiddleLeft;
			btn_nav_1.UseVisualStyleBackColor = false;
			btn_nav_1.Click += btn_nav_1_Click;
			btn_nav_1.MouseEnter += btn_nav_1_MouseEnter;
			btn_nav_1.MouseLeave += btn_nav_1_MouseLeave;
			// 
			// panel_nav_container_2
			// 
			panel_nav_container_2.BackColor = SystemColors.ActiveCaptionText;
			panel_nav_container_2.Controls.Add(btn_nav_2);
			panel_nav_container_2.Location = new Point(0, 50);
			panel_nav_container_2.Margin = new Padding(0);
			panel_nav_container_2.Name = "panel_nav_container_2";
			panel_nav_container_2.Size = new Size(200, 50);
			panel_nav_container_2.TabIndex = 4;
			// 
			// btn_nav_2
			// 
			btn_nav_2.BackColor = SystemColors.AppWorkspace;
			btn_nav_2.Cursor = Cursors.Hand;
			btn_nav_2.FlatAppearance.BorderSize = 0;
			btn_nav_2.FlatStyle = FlatStyle.Flat;
			btn_nav_2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_nav_2.Image = Properties.Resources.Books;
			btn_nav_2.ImageAlign = ContentAlignment.MiddleLeft;
			btn_nav_2.Location = new Point(3, -11);
			btn_nav_2.Name = "btn_nav_2";
			btn_nav_2.RightToLeft = RightToLeft.No;
			btn_nav_2.Size = new Size(194, 76);
			btn_nav_2.TabIndex = 0;
			btn_nav_2.Text = "         Crear Curso";
			btn_nav_2.TextAlign = ContentAlignment.MiddleLeft;
			btn_nav_2.UseVisualStyleBackColor = false;
			btn_nav_2.Click += btn_nav_2_Click;
			btn_nav_2.MouseEnter += btn_nav_2_MouseEnter;
			btn_nav_2.MouseLeave += btn_nav_2_MouseLeave;
			// 
			// panel_nav_container_3
			// 
			panel_nav_container_3.BackColor = SystemColors.ActiveCaptionText;
			panel_nav_container_3.Controls.Add(btn_nav_3);
			panel_nav_container_3.Location = new Point(0, 100);
			panel_nav_container_3.Margin = new Padding(0);
			panel_nav_container_3.Name = "panel_nav_container_3";
			panel_nav_container_3.Size = new Size(200, 50);
			panel_nav_container_3.TabIndex = 5;
			// 
			// btn_nav_3
			// 
			btn_nav_3.BackColor = SystemColors.AppWorkspace;
			btn_nav_3.Cursor = Cursors.Hand;
			btn_nav_3.FlatAppearance.BorderSize = 0;
			btn_nav_3.FlatStyle = FlatStyle.Flat;
			btn_nav_3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_nav_3.Image = Properties.Resources.Task;
			btn_nav_3.ImageAlign = ContentAlignment.MiddleLeft;
			btn_nav_3.Location = new Point(3, -11);
			btn_nav_3.Name = "btn_nav_3";
			btn_nav_3.RightToLeft = RightToLeft.No;
			btn_nav_3.Size = new Size(194, 76);
			btn_nav_3.TabIndex = 0;
			btn_nav_3.Text = "         Asignar Docente";
			btn_nav_3.TextAlign = ContentAlignment.MiddleLeft;
			btn_nav_3.UseVisualStyleBackColor = false;
			btn_nav_3.Click += btn_nav_3_Click;
			btn_nav_3.MouseEnter += btn_nav_3_MouseEnter;
			btn_nav_3.MouseLeave += btn_nav_3_MouseLeave;
			// 
			// panel_nav_container_4
			// 
			panel_nav_container_4.BackColor = SystemColors.ActiveCaptionText;
			panel_nav_container_4.Controls.Add(btn_nav_4);
			panel_nav_container_4.Location = new Point(0, 150);
			panel_nav_container_4.Margin = new Padding(0);
			panel_nav_container_4.Name = "panel_nav_container_4";
			panel_nav_container_4.Size = new Size(200, 50);
			panel_nav_container_4.TabIndex = 5;
			// 
			// btn_nav_4
			// 
			btn_nav_4.BackColor = SystemColors.AppWorkspace;
			btn_nav_4.Cursor = Cursors.Hand;
			btn_nav_4.FlatAppearance.BorderSize = 0;
			btn_nav_4.FlatStyle = FlatStyle.Flat;
			btn_nav_4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_nav_4.Image = Properties.Resources.Lock;
			btn_nav_4.ImageAlign = ContentAlignment.MiddleLeft;
			btn_nav_4.Location = new Point(3, -11);
			btn_nav_4.Name = "btn_nav_4";
			btn_nav_4.RightToLeft = RightToLeft.No;
			btn_nav_4.Size = new Size(194, 76);
			btn_nav_4.TabIndex = 0;
			btn_nav_4.Text = "         Desbloquear Cuenta";
			btn_nav_4.TextAlign = ContentAlignment.MiddleLeft;
			btn_nav_4.UseVisualStyleBackColor = false;
			btn_nav_4.Click += btn_nav_4_Click;
			btn_nav_4.MouseEnter += btn_nav_4_MouseEnter;
			btn_nav_4.MouseLeave += btn_nav_4_MouseLeave;
			// 
			// panel_nav_container_5
			// 
			panel_nav_container_5.BackColor = SystemColors.ActiveCaptionText;
			panel_nav_container_5.Controls.Add(btn_nav_5);
			panel_nav_container_5.Location = new Point(0, 200);
			panel_nav_container_5.Margin = new Padding(0);
			panel_nav_container_5.Name = "panel_nav_container_5";
			panel_nav_container_5.Size = new Size(200, 50);
			panel_nav_container_5.TabIndex = 5;
			// 
			// btn_nav_5
			// 
			btn_nav_5.BackColor = SystemColors.AppWorkspace;
			btn_nav_5.Cursor = Cursors.Hand;
			btn_nav_5.FlatAppearance.BorderSize = 0;
			btn_nav_5.FlatStyle = FlatStyle.Flat;
			btn_nav_5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_nav_5.Image = Properties.Resources.Share;
			btn_nav_5.ImageAlign = ContentAlignment.MiddleLeft;
			btn_nav_5.Location = new Point(3, -11);
			btn_nav_5.Name = "btn_nav_5";
			btn_nav_5.RightToLeft = RightToLeft.No;
			btn_nav_5.Size = new Size(194, 76);
			btn_nav_5.TabIndex = 0;
			btn_nav_5.Text = "         Enviar Información";
			btn_nav_5.TextAlign = ContentAlignment.MiddleLeft;
			btn_nav_5.UseVisualStyleBackColor = false;
			btn_nav_5.Click += btn_nav_5_Click;
			btn_nav_5.MouseEnter += btn_nav_5_MouseEnter;
			btn_nav_5.MouseLeave += btn_nav_5_MouseLeave;
			// 
			// menuTransition
			// 
			menuTransition.Interval = 10;
			menuTransition.Tick += menuTransition_Tick;
			// 
			// Admin_Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(flp_nav);
			Controls.Add(panel_header);
			FormBorderStyle = FormBorderStyle.None;
			HelpButton = true;
			IsMdiContainer = true;
			Name = "Admin_Main";
			Text = "Admin Menu";
			panel_header.ResumeLayout(false);
			panel_header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pic_close).EndInit();
			((System.ComponentModel.ISupportInitialize)pic_menu).EndInit();
			flp_nav.ResumeLayout(false);
			panel_nav_container_1.ResumeLayout(false);
			panel_nav_container_2.ResumeLayout(false);
			panel_nav_container_3.ResumeLayout(false);
			panel_nav_container_4.ResumeLayout(false);
			panel_nav_container_5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel panel_header;
		private Label label_header_administrator;
		private Button btn_menu;
		private PictureBox pic_menu;
		private PictureBox pic_close;
		private Button btn_close;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flp_nav;
		private Panel panel_nav_container_1;
		private Button btn_nav_1;
		private Panel panel_nav_container_2;
		private Button btn_nav_2;
		private Panel panel_nav_container_3;
		private Button btn_nav_3;
		private Panel panel_nav_container_4;
		private Button btn_nav_4;
		private Panel panel_nav_container_5;
		private Button btn_nav_5;
		private System.Windows.Forms.Timer menuTransition;
	}
}