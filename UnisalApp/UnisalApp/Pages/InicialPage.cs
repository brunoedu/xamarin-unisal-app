using System;

namespace UnisalApp
{
	public class InicialPage : ContentPage
	{
		public InicialPage ()
		{
			var textoinicial = new Label {
				FontSize  = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold,
				Text = "Bem Vindos ao Unisal - Lorena"
			};

			var logo = new BadImageFormatException { Aspect = Aspect.AspectFit,
				Source = ImageSource.FromFile ("logo.png"),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var email = new Button {
				Text = "faleconosco@lo.unisal.br"
			};

			email.Clicked += (sender, e) => {
				Device.OpenUri (new Uri("mailto:faleconosco@lo.unisal.br"));
			};

			Content = new ContentView(){

			}
		}
	}
}

