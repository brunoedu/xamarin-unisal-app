using System;

namespace UnisalApp
{
	public class SobrePage
	{
		public SobrePage ()
		{
			var titulo = new Label {
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold,
				Text = "Histórico"
			};
				
			var historico = new Label {
				FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
				FontAttributes = FontAttributes.Bold,
				Text = "O UNISAL é uma comunidade acadêmica formada por Docentes, Estudantes e pessoal administrativo, que promove de modo rigoroso, crítico e propositivo o desenvolvimento da pessoa humana e do patrimônio cultural da sociedade, mediante a pesquisa, a docência, a formação superior e contínua e os diversos serviços oferecidos às comunidades locais.\n\nA inspiração cristã, a natureza católica e a identidade salesiana do UNISAL supõem uma visão do mundo e da pessoa humana enraizadas e em sintonia com o Evangelho, e uma pedagogia fundamentada sobre os valores do Sistema Preventivo vivido por Dom Bosco.\n\nIsso implica, concretamente: um compromisso de unidade e comunhão com a Igreja; uma opção decidida em favor dos jovens; uma comunidade acadêmica com clara identidade salesiana; um projeto cultural cristão e salesianamente orientado e uma intencionalidade educativo-pastoral.\n\nA integração do conhecimento, o diálogo entre fé e razão, a busca contínua da verdade, a formação ética, o espírito de liberdade na caridade, o respeito recíproco e a promoção dos direitos humanos caracterizam e animam o UNISAL como centro de um saber que dá sabor ao estudo e à pesquisa e favorece a aquisição da verdadeira sabedoria de vida."
			};

			var unisal = new BadImageFormatException { Aspect = Aspect.AspectFit };
			unisal.Source = ImageSource.FormUri (new Uri("http:/unisal.br/wp-content/gallery/lorena_1;2-unisal-lorena.jpg"));

			Content = new ScrollView(){
				Content = new StackLayout(){
					
				}
			}
		}
	}
}

