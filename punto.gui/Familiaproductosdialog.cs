using System;
using System.Collections.Generic;
using Gtk;
using punto.code;
namespace punto.gui
{
	public partial class familiaproductosdialog : Gtk.Dialog
	{

		private ControladorBaseDatos db;
		
		public List<FamiliaProducto> familias = new List<FamiliaProducto>();
		
		private Gtk.ListStore familiaModel;
		

	//	public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;
		
		public familiaproductosdialog (Gtk.Window parent) : base ("Administrar familia", parent, Gtk.DialogFlags.DestroyWithParent)
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
			
		
			
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText();
			nombre_column.PackStart(nombre_cell, true);
			this.FamiliaProductosTreeview.AppendColumn(nombre_column);
			nombre_column.AddAttribute(nombre_cell, "text", 0);
			
			this.FamiliaProductosTreeview.Selection.Changed += OnFamiliasTreeViewSelectionChanged;

			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
	}
		
		public void Destroy ()
		{
#if DEBUG
			Console.WriteLine("Destroy");
#endif
			GLib.ExceptionManager.UnhandledException -= ExcepcionDesconocida;
		//	EdicionDialogChangedEventArgs args = new EdicionDialogChangedEventArgs(this.cambiado);
		
			base.Destroy();
		}
		
		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{
#if DEBUG
			Console.WriteLine(e.ToString());
#endif
			Dialog dialog = new Dialog("Excepcion", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label();
			etiqueta.Markup = "Ha ocurrido un error.";
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart(etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll();

			dialog.Run ();
			dialog.Destroy ();
			
		
		}
		public void  Run () 
		{
			this.CargarFamilias();
			base.Run();
			
		}


		public void CargarFamilias()
		{
			this.familias = this.db.ObtenerFamiliasBd();
			this.familiaModel = new Gtk.ListStore(typeof(string));
			foreach (FamiliaProducto prod in this.familias)
			{
				this.familiaModel.AppendValues( prod.Nombre);
			}
			FamiliaProductosTreeview.Model = this.familiaModel;
			

		}
		protected void OnFamiliasTreeViewSelectionChanged (object sender, EventArgs args)
		{	
			Gtk.TreeIter iter;
			if (this.FamiliaProductosTreeview.Selection.GetSelected(out iter))
			{
				añadir_button.Sensitive = true;

				this.actualizar_button.Sensitive = true;
			}
			else
			{
				this.actualizar_button.Sensitive = false;
			}
		}

		protected virtual void OnAgregarButtonClicked (object sender, System.EventArgs e)
		{
			FamiliaProducto prod = new FamiliaProducto(this.entryFamilia.Text.Trim());


			if (this.db.ExisteFamiliaBd(prod))
			{
				Dialog dialog = new Dialog("FAMILIA YA EXISTE", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "La Familia que intenta agregar ya existe en la Base de Datos";
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
				if (this.db.AgregarFamiliaBd(prod))
				{
					this.familias.Add(prod);
					this.familiaModel.AppendValues(prod.Nombre);
					
					this.entryFamilia.Text = "";
					this.FamiliaProductosTreeview.Selection.UnselectAll();
					this.añadir_button.Sensitive = false;
				
					añadir_button.Sensitive = true;

					this.cambiado = true;
				}
				else
				{
					Dialog dialog = new Dialog("ERROR AL AGREGAR FAMILIA", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label();
					etiqueta.Markup = "Ha ocurrido un error al agregar la Familia a la Base de Datos";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart(etiqueta, false, false, 0);
					dialog.AddButton ("Cerrar", ResponseType.Close);
					dialog.ShowAll();
					dialog.Run ();
					dialog.Destroy ();
					añadir_button.Sensitive = true;

				}
			}

		}

		protected virtual void OnActualizarButtonClicked (object sender, System.EventArgs e)
		{
			Gtk.TreeIter iter;
			this.FamiliaProductosTreeview.Selection.GetSelected(out iter);
			
			FamiliaProducto familia_vieja = new FamiliaProducto(this.familiaModel.GetValue(iter, 0).ToString());
			FamiliaProducto familia_nueva = new FamiliaProducto(entryFamilia.Text.Trim());
			
			if (!this.db.ExisteFamiliaBd(familia_vieja))
			{
				Dialog dialog = new Dialog("No se pudo actualizar la familia", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "No se pudo actualizar la familia porque no existe una en la base de datos.\nIntente recargar la lista de familias.";
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
				if (this.db.ActualizarFamilia(familia_vieja, familia_nueva))
				{
					this.familias.RemoveAt(this.familiaModel.GetPath(iter).Indices[0]);
					this.familias.Insert(this.familiaModel.GetPath(iter).Indices[0], familia_nueva);
					
					this.familiaModel.SetValue(iter, 0, familia_nueva.Nombre);

					this.entryFamilia.Text = "";
					this.quitar_button.Sensitive = false;
					this.actualizar_button.Sensitive = false;
					this.FamiliaProductosTreeview.Selection.UnselectAll();
					//Console.WriteLine("Actualizado");
					
					this.cambiado = true;
				}
				else
				{
					Dialog dialog = new Dialog("No se pudo actualizar la familia", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label();
					etiqueta.Markup = "No se pudo actualizar la familia, ha ocurrido un error al actualizar en la base de datos.";
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

		protected void OnQuitarButtonClicked (object sender, EventArgs e)
		{

			Gtk.TreeIter iter;
			if (this.FamiliaProductosTreeview.Selection.GetSelected(out iter))
			{
				//especificacionesmodel.GetValue(iter,0).ToString();
				Dialog dialog = new Dialog("Quitar familia", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Está intentando quitar la familia seleccionada de la lista.\n\n<b>¿Desea continuar con la eliminación de la familia?</b>\n";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Si", ResponseType.Accept);
				dialog.AddButton ("No", ResponseType.Cancel);
				dialog.Response += new ResponseHandler (OnQuitarFamiliaDialogResponse);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			}
			else
			{
				this.actualizar_button.Sensitive = false;
			}
		
		}
		private void OnQuitarFamiliaDialogResponse (object sender, ResponseArgs args)
		{
			switch (args.ResponseId)
			{
			case ResponseType.Accept:
				Gtk.TreeIter iter;
				this.FamiliaProductosTreeview.Selection.GetSelected(out iter);
				
				FamiliaProducto bod = new FamiliaProducto(this.familiaModel.GetValue(iter, 0).ToString());
				
				if (!this.db.ExisteFamiliaBd(bod))
				{
					Dialog dialog = new Dialog("No se pudo quitar la familia", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label();
					etiqueta.Markup = "No se pudo quitar la familia porque no existe en la base de datos.\nIntente recargar la lista de familias.";
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
					if (this.db.QuitarFamilia(bod))
					{
#if DEBUG
						Console.WriteLine(this.familias.Count);	
#endif
						this.familias.RemoveAt(this.familiaModel.GetPath(iter).Indices[0]);
#if DEBUG
						Console.WriteLine(this.familias.Count);	
#endif				
						this.familiaModel.Remove(ref iter);
						
						this.actualizar_button.Sensitive = false;
						this.FamiliaProductosTreeview.Selection.UnselectAll();
						
						this.cambiado = true;
					}
					else
					{
						Dialog dialog = new Dialog("No se pudo quitar la familia", this, Gtk.DialogFlags.DestroyWithParent);
						dialog.Modal = true;
						dialog.Resizable = false;
						Gtk.Label etiqueta = new Gtk.Label();
						etiqueta.Markup = "No se pudo quitar la familia, ha ocurrido un error al quitarla de la base de datos.";
						dialog.BorderWidth = 8;
						dialog.VBox.BorderWidth = 8;
						dialog.VBox.PackStart(etiqueta, false, false, 0);
						dialog.AddButton ("Cerrar", ResponseType.Close);
						dialog.ShowAll();
						dialog.Run ();
						dialog.Destroy ();
					}
				}
				break;
		    	default:
		
				break;
			}
		}
}
}

