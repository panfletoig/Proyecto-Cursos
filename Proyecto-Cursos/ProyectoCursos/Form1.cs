using ProyectoCursos.Administrador;
using ProyectoCursos.Alumno;
using ProyectoCursos.Profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace ProyectoCursos
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

			#region Testing

			//En caso de prueba de aplicacion se mostraran botones extra para facilitar el desarollo
			if (!GeneralSetting.Test)
			{
				label_Test.Hide();
				btn_admin.Hide();
				btn_alumno.Hide();
				btn_profesor.Hide();
			}
			
			#endregion
		}

		private void btn_ingreso_Click(object sender, EventArgs e)
		{
			//this.Hide();
		}

		private void btn_admin_Click(object sender, EventArgs e)
		{
			Admin_Main adminMain = new();
			adminMain.Show();
		}

		private void btn_alumno_Click(object sender, EventArgs e)
		{
			Alumno_Main alumnoMain = new();
			alumnoMain.Show();
		}

		private void btn_profesor_Click(object sender, EventArgs e)
		{
			Profesor_Main profesorMain = new();
			profesorMain.Show();
		}

		private void Login_Load(object sender, EventArgs e)
		{
		}
	}
}
