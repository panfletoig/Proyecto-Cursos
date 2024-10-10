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
		//Variables
		private int user; //Usada para almacenar el tipo de usuario a crear
		
		//Metodos
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

		#region Buttons_Actions
		private void btn_docente_Click(object sender, EventArgs e)
		{
			EnableExtraOptions(1); 
			ShowSelectetButton(btn_docente);
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
		private void EnableExtraOptions(int index)
		{
			//Funcion(opcion seleccionada) usada para determinar si nesesita parametros extra
			int isTeacher = 1; //el profesor equivale a 1
			user = index; //Setea el valor de la variable

			if (user != isTeacher)
			{
				//Si no es profesor desactiva los campos extra
				label_docente.Visible = false;
				cB_especialidad.Visible = false;
			}
			else
			{
				//Si es profesor activa los campos extra
				label_docente.Visible = true;
				cB_especialidad.Visible = true;
			}
		}
		private void ShowSelectetButton(Button btn)
		{
			//Almacena los bottones con opciones
			Button[] buttons = [
					btn_alumno,
					btn_docente,
					btn_administrativo
				];

			//Cambia el color del boton que se recibio como parametro
			foreach (Button b in buttons)
			{
				if (b.Text == btn.Text)
				{
					//si el texto es igual al del botton enviado como parametro lo cambia
					btn.BackColor = GeneralSetting.Blue3;
					continue;
				}
				//cambia el color del boton a su original
				b.BackColor = default(Color);
			}
		}
		#endregion


	}
}
