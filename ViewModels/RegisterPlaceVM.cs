using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace MInhaRotina
{
	public class RegisterPlaceVM : INotifyPropertyChanged  
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		public virtual void OnPropChange(string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public Place Place { get; set; }

		public ICommand SavePlace {
			get;
			protected set;
		}

		public RegisterPlaceVM ()
		{
			Place = new Place ();

			SavePlace = new Command(()=>{
				InsertPlace();
			});

		}

		protected void InsertPlace(){
			var teste = "222";
		}

		public string Description {
			get{return this.Place.Description;}
			set{ if (this.Place.Description != value) {
					this.Place.Description = value;
					OnPropChange("Description");
				}}
		}

		public string Localization {
			get{return this.Place.Localization;}
			set{ if (this.Place.Localization != value) {
					this.Place.Localization = value;
					OnPropChange("Localization");
				}}
		}
	}
}

