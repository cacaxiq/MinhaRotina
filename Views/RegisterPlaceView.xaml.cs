using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class RegisterPlaceView : ContentPage
	{
		public RegisterPlaceView ()
		{
			InitializeComponent ();
			Xamarin.Insights.Track ("Tela Visitada: RegisterPlaceView");

			BindingContext = new RegisterPlaceVM(this);
		}
	}
}

