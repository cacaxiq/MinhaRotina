using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class DashboardView : ContentPage
	{
		public DashboardView ()
		{
			InitializeComponent ();
			Xamarin.Insights.Track ("Tela Visitada: DashboardView");

			BindingContext = new DashboardVM (this);
		}
	}
}

