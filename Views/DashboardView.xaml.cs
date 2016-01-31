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

			BindingContext = new DashboardVM ();
		}
	}
}

