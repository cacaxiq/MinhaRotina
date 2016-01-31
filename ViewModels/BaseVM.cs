using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MInhaRotina
{
	public class BaseVM : INotifyPropertyChanged
	{
		public Page MyPage {
			get;
			set;
		}
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		public virtual void OnPropChange (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}

		public BaseVM ()
		{
		}
		public BaseVM (Page Mypage)
		{
			MyPage = Mypage;
		}
	}
}

