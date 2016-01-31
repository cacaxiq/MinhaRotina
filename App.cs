using System;

using Xamarin.Forms;
using System.Linq;

namespace MInhaRotina
{
	public class App : Application
	{
		public App ()
		{
			try {
				Xamarin.Insights.Track ("App Incializado");
				// The root page of your application
				MainPage = new NavigationPage (new LoginView ());
				// throw new Exception ("Testando Telemetria");
			} catch (Exception ex) {
				Xamarin.Insights.Report (ex, Xamarin.Insights.Severity.Error);
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

