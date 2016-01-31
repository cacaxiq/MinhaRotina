using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MInhaRotina
{
	public class LoginVM : BaseVM
	{
		public LoginVM (Page mypage) : base (mypage)
		{
			Login = new Login ();

			LoginValidate = new Command (() => {
				Validate ();
			});
		}

		public Login Login {
			get;
			set;
		}

		public ICommand LoginValidate {
			get;
			protected set;
		}

		protected void Validate ()
		{
			if (Login.Password == Login.PasswordCorrect) {
				MyPage.Navigation.PushAsync (new MenuView ());
			} else {
				MyPage.DisplayAlert ("Atençao", "Senha Incorreta!!!", "Tentar Novamente!!!");
			}
		}

		public string Nickname {
			get{ return this.Login.Nickname; }
			set {
				if (this.Login.Nickname != value) {
					this.Login.Nickname = value;
					OnPropChange ("Nickname");
				}
			}
		}

		public string Password {
			get{ return this.Login.Password; }
			set {
				if (this.Login.Password != value) {
					this.Login.Password = value;
					OnPropChange ("Password");
				}
			}
		}
	}
}

