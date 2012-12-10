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
			bool existe= this.db.ExisteRegistroProductosBd(entry12.Text.Trim());

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
				Producto prod = new Producto(entry12.Text.Trim(),entry16.Text.Trim(),Int32.Parse(entry13.Text.Trim()),combobox4.ActiveText, checkbox,checkbox2);

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
		protected void OnCheckbutton9Toggled (object sender, EventArgs e)
		{
			if(checkbutton9.Active)
			{
		
				vigente="True";
			}
			else
			{
		
				vigente="False";

			}		}
		protected void OnButton65Clicked (object sender, EventArgs e)
		{

			ControladorBaseDatos bd = new ControladorBaseDatos ();


			//Console.WriteLine("precio: "+bd.ObtenerProductosBd(Int32.Parse(entry1.Text)));
			string[] preciovigente = new string[1];
			preciovigente = bd.ObtenerProductosBd (entry1.Text);
			Console.WriteLine ("precio: " + preciovigente [1]);
			entry18.Text = preciovigente [0];
			if (preciovigente [1] == "True") {
				checkbutton9.Visible = true;
				checkbutton9.Sensitive = true;
				checkbutton9.Active = true;
			} else {
				checkbutton9.Active = false;

			}
			if(!(bd.ExisteRegistroProductosBd(entry1.Text.Trim()))){

				Dialog dialog = new Dialog("PRODUCTO NO EXISTE", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "No existe este producto en la Base de Datos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
		
			}
			//Console.WriteLine("vigente: "+preciovigente[1]);
	//		entry18.Text=bd.ObtenerProductosBd(Int32.Parse(entry1.Text));

		}

		protected void OnBotonAgregarP1Clicked (object sender, EventArgs e)
		{
		
			ControladorBaseDatos bd = new ControladorBaseDatos ();
			
			
			bd.ActualizarProductoBd (entry1.Text,Int32.Parse (entry18.Text),vigente);

			Dialog dialog = new Dialog("PRODUCTO ACTUALIZADO", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label();
			etiqueta.Markup = "Se han guardado correctamente los cambios";
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart(etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll();
			dialog.Run ();
			dialog.Destroy ();
		
		}
		string vigente;

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
}
	}

	



