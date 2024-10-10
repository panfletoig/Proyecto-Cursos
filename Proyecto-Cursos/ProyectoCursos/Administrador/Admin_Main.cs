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
	public partial class Admin_Main : Form
	{

		//Variables
		#region Color
		private readonly Color ColorHeader = GeneralSetting.Blue5; //Contiene el color natural del header
		private readonly Color ColorHeaderBtn = GeneralSetting.Blue4; //Contiene el color de los botones mientras el cursor este sobre ellos

		private readonly Color ColorNav = GeneralSetting.Blue1; //Contiene el color natural de la barra de navegacion
		private readonly Color ColorNavBtn = GeneralSetting.Blue3; //Contiene el colo de los botones de navegacion mientras el cursor este sobre ellos
		#endregion

		#region Forms
		private Form[] FormsInstances; //Guarda todos los formularios Hijos
		#endregion

		#region Control
		private bool NavExpand = false; //Controlador booleano que almacena si el nav esta desplegado
		private int ActualFormIndex = 0; //Hace referencia al formulario que esta mostrando en ese momento
		private bool Draggin = false; //Booleano usado para determinar si se esta agarrando el header
		private Point StartPoint = new Point(0, 0); //Punto inicial usado para guardar X,Y del Mouse
		#endregion


		//Metodos
		#region InitialSettings

		public Admin_Main()
		{
			InitializeComponent();
			InitialSettingsConfiguration();
		}
		private void InitialSettingsConfiguration()
		{
			HeaderConfig();
			NavConfig();
			FormConfig();
		}
		private void HeaderConfig()
		{
			//Asigna el color principal a los componentes del header
			panel_header.BackColor = ColorHeader;
			btn_menu.BackColor = ColorHeader;
			btn_close.BackColor = ColorHeader;
		}
		private void NavConfig()
		{

			//Paneles con botones del nav
			Panel[] nav_Panels = [
				panel_nav_container_1, panel_nav_container_2,
				panel_nav_container_3, panel_nav_container_4,
				panel_nav_container_5
				];
			//Botones de opciones del nav
			Button[] nav_Buttons = [
				btn_nav_1, btn_nav_2,
				btn_nav_3, btn_nav_4,
				btn_nav_5
				];
			flp_nav.Width = 37; //Tamaño inicial

			//Coloca los componentes en el color respectivo
			for (int i = 0; i < nav_Panels.Length; i++)
			{
				nav_Panels[i].BackColor = ColorNav;
				nav_Buttons[i].BackColor = ColorNav;
			}
			flp_nav.BackColor = ColorNav;
		}
		private void FormConfig()
		{
			//Almacena y agrega unas configuraciones a los formularios hijos
			FormsInstances = [
				new Admin_UserCreate(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
				new Admin_CourseCreate(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
				new Admin_AsignarCurso(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
				new Admin_Unlock(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
				new Admin_share(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
			];

			//Abre el primer formulario
			FormEnableAndDisable(ActualFormIndex);

			//Los coloca rellenando el espacio restante
			foreach (Form f in FormsInstances)
			{
				f.Dock = DockStyle.Fill;
			}
		}
		#endregion

		#region Header
		#region Header_Buttons_Color
		//Esta region se encarga de colocar los colores cuando el mouse esta o no esta en el boton
		private void btn_menu_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPictureAndButton(pic_menu, btn_menu, ColorHeaderBtn);
		}

		private void btn_menu_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPictureAndButton(pic_menu, btn_menu, ColorHeader);
		}

		private void btn_close_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPictureAndButton(pic_close, btn_close, ColorHeaderBtn);
		}

		private void btn_close_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPictureAndButton(pic_menu, btn_menu, ColorHeader);
		}
		private static void ChangeColorPictureAndButton(PictureBox pic, Button btn, Color color)
		{
			//Esta funcion cambia el color de fondo del boton y de una imagen png
			pic.BackColor = color;
			btn.BackColor = color;
			btn.FlatAppearance.MouseOverBackColor = color;
		}
		#endregion

		#region Header_Buttons_Actions
		private void btn_menu_Click(object sender, EventArgs e)
		{
			//Si se da click inicia una trancicion para abrir y cerrar el menu
			menuTransition.Start();
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			//Cierra la aplicación
			Application.Exit();
		}
		#endregion

		#region Header_Panel_Drag
		private void panel_header_MouseDown(object sender, MouseEventArgs e)
		{
			Draggin = true;
			StartPoint = new Point(e.X, e.Y);
		}

		private void panel_header_MouseUp(object sender, MouseEventArgs e)
		{
			Draggin = false;
		}

		private void panel_header_MouseMove(object sender, MouseEventArgs e)
		{
			if (Draggin)
			{
				Point p = PointToScreen(e.Location);
				Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
			}
		}
		#endregion
		#endregion

		#region Nav
		private void btn_nav_1_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(0);
		}
		private void btn_nav_2_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(1);
		}
		private void btn_nav_3_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(2);
		}
		private void btn_nav_4_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(3);
		}
		private void btn_nav_5_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(4);
		}

		private void FormEnableAndDisable(int indexToEnable) 
		{
			//Funcion(formulario que debe activar)
			bool disable = false; //variable de control para hacer cambios rapidos
			for (int i = 0; i < FormsInstances.Length; i++)
			{
				if (i != indexToEnable)
				{
					//Si no es el formulario que se busca desactiva los demas
					FormsInstances[i].Enabled = disable;
					FormsInstances[i].Visible = disable;
					continue; //continua la siguiente ejecusion 
				}

				//Activa el formulario que se busca
				FormsInstances[i].Enabled = !disable;
				FormsInstances[i].Visible = !disable;
			}
		}

		private static void ChangeColorPanelAndButton(Panel panel, Button btn, Color color)
		{
			//Cambia el color del boton y de el panel
			panel.BackColor = color;
			btn.BackColor = color;
			btn.FlatAppearance.MouseOverBackColor = color;
		}

		private void btn_nav_1_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_1, btn_nav_1, ColorNavBtn);
		}

		private void btn_nav_1_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_1, btn_nav_1, ColorNav);
		}

		private void btn_nav_2_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_2, btn_nav_2, ColorNavBtn);
		}

		private void btn_nav_2_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_2, btn_nav_2, ColorNav);
		}
		private void btn_nav_3_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_3, btn_nav_3, ColorNavBtn);
		}

		private void btn_nav_3_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_3, btn_nav_3, ColorNav);
		}
		private void btn_nav_4_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_4, btn_nav_4, ColorNavBtn);
		}

		private void btn_nav_4_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_4, btn_nav_4, ColorNav);
		}
		private void btn_nav_5_MouseEnter(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_5, btn_nav_5, ColorNavBtn);
		}

		private void btn_nav_5_MouseLeave(object sender, EventArgs e)
		{
			ChangeColorPanelAndButton(panel_nav_container_5, btn_nav_5, ColorNav);
		}
		#endregion

		#region Transition
		private void menuTransition_Tick(object sender, EventArgs e)
		{
			const int maxWidth = 200; //Ancho maximo que puede tener el nav
			const int minWidth = 37; //Ancho minimo que puede tener el nav
			const int growing = 10; //Velocidad de la transicion

			if (!NavExpand)
			{
				//Si el menu no esta expandido
				flp_nav.Width += growing; //le suma el crecimiento cada tick
				if (flp_nav.Width >= maxWidth) //si llego al tamaño maximo
				{
					menuTransition.Stop(); //Detiene el timer
					flp_nav.Width = maxWidth; //Setea a valores maximos
					NavExpand = true; //coloca que el menu esta desplegado
				}
			}
			else
			{
				//Hace la animacion inversa
				flp_nav.Width -= growing; 
				if (flp_nav.Width <= minWidth)
				{
					menuTransition.Stop();
					flp_nav.Width = minWidth;
					NavExpand = false;
				}
			}
		}
		#endregion
	}
}
