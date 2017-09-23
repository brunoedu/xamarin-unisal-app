using System;
using Xamarin.Forms;

namespace UnisalApp
{
	public class MenuPage : TabbedPage
	{
		public MenuPage ()
		{
			Title = "Menu";

			this.Children.Add (new InicialPage () {
				Title = "Home",
				Icon = "home.png"
			});

			this.Children.Add (new SobrePage () {
				Title = "Sobre",
				Icon = "sobre.png"
			});

			this.Children.Add (new CursosPage () {
				Title = "Cursos",
				Icon = "lista.png"
			});

			this.Children.Add (new MapaPage () {
				Title = "Mapa",
				Icon = "mapa.png"
			});
		}
	}
}

