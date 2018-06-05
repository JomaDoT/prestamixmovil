using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prestamixmovil
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

       
		}

     async   void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioentry.Text) || string.IsNullOrEmpty(passwordentry.Text))
            { resultadologin.Text = "Debe de ingresar un usuario y contraseña"; }
            else
            {
                resultadologin.Text = "Login exitoso";
                await Navigation.PushAsync(new menuprincipal());
            }
        }
    }
}
