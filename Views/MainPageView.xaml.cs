using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class MainPageView : ContentPage
	{
		public MainPageView ()
		{
			InitializeComponent ();
			Xamarin.Insights.Track ("Tela Visitada: MainPageView");

		}
	}
}

