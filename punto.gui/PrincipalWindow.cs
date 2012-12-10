using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Gtk;

using punto.code;

namespace punto.gui
{
	public class EdicionDialogChangedEventArgs : EventArgs
	{
		private bool cambiado;
		
		public List<DetalleVenta> productoventa = new List<DetalleVenta>();
		private Gtk.ListStore ventamodel;
		
		
		public EdicionDialogChangedEventArgs(bool cam)
		{
			this.cambiado = cam;
		}	
		
		public bool Cambiado
		{
			get { return this.cambiado; }
		}
	}
	public partial class PrincipalWindow : Gtk.Window
	{
		private ControladorBaseDatos db;
		
		public PrincipalWindow () : base(Gtk.WindowType.Toplevel)
		{
#if DEBUG
			Console.WriteLine ("En debug");
#endif
			
			
			this.Build ();
			this.db = new ControladorBaseDatos ();
			bool correcta = false;
			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			} catch (Exception ex) {
				correcta = false;
			}
			if (!correcta) {
				//mostrar dialog configuracion
				basedatosdialog bdd = new basedatosdialog (this);
				bdd.Run ();
				this.db = null;
				this.db = new ControladorBaseDatos ();
				
				correcta = false;
				
				try {
					correcta = this.db.ConfiguracionCorrectaBd;
				} catch (Exception ex) {
					correcta = false;
				}
				
				if (!correcta) {
					Gtk.Application.Quit ();
				}
			}
			
			
			
		}
		
		
		
		protected virtual void OnConexionBaseDatosActivated (object sender, System.EventArgs e)
		{
			//mostrar dialog configuracion
			basedatosdialog bdd = new basedatosdialog(this);
			bdd.Run();
			bdd.Destroy();
			this.db = null;
			this.db = new ControladorBaseDatos();
			
			bool correcta = false;
			
			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			}
			catch (Exception ex)
			{
				correcta = false;
			}
			
			if(!correcta)
			{
				Gtk.Application.Quit();
			}
			
		}
		
		
		protected void OnIngresarModificarProductosActionActivated (object sender, EventArgs e)
		{
			IngresarProductosDialog rcd = new IngresarProductosDialog(this);
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}
		}
		
		protected void OnFamiliaDeProductosActionActivated (object sender, EventArgs e)
		{
			familiaproductosdialog rcd = new familiaproductosdialog(this);
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
#if DEBUG
				
				
				Console.WriteLine(ex.Message);
#endif
			}
		}
		protected void OnButton27Clicked (object sender, EventArgs e)
		{
			VenderProductosDialog rcd = new VenderProductosDialog(this);
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}		
			
		}
		 
		protected void OnIniciarSesionActionActivated (object sender, EventArgs e)
		{

			IniciarSesionDialog rcd = new IniciarSesionDialog();
			
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();


			}
		}

		protected void OnRegistrarModificarUsuarioActionActivated (object sender, EventArgs e)
		{
			RegistrarUsuarioDialog rcd = new RegistrarUsuarioDialog();
			
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
				
				
			}
		}
			/*try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}*/
		 
		
		
		
		protected void OnCerrarActionActivated (object sender, EventArgs e)
		{
			this.Destroy();

			IniciarSesionDialog rcd = new IniciarSesionDialog();
			
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
				
				
			}

		}
	
	}
}
