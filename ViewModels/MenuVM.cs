using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace MInhaRotina
{
	public class MenuVM : BaseVM
	{
		public MenuVM (Page mypage) : base (mypage)
		{
			RegisterPlace = new Command (() => {
				MyPage.Navigation.PushAsync (new RegisterPlaceView ());
			});


			Dashboard = new Command (() => {
				MyPage.Navigation.PushAsync (new DashboardView ());
			});
		}

		public MenuVM ()
		{
			
		}

		public ICommand RegisterPlace {
			get;
			protected set;
		}		

		public ICommand Dashboard {
			get;
			protected set;
		}
	}
}

