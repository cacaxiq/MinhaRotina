﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
			Xamarin.Insights.Track ("Tela Visitada: LoginView");

			BindingContext = new LoginVM (this);
		}
	}
}

