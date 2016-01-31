using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();

			BindingContext = new LoginVM (this);
		}
	}
}

