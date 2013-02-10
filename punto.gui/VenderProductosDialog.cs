using System.Collections;
using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class VenderProductosDialog : Gtk.Dialog
	{
		public event EventHandler TimeChanged;

		public int CurrentTime;
		private ControladorBaseDatos db;
		public List<Produc> productoventa = new List<Produc> ();
		public List<Produc> productos = new List<Produc> ();
		private Gtk.ListStore ventamodel;
		public List<Produc> listapago = new List<Produc> ();
		private Gtk.ListStore listaventa;
		
		
		//	public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;
		public	int preciototal = 0;
		private string boleta;
		public int cantidad = 1 ;
		public string usuarioLogin;
		
		public VenderProductosDialog (string usuario)
		{
			this.usuarioLogin = usuario;
			this.ventamodel = new Gtk.ListStore (typeof(int), typeof(string), typeof(string));
			
			this.Build ();
			this.db = new ControladorBaseDatos ();
			bool correcta = false;
			
			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			} catch (Exception ex) {
				correcta = false;
			}
			if (!correcta) {
				
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
				
			}
			Gtk.TreeViewColumn cantidad_column = new Gtk.TreeViewColumn ();
			cantidad_column.Title = "Cantidad";
			Gtk.CellRendererText cantidad_cell = new Gtk.CellRendererText ();
			cantidad_column.PackStart (cantidad_cell, true);
			
			Gtk.TreeViewColumn precio_column = new Gtk.TreeViewColumn ();
			precio_column.Title = "Precio";
			Gtk.CellRendererText precio_cell = new Gtk.CellRendererText ();
			precio_column.PackStart (precio_cell, true);
			
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn ();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText ();
			nombre_column.PackStart (nombre_cell, true);
			
			this.treeviewListaProductos.AppendColumn (cantidad_column);
			cantidad_column.AddAttribute (cantidad_cell, "text", 0);
			this.treeviewListaProductos.AppendColumn (nombre_column);
			nombre_column.AddAttribute (nombre_cell, "text", 1);
			this.treeviewListaProductos.AppendColumn (precio_column);
			precio_column.AddAttribute (precio_cell, "text", 2);
#if DEBUG
			
			Console.WriteLine(this.db.ObtenerBoleta());
#endif	
			
			double temp = Convert.ToDouble (this.db.ObtenerBoleta ());
			temp = temp + 1;
			Console.WriteLine ("temp");
			Console.WriteLine (temp);
			boleta = temp.ToString ();
			Console.WriteLine (boleta);
			
			entryNumBoleta.Text = boleta;
			Console.WriteLine (entryNumBoleta.Text);
			
			this.treeviewListaProductos.Selection.Changed += TreeView2SelectionChanged;
			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
			labelTotalVenta.ModifyFont (Pango.FontDescription.FromString ("Courier bold 32"));
			
		}
		
		public void Destroy ()
		{
#if DEBUG
			Console.WriteLine("Destroy");
#endif
			GLib.ExceptionManager.UnhandledException -= ExcepcionDesconocida;
			//	EdicionDialogChangedEventArgs args = new EdicionDialogChangedEventArgs(this.cambiado);
			
			base.Destroy ();
		}
		
		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{
#if DEBUG
			Console.WriteLine(e.ToString());
#endif
			Dialog dialog = new Dialog ("OK", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label ();
			etiqueta.Markup = "Se ha cargado con exito.";
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart (etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll ();
			
			dialog.Run ();
			dialog.Destroy ();
			
			
		}
	
		
		public void CargarProductos ()
		{
			productoventa.Add (this.db.ObtenerProductosVenta ((entryCodigoBarra.Text.Trim ())));
			foreach (Produc i in productoventa) {
				int contador = 0;
				String x = i.getCodigo ();
				String nom = i.getNombre ();
				String prec = i.getPrecio ();
				foreach (Produc j in productoventa) {
					if (x.Equals (j.getCodigo ())) {
						contador++;
						//ventamodel.AppendValues(contador, j.getNombre(), j.getPrecio());
					}
					listapago.Add (new Produc (x, nom, prec, contador));
					Console.WriteLine ((x + " se repite " + contador));
				}
			}
			treeviewListaProductos.Model = this.ventamodel;


			/*
			if (bod.Nombre == item) {
				cantidad = cantidad + 1;
				Console.WriteLine(ventamodel.GetValue (tmpIter, 0));

				ventamodel.SetValue (tmpIter, 0, cantidad);
				ventamodel.Remove (ref tmpIter);
			} 
			preciototal = preciototal + Int32.Parse (bod.Precio);
			labelTotalVenta.Text = preciototal.ToString ();
			while (ventamodel.IterNext(ref tmpIter)) {
				item = (string)ventamodel.GetValue (tmpIter, 1); // los demás elementos
				if (bod.Nombre == item) {

					cantidad = cantidad + 1;
					ventamodel.SetValue (tmpIter, 0, cantidad);
					ventamodel.Remove (ref tmpIter);

				} else {
					ventamodel.GetValue(tmpIter,0);
					ventamodel.SetValue (tmpIter ,0,cantidad);

				}
			}
			ventamodel.AppendValues (cantidad, bod.Nombre, bod.Precio);
			treeviewListaProductos.Model = this.ventamodel;
*/
		}

		protected void TreeView2SelectionChanged (object sender, EventArgs args)
		{	
			Gtk.TreeIter iter;
			TreeModel model;
			if (this.treeviewListaProductos.Selection.GetSelected (out model, out iter)) {
				//model.SetValue(iter, 0, 1);
				//model.SetValue(iter, 1, "New Value");
				
				//this.entry1.Text = this.ventamodel.GetValue(iter, 0).ToString();
				
			} else {
			}
		}
		//The event-invoking method that derived classes can override.
		/*	protected virtual void OnEdicionDialogChanged(EdicionDialogChangedEventArgs e)
		{

			EventHandler<EdicionDialogChangedEventArgs> handler = EdicionDialogChanged;
			if (handler != null)
			{
				
				handler(this, e);
			}
		}
	*/
		public void  Run ()
		{
			base.Run ();
			Console.WriteLine ("entra aqui");
			
		}
		
		protected void OnButton85Clicked (object sender, EventArgs e)
		{
			entryNumBoleta.IsEditable = true;
		}
		
		protected void OnEntry2TextInserted (object o, TextInsertedArgs args)
		{
			//que hace si apreta guardar boleta
			boleta = entryNumBoleta.Text;
		}
		
		void ScrollToItem (TreeIter iter)
		{
			TreePath path = ventamodel.GetPath (iter);
			if (path != null) {
				treeviewListaProductos.ScrollToCell (path, null, false, 0, 0);
			}
		}
		
		protected void OnButton1260Clicked (object sender, EventArgs e)
		{
			treeviewListaProductos.Data.Clear ();
			ventamodel.Clear ();
		}
		
		protected void OnButtonVentaClicked (object sender, EventArgs e)
		{
			
			
			ventamodel.Clear ();
			double temp = Convert.ToDouble (this.db.ObtenerBoleta ());
			temp = temp + 1;
			Console.WriteLine ("temp");
			Console.WriteLine (temp);
			boleta = temp.ToString ();
			Console.WriteLine (boleta);
			
			entryNumBoleta.Text = boleta;
			Console.WriteLine (entryNumBoleta.Text);
			//		Venta pago = new Venta(Int32.Parse(entryNumBoleta.Text.Trim()),DateTime.Now,Int32.Parse(labelTotalVenta.Text.Trim()));
			Console.WriteLine (DateTime.Now);
			Console.WriteLine (Int32.Parse (entryNumBoleta.Text.Trim ()));
			
			
			
			
			//		this.db.AgregarVentaDetalle(pago);
			
			
			PagarDialog rcd = new PagarDialog (this, labelTotalVenta.Text.Trim (), entryNumBoleta.Text.Trim (), usuarioLogin, productoventa);
			try {
				rcd.Run ();
				rcd.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				rcd.Destroy ();
#if DEBUG
				
				
				Console.WriteLine("entra al OnEntry1KeyPressEvent ");
#endif
			}
			labelTotalVenta.Text = "0";
			preciototal = 0;
		}
		[GLib.ConnectBefore ()] 

		protected void OnEntryCodigoBarraKeyPressEvent (object o, Gtk.KeyPressEventArgs args)
		{
			Console.WriteLine ("entra al OnEntry1KeyPressEvent1 de OnEntryCodigoBarraKeyPressEvent ");
			Console.WriteLine("DEBUG: KeyValue: " + args.Event.KeyValue);

			if ( args.Event.Key ==Gdk.Key.Return) {
				productoventa.Add (this.db.ObtenerProductosVenta ((entryCodigoBarra.Text.Trim ())));
				foreach (Produc i in productoventa) {
					int contador = 0;
					String x = i.getCodigo ();
					String nom = i.getNombre ();
					String prec = i.getPrecio ();
					if (!x.Equals ("")) {
						foreach (Produc j in productoventa) {
							if (x.Equals (j.getCodigo ())) {
								contador++;
								//ventamodel.AppendValues(contador, j.getNombre(), j.getPrecio());
							}
						}
						listapago.Add (new Produc (x, nom, prec, contador));
						//Console.WriteLine (listapago.LastIndexOf(1));
						
					}
				}
				treeviewListaProductos.Model = this.ventamodel;
				int valor=0;
				String nombre="" ;
				String precio="" ;
				foreach (Produc k in listapago) {
					valor= Math.Max(0,k.getCantidad());
					nombre=k.getNombre();
					precio=k.getPrecio();
					
				}
				Console.WriteLine (valor);
				
				//ventamodel.AppendValues(valor,nombre, precio);
				
				Produc bod = this.productoventa.ToArray () [productoventa.Count - 1];
				TreeIter tmpIter = new TreeIter ();
				ventamodel.GetIterFirst (out tmpIter);
				
				string item = (string)ventamodel.GetValue (tmpIter, 1); // este es el primer elemento
				
				if (bod.Nombre == item) {
					cantidad = cantidad + 1;
					Console.WriteLine(ventamodel.GetValue (tmpIter, 0));
					
					ventamodel.SetValue (tmpIter, 0, cantidad);
					ventamodel.Remove (ref tmpIter);
				} 
				preciototal = preciototal + Int32.Parse (bod.Precio);
				labelTotalVenta.Text = preciototal.ToString ();
				while (ventamodel.IterNext(ref tmpIter)) {
					item = (string)ventamodel.GetValue (tmpIter, 1); // los demás elementos
					if (bod.Nombre == item) {
						cantidad = cantidad + 1;
						ventamodel.SetValue (tmpIter, 0, cantidad);
						ventamodel.Remove (ref tmpIter);
						
					} else {
						ventamodel.GetValue(tmpIter,0);
						ventamodel.SetValue (tmpIter ,0,cantidad);
						
					}
				}
				ventamodel.AppendValues(valor,nombre, precio);
				
				
				entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);


		}
		}

		private void OnQuitarProductoDialogResponse (object sender, ResponseArgs args)
		{
			switch (args.ResponseId) {
			case ResponseType.Accept:
				Gtk.TreeIter iter;
				
				this.treeviewListaProductos.Selection.GetSelected (out iter);
				string precioIter = (ventamodel.GetValue (iter, 2)).ToString ();
				int valorlabel = Int32.Parse (labelTotalVenta.Text);
				string total = (valorlabel - Int32.Parse (precioIter)).ToString ();
				labelTotalVenta.Text = total;
				
				ventamodel.Remove (ref iter);
				
				break;
			default:
				//no hacer nada
				break;
			}
		}
		
		protected void OnTreeviewListaProductosKeyPressEvent (object o, KeyPressEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.F12) {
				Gtk.TreeIter iter;
				if (this.treeviewListaProductos.Selection.GetSelected (out iter)) {
					Dialog dialog = new Dialog ("Quitar Producto De la lista", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label ();
					etiqueta.Markup = "Está intentando quitar el producto seleccionado de la lista.\n\n<b>¿Desea continuar con la eliminación del producto?</b>\n";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart (etiqueta, false, false, 0);
					dialog.AddButton ("Si", ResponseType.Accept);
					dialog.AddButton ("No", ResponseType.Cancel);
					dialog.Response += new ResponseHandler (OnQuitarProductoDialogResponse);
					dialog.ShowAll ();
					dialog.Run ();
					dialog.Destroy ();
				}
				
			}	
			
		}

		protected void OnCerrarActionActivated (object sender, EventArgs e)
		{
			this.Destroy ();
			
			IniciarSesionDialog IniciarSesion = new IniciarSesionDialog ();
			
			try {
				IniciarSesion.Run ();
				IniciarSesion.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				IniciarSesion.Destroy ();
				
				
			}
		}
		
		protected void OnIngresarEditarProductosActionActivated (object sender, EventArgs e)
		{
			IngresarProductosDialog IngresarProductos = new IngresarProductosDialog (this);
			try {
				IngresarProductos.Run ();
				IngresarProductos.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				IngresarProductos.Destroy ();
#if DEBUG
				
				
				Console.WriteLine(ex.Message);
#endif
				
			}
		}
		
		protected void OnFamiliaProductosActionActivated (object sender, EventArgs e)
		{
			familiaproductosdialog FamiliaProductos = new familiaproductosdialog (this);
			try {
				FamiliaProductos.Run ();
				FamiliaProductos.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				FamiliaProductos.Destroy ();
#if DEBUG
				
				Console.WriteLine(ex.Message);
#endif
			}
		}
		
		protected void OnRegistrarEditarUsuarioActionActivated (object sender, EventArgs e)
		{
			RegistrarUsuarioDialog RegistrarUsuario = new RegistrarUsuarioDialog ();
			
			try {
				RegistrarUsuario.Run ();
				RegistrarUsuario.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				RegistrarUsuario.Destroy ();
				
				
			}
		}
		
		
		
		
		protected void OnEntryCodigoBarraRealized (object sender, EventArgs e)
		{
			throw new System.NotImplementedException ();
		}


	}
	
}