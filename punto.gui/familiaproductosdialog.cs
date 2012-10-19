using System;
using System.Collections.Generic;
using Gtk;
using punto.code;
namespace punto.gui
{
	public partial class familiaproductosdialog : Gtk.Dialog
	{

		private basedatos db;
		
		public List<familiap> familias = new List<familiap>();
		
		private Gtk.ListStore bodegasmodel;
		
		// The event. Note that by using the generic EventHandler<T> event type
		// we do not need to declare a separate delegate type.
		public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;
		
		public familiaproductosdialog (Gtk.Window parent) : base ("Administrar familia", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			
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
			
		
			
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText();
			nombre_column.PackStart(nombre_cell, true);
			this.familiaplantastreeview.AppendColumn(nombre_column);
			nombre_column.AddAttribute(nombre_cell, "text", 0);
			
			this.familiaplantastreeview.Selection.Changed += OnFamiliasTreeViewSelectionChanged;
			
			//cargar emsefor desde la base de datos
			//this.CargarEmsefor();
			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
	}
		
		public void Destroy ()
		{
#if DEBUG
			Console.WriteLine("Destroy");
#endif
			GLib.ExceptionManager.UnhandledException -= ExcepcionDesconocida;
			EdicionDialogChangedEventArgs args = new EdicionDialogChangedEventArgs(this.cambiado);
			//this.OnEdicionDialogChanged(args);
			base.Destroy();
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
		public void  Run () 
		{
			this.CargarFamilias();
			base.Run();
			
		}


		public void CargarFamilias()
		{
			this.familias = this.db.ObtenerFamilias();
			this.bodegasmodel = new Gtk.ListStore(typeof(string));
			foreach (familiap bod in this.familias)
			{
				this.bodegasmodel.AppendValues( bod.Nombre);
			}
			familiaplantastreeview.Model = this.bodegasmodel;
			
			//desactivar botones
			//desactivar botones
			actualizar_button.Sensitive = true;
		}
		protected void OnFamiliasTreeViewSelectionChanged (object sender, EventArgs args)
		{	
			Gtk.TreeIter iter;
			if (this.familiaplantastreeview.Selection.GetSelected(out iter))
			{
				this.entry.Text = this.bodegasmodel.GetValue(iter, 0).ToString();
				agregar_button.Sensitive = true;

				this.actualizar_button.Sensitive = true;
			}
			else
			{
				this.actualizar_button.Sensitive = false;
			}
		}

		protected virtual void OnAgregarButtonClicked (object sender, System.EventArgs e)
		{
			familiap bod = new familiap(this.entry.Text.Trim());
//			familiap bod = new familiap("leña");

			if (this.db.ExisteFamilia(bod))
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
				if (this.db.AgregarFamilia(bod))
				{
					this.familias.Add(bod);
					this.bodegasmodel.AppendValues(bod.Nombre);
					
					this.entry.Text = "";
					this.familiaplantastreeview.Selection.UnselectAll();
					this.agregar_button.Sensitive = false;
					//Console.WriteLine("Agregado");
					agregar_button.Sensitive = true;

					this.cambiado = true;
				}
				else
				{
					Dialog dialog = new Dialog("No se pudo agregar la bodega", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label();
					etiqueta.Markup = "No se pudo agregar la bodega, ha ocurrido un error al agregarla a la base de datos.";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart(etiqueta, false, false, 0);
					dialog.AddButton ("Cerrar", ResponseType.Close);
					dialog.ShowAll();
					dialog.Run ();
					dialog.Destroy ();
					agregar_button.Sensitive = true;

				}
			}

		}

		protected void OnActualizarButtonClicked (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}
}
}

