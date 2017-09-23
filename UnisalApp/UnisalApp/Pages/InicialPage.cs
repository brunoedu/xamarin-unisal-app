using System;

namespace UnisalApp
{
	public class InicialPage : ContentPage
	{
		public InicialPage ()
		{
			var textoinicial = new Label {
				FontSize  = Device.GetNamedSize(NamedSize.Large, t),
				FontAttributes = FontAttributes.Bold,
				Text = "Bem Vindos ao Unisal - Lorena"
			};
		}
	}
}

