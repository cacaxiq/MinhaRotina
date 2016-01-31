using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Plugin.Geolocator;
using System.Threading.Tasks;


namespace MInhaRotina
{
	public class RegisterPlaceVM : BaseVM
	{
		public RegisterPlaceVM ()
		{
			
		}
		public Place Place { get; set; }

		public ICommand SavePlace {
			get;
			protected set;
		}

		public RegisterPlaceVM (Page mypage) : base (mypage)
		{
			Place = new Place ();

			SavePlace = new Command (() => {
				InsertPlace ();
			});

			Local ();

		}

		protected async Task Local ()
		{
			var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50;

			var position = await locator.GetPositionAsync (timeoutMilliseconds: 10000);

			if (position == null) {
				Xamarin.Insights.Report (new Exception("Falha obtencao posicao!"),Xamarin.Insights.Severity.Warning);
			}

			Device.BeginInvokeOnMainThread (() => {
				this.Localization = string.Format ("{0} - {1} - {2}", position.Timestamp, position.Latitude, position.Longitude);
				Place.Latitude = position.Latitude;
				Place.Longitude = position.Longitude;
			});
		}

		protected void InsertPlace ()
		{
			var banco = new TodoItemDatabase ();
			var item = new TodoItem {
				Description = Place.Description,
				Latitude = Place.Latitude,
				Longitude = Place.Longitude
			};

			try {
				var id = banco.SaveItem (item);
				MyPage.Navigation.PopAsync();
			} catch (Exception ex) {
				Xamarin.Insights.Report (ex,Xamarin.Insights.Severity.Critical);
			}
	
		}

		public string Description {
			get{ return this.Place.Description; }
			set {
				if (this.Place.Description != value) {
					this.Place.Description = value;
					OnPropChange ("Description");
				}
			}
		}

		public string Localization {
			get{ return this.Place.Localization; }
			set {
				if (this.Place.Localization != value) {
					this.Place.Localization = value;
					OnPropChange ("Localization");
				}
			}
		}
	}
}

