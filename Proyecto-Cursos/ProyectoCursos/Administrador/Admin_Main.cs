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
		private Form[] FormsInstances;
		#endregion

		#region Control
		private bool NavExpand = false; //Controlador booleano que almacena si el nav esta desplegado
		private int ActualFormIndex;
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
			panel_header.BackColor = ColorHeader;
			btn_menu.BackColor = ColorHeader;
			btn_close.BackColor = ColorHeader;
			flp_nav.BackColor = ColorNav;
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

			for (int i = 0; i < nav_Panels.Length; i++)
			{
				nav_Panels[i].BackColor = ColorNav;
				nav_Buttons[i].BackColor = ColorNav;
			}
		}
		private void FormConfig()
		{
			FormsInstances = [
				new Admin_UserCreate(){ MdiParent = this, Enabled = false, Visible = false, FormBorderStyle = FormBorderStyle.None},
				];
			ActualFormIndex = 0;
			FormEnableAndDisable(ActualFormIndex);

			foreach(Form f in FormsInstances)
			{
				f.Dock = DockStyle.Fill;
			}
		}
		#endregion

		#region Header
		private void btn_menu_Click(object sender, EventArgs e)
		{
			menuTransition.Start();
		}

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

		private void btn_close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private static void ChangeColorPictureAndButton(PictureBox pic, Button btn, Color color)
		{
			//Esta funcion cambia el color de fondo del boton y de una imagen png
			pic.BackColor = color;
			btn.BackColor = color;
			btn.FlatAppearance.MouseOverBackColor = color;
		}
		#endregion

		#region Nav
		private void btn_nav_1_Click(object sender, EventArgs e)
		{
			FormEnableAndDisable(0);
		}

		private void FormEnableAndDisable(int indexToEnable)
		{
			bool disable = false;
			for (int i = 0; i < FormsInstances.Length; i++)
			{
				if(i != indexToEnable)
				{
					FormsInstances[i].Enabled = disable;
					FormsInstances[i].Visible = disable;
				}
				else
				{
					FormsInstances[i].Enabled = !disable;
					FormsInstances[i].Visible = !disable;
				}
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

		private void menuTransition_Tick(object sender, EventArgs e)
		{
			const int maxWidth = 200;
			const int minWidth = 37;
			const int growing = 10;

			if (!NavExpand)
			{
				flp_nav.Width += growing;
				if (flp_nav.Width >= maxWidth)
				{
					menuTransition.Stop();
					flp_nav.Width = maxWidth;
					NavExpand = true;
				}
			}
			else
			{
				flp_nav.Width -= growing;
				if (flp_nav.Width <= minWidth)
				{
					menuTransition.Stop();
					flp_nav.Width = minWidth;
					NavExpand = false;
				}
			}
		}
	}
}
