using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.Geolocator;

namespace MInhaRotina.Droid
{
	[Activity (Label = "MInhaRotina.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			Xamarin.Insights.Initialize (global::MInhaRotina.Droid.XamarinInsights.ApiKey, this);
			base.OnCreate (bundle);
			global::Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init(this, bundle);

			LoadApplication (new App ());
		}
	}
}
