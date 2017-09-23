using System;

namespace UnisalApp
{
	public class CursosPage
	{
		public CursosPage ()
		{
			Title = "Cursos";

			var lista = new ListView ();

			lista.ItemTapped += (sender, e) =>{
				DisplayAlert("Curso", (string)((ListView)sender).SelectedItem, "Ok");
					((ListView)sender).SelectedItem = null;
			};

			Content = lista;
		}
	}
}

