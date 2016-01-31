using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MInhaRotina
{
	public partial class MenuView : ContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();

			BindingContext = new MenuVM (this);
		}
	}
}

