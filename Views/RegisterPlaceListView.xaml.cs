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

			BindingContext = new RegisterPlaceListVM ();
		}
	}
}

