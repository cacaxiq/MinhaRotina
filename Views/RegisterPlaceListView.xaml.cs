using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class RegisterPlaceListView : ContentPage
	{
		public RegisterPlaceListView ()
		{
			InitializeComponent ();
			Xamarin.Insights.Track ("Tela Visitada: RegisterPlaceListView");

			BindingContext = new RegisterPlaceListVM (this);
		}
	}
}

