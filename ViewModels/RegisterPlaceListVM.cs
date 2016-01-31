using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MInhaRotina
{
	public class RegisterPlaceListVM : BaseVM
	{

		ListView resgisterPlaceViewList = new ListView();


		public RegisterPlaceListVM ()
		{
			resgisterPlaceViewList.ItemsSource = new TodoItemDatabase ().GetItems ().ToList ();
		}
	}
}

