using System;
using UIKit;
using System.Drawing;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;

namespace AzureExamenUri
{
	public partial class ViewController : UIViewController
	{
		public async Task Authenticate(UIViewController View)
		{
			try
			{
				user = await AppDelegate.MobileService.
				LoginAsync(View, MobileServiceAuthenticationProvider.MicrosoftAccount);
				Console.Write("Conectado Correctamente");
			}
			catch (Exception ex)
			{
				Console.Write("Error :( {0}", ex.Message);
				Console.Write("PUTO ERROR DE MIERDA!");
			}
		}

		private MobileServiceUser user;
		public MobileServiceUser User { get { return user; }}
		string nombre, domicilio, correo, edad;
		double saldo;
		UIAlertView Mensaje = new UIAlertView();

		public async Task LoginAndGetData(UIViewController view)
		{
			await Authenticate(view);
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			btnGuardar.TouchUpInside += async delegate 
			{
				Mensaje.Title = "Guardar En Azure";
				Mensaje.AddButton("Aceptar");
				Mensaje.Show();
				try
				{
					nombre = txtNombre.Text;
					domicilio = txtDomicilio.Text;
					correo = txtCorreo.Text;
					edad = txtEdad.Text;
					saldo = double.Parse(txtSaldo.Text);
					CurrentPlatform.Init();
					Dineros datos = new Dineros
					{
						Nombre = nombre,
						Domicilio = domicilio,
						Correo = correo,
						Edad = edad,
						Saldo = saldo,
					}; 
					await AppDelegate.MobileService.GetTable<Dineros>().InsertAsync(datos);
					{ 
						Mensaje.Message = "Guardado En Azure Correctamente";
						Mensaje.Show();
					}

				}
				catch (Exception ex)
				{
					Mensaje.Message = ex.Message;
				}
			};
		}

	}
}
