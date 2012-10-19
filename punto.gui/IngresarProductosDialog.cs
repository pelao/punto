using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class IngresarProductosDialog : Gtk.Dialog
	{
		private basedatos db;

		private bool checkbox=false;

		private bool checkbox2=false;

		public List<familiap> productos = new List<familiap>();
		
		private Gtk.ListStore productosmodel;


		
		// The event. Note that by using the generic EventHandler<T> event type
		// we do not need to declare a separate delegate type.
		public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;

		public IngresarProductosDialog(Gtk.Window parent) : base ("Ingresar Productos", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			//this.CargarTiposFamiliaCombobox();
			this.db = new basedatos();
			bool correcta = false;
			try {
				correcta = this.db.ConfiguracionCorrecta;
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
				this.db = new basedatos();
				
				correcta = false;
				
				try {
					correcta = this.db.ConfiguracionCorrecta;
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
			//this.CargarProducciones(0,0,true);
	
			this.CargarTiposFamiliaCombobox();

			base.Run();
			
		}
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
				
				//this.Destroy();
			
		}
		public void CargarTiposFamiliaCombobox()
		{
			/*Gtk.TreeIter iter;
			this.combobox3.GetActiveIter(out iter);
			string texto_activo = "";
			if (this.tiposplantasmodel != null) 
			{
				texto_activo = this.tiposplantasmodel.GetValue(iter,0).ToString();
			}*/ 
			List<familiap> tipos = this.db.ObtenerFamilias();
			combobox4.Clear();
			CellRendererText cell = new CellRendererText();
			combobox4.PackStart(cell, false);
			combobox4.AddAttribute(cell, "text", 0);
			this.productosmodel = new Gtk.ListStore(typeof (string));
			combobox4.Model = productosmodel;
			
			foreach (familiap tp in tipos)
			{
				this.productosmodel.AppendValues(tp.Nombre);
				
			}
			if (tipos.Count != 0)
			{
				this.combobox4.Active = 0;
			}
		}


		protected void OnBotonAgregarPClicked (object sender, EventArgs e){
			producto bod = new producto(Int32.Parse(entry12.Text.Trim()),entry16.Text.Trim(),Int32.Parse(entry13.Text.Trim()),combobox4.ActiveText, checkbox,checkbox2);

		
		if (this.db.ExisteRegistroProductos(bod,true))
		{
				Dialog dialog = new Dialog("OK", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "No se pudo agregar la bodega porque ya existe una con el mismo código.\nIntente agregar uno diferente.";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
			//dialog.ShowAll;		
			//	dialog.Run ();
			//	dialog.Destroy ();
		}
		else
		{
			if (this.db.AgregarProductos(bod))
			{
		//		this.productos.Add(bod);
				this.productosmodel.AppendValues(bod.Nombre);
				
				
				this.cambiado = true;
			}
			else
			{
				Dialog dialog = new Dialog("Ok", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "se agrego con exito";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				
			}
		}
		
	}
	
		protected void OnCheckbutton7Toggled (object sender, EventArgs e)
		{
			if(checkbutton7.Active)
			{
				//checkbutton7.Sensitive = true;
				checkbox=true;
			}
			else
			{
				//checkbutton7.Sensitive = false;
				checkbox=false;

			}		}
		protected void OnCheckbutton8Toggled (object sender, EventArgs e)
		{
			if(checkbutton8.Active)
			{
				//checkbutton7.Sensitive = true;
				checkbox=true;
			}
			else
			{
				//checkbutton7.Sensitive = false;
				checkbox=false;
				
			}		}
}
	}

	



