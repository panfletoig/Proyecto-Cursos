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

namespace ProyectoCursos.Administrador
{
	public partial class Admin_UserCreate : Form
	{
		private int user;
		public Admin_UserCreate()
		{
			InitializeComponent();
			InitializeSettings();
		}
		private void InitializeSettings()
		{
			this.ControlBox = false;
			EnableExtraOptions(-1);
		}

		private void btn_docente_Click(object sender, EventArgs e)
		{
			EnableExtraOptions(1);
			ShowSelectetButton(btn_docente);
		}
		private void EnableExtraOptions(int index)
		{
			int docente = 1;
			user = index;

			if (user != docente)
			{
				label_docente.Visible = false;
				cB_especialidad.Visible = false;
			}
			else
			{
				label_docente.Visible = true;
				cB_especialidad.Visible = true;
			}
		}
		private void ShowSelectetButton(Button btn)
		{
			Button[] buttons = [
					btn_alumno,
					btn_docente,
					btn_administrativo
				];

			foreach (Button b in buttons)
			{
				if(b.Text == btn.Text)
				{
					btn.BackColor = GeneralSetting.Blue3;
					continue;
				}
				b.BackColor = default(Color);
			}
		}
		private void btn_alumno_Click(object sender, EventArgs e)
		{
			EnableExtraOptions(0);
			ShowSelectetButton(btn_alumno);
		}

		private void btn_administrativo_Click(object sender, EventArgs e)
		{
			EnableExtraOptions(2);
			ShowSelectetButton(btn_administrativo);
		}
	}
}
