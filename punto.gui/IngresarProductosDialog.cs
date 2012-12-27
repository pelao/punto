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

		public List<ModificarProducto> productos = new List<ModificarProducto>();
		
		private Gtk.ListStore productosmodel;



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
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText();
			nombre_column.PackStart(nombre_cell, true);
			
			Gtk.TreeViewColumn precio_column = new Gtk.TreeViewColumn();
			precio_column.Title = "Precio";
			Gtk.CellRendererText precio_cell = new Gtk.CellRendererText();
			precio_column.PackStart(precio_cell, true);
			
				

			Gtk.TreeViewColumn familia_column = new Gtk.TreeViewColumn();
			familia_column.Title = "Familia";
			Gtk.CellRendererText familia_cell = new Gtk.CellRendererText();
			familia_column.PackStart(familia_cell, true);
		

			Gtk.TreeViewColumn vigente_column = new Gtk.TreeViewColumn();
			vigente_column.Title = "Vigente";
			Gtk.CellRendererText vigente_cell = new Gtk.CellRendererText();
			vigente_column.PackStart(vigente_cell, true);
			
			this.treeviewModificarProducto.AppendColumn(nombre_column);
			nombre_column.AddAttribute(nombre_cell, "text", 0);
			this.treeviewModificarProducto.AppendColumn(precio_column);
			precio_column.AddAttribute(precio_cell, "text", 1);
			this.treeviewModificarProducto.AppendColumn(familia_column);
			familia_column.AddAttribute(familia_cell, "text", 2);
			this.treeviewModificarProducto.AppendColumn(vigente_column);
			vigente_column.AddAttribute(vigente_cell, "text", 3);
		}
		
		public void  Run () 
		{
	
			this.CargarTiposFamiliaCombobox();
			this.CargarProductos();

			base.Run();
			
		}
		public void CargarProductos ()
		{
			this.productos = this.db.ObtenerProductosBd ();
			this.productosmodel = new Gtk.ListStore ( typeof(string), typeof(string), typeof(string));
			foreach (ModificarProducto bod in this.productos) {
			this.productosmodel.AppendValues (bod.Nombre, bod.Precio,bod.Familia);

		}
			treeviewModificarProducto.Model = this.productosmodel;
			
		}


		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{

			Dialog dialog = new Dialog("OK", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label();
			etiqueta.Markup = "Se ha producido un error.";
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
			comboboxFamiliaProd.Clear();
			CellRendererText cell = new CellRendererText();
			comboboxFamiliaProd.PackStart(cell, false);
			comboboxFamiliaProd.AddAttribute(cell, "text", 0);
			this.productosmodel = new Gtk.ListStore(typeof (string));
			comboboxFamiliaProd.Model = productosmodel;
			foreach (FamiliaProducto tp in tipos)
			{
				this.productosmodel.AppendValues(tp.Nombre);
				
			}
			if (tipos.Count != 0)
			{
				this.comboboxFamiliaProd.Active = 0;
			}
		}


		protected void OnBotonAgregarPClicked (object sender, EventArgs e)
		{
			bool existe= this.db.ExisteRegistroProductosBd(entryCodigoBarra.Text.Trim());

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
				Producto prod = new Producto(entryCodigoBarra.Text.Trim(),entryNombre.Text.Trim(),Int32.Parse(entryPrecioVenta.Text.Trim()),comboboxFamiliaProd.ActiveText, checkbox,checkbox2);

				this.db.AgregarProductosBd(prod);

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
			if(checkbuttonPesable.Active)
			{
			
				checkbox=true;
			}
			else
			{
			
				checkbox=false;

			}	
		}
	

		protected void OnCheckbutton8Toggled (object sender, EventArgs e)
		{
			if(checkbuttonVigente.Active)
			{
				
				checkbox2=true;
			}
			else
			{
				
				checkbox2=false;
				
			}		}

		string nomA="";
		string fami="";
	
		protected void OnEditarEspecificacion ()
		{

			Gtk.TreeIter iter;
			if (treeviewModificarProducto.Selection.GetSelected (out iter)) {
				string nombre, precio,familia;
				nombre = productosmodel.GetValue (iter, 0).ToString ();
				precio = productosmodel.GetValue (iter, 1).ToString ();
				familia = productosmodel.GetValue (iter, 2).ToString ();

				nomA =nombre;
				fami=familia;
				EditarProductoDialog esp = new EditarProductoDialog (this, nombre, precio,familia);
				esp.EditarProductoDialogdChanged += OnEditarEspecificacionDialogOldChanged;
				esp.Run ();
			}
		}

		protected void OnEditarEspecificacionDialogOldChanged (object sender, EditarProductoDialogChangedEventArgs args)
		{
			Gtk.TreeIter iter;
			if (treeviewModificarProducto.Selection.GetSelected(out iter))
			{
				productosmodel.SetValue(iter, 0, args.Nombre);
				productosmodel.SetValue(iter, 1, args.Precio);
				productosmodel.SetValue(iter, 2, args.Familia);

				this.db.ActualizarProductoBd(nomA,args.Nombre, args.Precio,args.Familia);	
			}
		}

		protected void OnBotonEditarClicked (object sender, EventArgs e)
		{
			this.OnEditarEspecificacion();
		}

	

		protected void BotonCancelar (object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}

		protected void OnLabelModificarProductoMoveCursor (object o, MoveCursorArgs args)
		{
			this.CargarProductos();
		}

		protected void OnLabelModificarProductoKeyPressEvent (object o, KeyPressEventArgs args)
		{
			this.CargarProductos();
		}
	}
}

	



