using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class IngresarProductosDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;

		private bool checkbox=false;

		private bool checkbox2=true;

		public List<FamiliaProducto> productos = new List<FamiliaProducto>();
		
		private Gtk.ListStore productosmodel;


		
		// The event. Note that by using the generic EventHandler<T> event type
		// we do not need to declare a separate delegate type.
		public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;

		public IngresarProductosDialog(Gtk.Window parent) : base ("Ingresar Productos", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();

			this.db = new ControladorBaseDatos();
			bool correcta = false;
			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			}
			catch (Exception ex)
			{
				correcta = false;
			}
			if (!correcta)
			{
				//mostrar dialog configuracion
				basedatosdialog bdd = new basedatosdialog(this);
				bdd.Run();
				this.db = null;
				this.db = new ControladorBaseDatos();
				
				correcta = false;
				
				try {
					correcta = this.db.ConfiguracionCorrectaBd;
				}
				catch (Exception ex)
				{
					correcta = false;
				}
				
				if(!correcta)
				{
					Application.Quit();
				}
			}
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;

		}
		
		public void  Run () 
		{
	
			this.CargarTiposFamiliaCombobox();
//			this.CargarProductos();

			base.Run();
			
		}
		
	/*	public void CargarProductos()
		{
			this.productos = this.db.ObtenerProductosBd();
			this.productosmodel = new Gtk.ListStore(typeof(string));
			foreach (Producto prod in this.productos)
			{
				this.productosmodel.AppendValues( prod.Nombre);
			}
		}*/

		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{

#if DEBUG
				Console.WriteLine(e.ToString());
#endif
				Dialog dialog = new Dialog("OK", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Se ha cargado con exito.";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				
				dialog.Run ();
				dialog.Destroy ();
				
		
			
		}
		public void CargarTiposFamiliaCombobox()
		{

			List<FamiliaProducto> tipos = this.db.ObtenerFamiliasBd();
			combobox4.Clear();
			CellRendererText cell = new CellRendererText();
			combobox4.PackStart(cell, false);
			combobox4.AddAttribute(cell, "text", 0);
			this.productosmodel = new Gtk.ListStore(typeof (string));
			combobox4.Model = productosmodel;
			foreach (FamiliaProducto tp in tipos)
			{
				this.productosmodel.AppendValues(tp.Nombre);
				
			}
			if (tipos.Count != 0)
			{
				this.combobox4.Active = 0;
			}
		}


		protected void OnBotonAgregarPClicked (object sender, EventArgs e)
		{
			bool existe= this.db.ExisteRegistroProductosBd(Int32.Parse(entry12.Text.Trim()));

			if (existe)	{
				Dialog dialog = new Dialog("PRODUCTO YA EXISTE", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "El Producto que intenta agregar ya existe en la Base de Datos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
			    dialog.ShowAll();		
			 	dialog.Run ();
				dialog.Destroy ();
		}
		else
		{
				Producto prod = new Producto(Int32.Parse(entry12.Text.Trim()),entry16.Text.Trim(),Int32.Parse(entry13.Text.Trim()),combobox4.ActiveText, checkbox,checkbox2);

				this.db.AgregarProductosBd(prod);
				
				//this.productosmodel.AppendValues(prod.Nombre);
				//this.cambiado = true;

				Console.WriteLine("agrego producto");

				Dialog dialog = new Dialog("PRODUCTO INGRESADO", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "El Producto ha sido ingresado a la Base de Datos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				
				}
		
		
	}
	
		protected void OnCheckbutton7Toggled (object sender, EventArgs e)
		{
			if(checkbutton7.Active)
			{
			
				checkbox=true;
			}
			else
			{
			
				checkbox=false;

			}		}
		protected void OnCheckbutton8Toggled (object sender, EventArgs e)
		{
			if(checkbutton8.Active)
			{
		
				checkbox2=true;
			}
			else
			{
		
				checkbox2=false;

			}		}
		protected void OnButton65Clicked (object sender, EventArgs e)
		{

			ControladorBaseDatos bd = new ControladorBaseDatos();


			Console.WriteLine("precio: "+bd.ObtenerProductosBd(Int32.Parse(entry1.Text)));

/*			productos = this.db.ObtenerProductosBd(Int32.Parse(entry1.Text.Trim()));
			productosmodel = new Gtk.ListStore(typeof(int),typeof(string),typeof(int),typeof(string),typeof(bool),typeof(bool));
			foreach (Producto prod in this.productos)
			{
				this.productosmodel.AppendValues( prod.Codigobarra,prod.Nombre,prod.Precioventa,prod.Familia,prod.Pesable,prod.Vigente);
			}

			Gtk.TreeIter iter;
#if DEBUG					
			Console.WriteLine("kldao");
#endif

			Producto registro_viejo = new Producto(Int32.Parse(this.productosmodel.GetValue(iter,0).ToString()),
			                                        this.productosmodel.GetValue(iter,1).ToString(),
			                                       Int32.Parse(this.productosmodel.GetValue(iter,3).ToString()),
			                                        this.productosmodel.GetValue(iter,4).ToString(),
			                                                                           false,false);
			

			Producto registro_nuevo = new Producto(Int32.Parse(this.productosmodel.GetValue(iter,0).ToString()),
			                                       this.productosmodel.GetValue(iter,1).ToString(),
			                                       this.entry18.Text.Trim(),
			                                       this.productosmodel.GetValue(iter,4).ToString(),
													true,        false);
*/
		}
}
	}

	



