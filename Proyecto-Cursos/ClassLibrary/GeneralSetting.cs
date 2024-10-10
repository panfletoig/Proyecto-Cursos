using System.Drawing;

namespace ClassLibrary
{
	public class GeneralSetting
	{
		#region Test
		private const bool _Test = true; //Proporciona herramientas para facilitar el desarollo
		public static bool Test { get { return _Test; } }
		#endregion

		#region Colors
		//Colores hexadecimales de la paleta de colores
		private const string HexCode1 = "#2b85ca";
		private const string HexCode2 = "#2ba2c8";
		private const string HexCode3 = "#2bc5c8";
		private const string HexCode4 = "#9cdfdf";
		private const string HexCode5 = "#deeded";

		public static Color Blue1 { get{ return ColorTranslator.FromHtml(HexCode1); } }
		public static Color Blue2 { get{ return ColorTranslator.FromHtml(HexCode2); } }
		public static Color Blue3 { get{ return ColorTranslator.FromHtml(HexCode3); } }
		public static Color Blue4 { get{ return ColorTranslator.FromHtml(HexCode4); } }
		public static Color Blue5 { get{ return ColorTranslator.FromHtml(HexCode5); } }
		#endregion
	}
}
