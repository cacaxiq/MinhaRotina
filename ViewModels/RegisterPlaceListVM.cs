using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace MInhaRotina
{
	public class RegisterPlaceListVM : BaseVM
	{

		public List<TodoItem> listaPlaces {
			get;
			set;
		}

		public ICommand InsertPlace {
			get;
			protected set;
		}

		public RegisterPlaceListVM (Page mypage) : base (mypage)
		{
			listaPlaces = new TodoItemDatabase ().GetItems ().ToList ();

			InsertPlace = new Command (() => {
				MyPage.Navigation.PushAsync (new RegisterPlaceView ());
			});
		}
	}
}

