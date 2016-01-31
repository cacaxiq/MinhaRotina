using System;
using Android.App;
using Android.Content;

namespace MInhaRotina.Droid
{
	[Activity(Label = "Minha Rotina", Icon="@drawable/icon", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash")]
	public class SplashScreen: Activity
	{
		public SplashScreen ()
		{
		}

		protected override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			var intent = new Intent (this, typeof(MainActivity));
			StartActivity (intent);
			Finish ();
		}
	}
}

