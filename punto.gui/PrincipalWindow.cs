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

		
	//	public List<DetalleVenta> productoventa = new List<DetalleVenta>();
		
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
		private string usuario_;
		private string nivelUsuario;
		
		public PrincipalWindow (string usuario) : base(Gtk.WindowType.Toplevel)
		{
			this.usuario_ = usuario;

#if DEBUG
			Console.WriteLine ("En debug");
#endif      
		
			
		
			this.Build ();
			this.db = new ControladorBaseDatos ();
			nivelUsuario = this.db.ObtenerNivelUsuarioBd(usuario_);

			if(nivelUsuario.Equals("Cajero"))
			{
				ProductosAction.Visible = false;
				UsuariosAction.Visible = false;
			}

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
			IngresarProductosDialog IngresarProductos = new IngresarProductosDialog(this);
			try 
			{
				IngresarProductos.Run();
				IngresarProductos.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				IngresarProductos.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}
		}
		
		protected void OnFamiliaDeProductosActionActivated (object sender, EventArgs e)
		{
			familiaproductosdialog FamiliaProductos = new familiaproductosdialog(this);
			try 
			{
				FamiliaProductos.Run();
				FamiliaProductos.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				FamiliaProductos.Destroy();
#if DEBUG
				
				
				Console.WriteLine(ex.Message);
#endif
			}
		}
		protected void OnButtonVenderClicked (object sender, EventArgs e)
		{
			VenderProductosDialog VenderProductos = new VenderProductosDialog(this, usuario_);
			try 
			{
				VenderProductos.Run();
				VenderProductos.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				VenderProductos.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}		
			
		}
		 
		protected void OnIniciarSesionActionActivated (object sender, EventArgs e)
		{

			IniciarSesionDialog IniciarSesion = new IniciarSesionDialog();
			
			try 
			{
				IniciarSesion.Run();
				IniciarSesion.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				IniciarSesion.Destroy();


			}
		}

		protected void OnRegistrarModificarUsuarioActionActivated (object sender, EventArgs e)
		{
			RegistrarUsuarioDialog RegistrarUsuario = new RegistrarUsuarioDialog();
			
			try 
			{
				RegistrarUsuario.Run();
				RegistrarUsuario.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				RegistrarUsuario.Destroy();
				
				
			}
		}

		
				
		protected void OnCerrarActionActivated (object sender, EventArgs e)
		{

			this.Destroy();

			IniciarSesionDialog IniciarSesion = new IniciarSesionDialog();
			
			try 
			{
				IniciarSesion.Run();
				IniciarSesion.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				IniciarSesion.Destroy();
				
				
			}

		}
	

		protected void OnConsultarPrecioActionActivated (object sender, EventArgs e)
		{
			ConsultaPrecioDialog ConsultaPrecio = new ConsultaPrecioDialog();
			
			try 
			{
				ConsultaPrecio.Run();
				ConsultaPrecio.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				ConsultaPrecio.Destroy();
								
			}
		}

		protected void OnButtonConsultaPrecioClicked (object sender, EventArgs e)
		{
			ConsultaPrecioDialog ConsultaPrecio = new ConsultaPrecioDialog();
			
			try 
			{
				ConsultaPrecio.Run();
				ConsultaPrecio.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				ConsultaPrecio.Destroy();
				
			}
		}
	}
}
