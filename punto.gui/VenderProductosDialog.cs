using System.Collections;
using System;
using System.Collections.Generic;
using Gtk;
using punto.code;
using GLib;
using System.IO;

namespace punto.gui
{
	public partial class VenderProductosDialog : Gtk.Dialog
	{
	
		private ControladorBaseDatos db;
		public List<Produc> productoventa = new List<Produc> ();
		public List<Produc> productos = new List<Produc> ();
		private Gtk.ListStore ventamodel;
		public List<Produc> listapago = new List<Produc> ();

		
	
		public	int preciototal = 0;
		private string boleta;
		public int cantidad = 1 ;
		public string usuarioLogin;
		private string nivelUsuario;
		
		public VenderProductosDialog (string usuario)
		{
			this.usuarioLogin = usuario;
			this.ventamodel = new Gtk.ListStore (typeof(int), typeof(string), typeof(string));

			this.Build ();
			this.db = new ControladorBaseDatos ();
			bool correcta = false;

			nivelUsuario = db.ObtenerNivelUsuarioBd(usuarioLogin);
			
			if(nivelUsuario.Equals("Cajero"))
			{
				ProductosAction.Visible = false;
				UsuarioAction.Visible = false;
			}

			labelNombreCajero.Text = usuarioLogin.ToString();
			labelFecha.ModifyFont (Pango.FontDescription.FromString ("Courier bold 15"));
			labelFecha.Text = "Fecha: "+DateTime.Now.ToShortDateString();



			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			} catch (Exception ex) {
				correcta = false;
			}
			if (!correcta) {
				

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
		//	cantidad_column.Width{};
			Gtk.TreeViewColumn precio_column = new Gtk.TreeViewColumn ();
			precio_column.Title = "Precio";
			Gtk.CellRendererText precio_cell = new Gtk.CellRendererText ();
			precio_column.PackStart (precio_cell, true);
			
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn ();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText ();
			nombre_column.PackStart (nombre_cell, true);
			
			this.treeviewListaProductos.AppendColumn (cantidad_column);
			cantidad_column.Title = "Cantidad";

			cantidad_column.AddAttribute (cantidad_cell, "text", 0);
			this.treeviewListaProductos.AppendColumn (nombre_column);
			nombre_column.AddAttribute (nombre_cell, "text", 1);
			precio_column.Title = "Precio";

			this.treeviewListaProductos.AppendColumn (precio_column);
			precio_column.AddAttribute (precio_cell, "text", 2);
			nombre_column.Title = "Nombre";

#if DEBUG
			
			Console.WriteLine(this.db.ObtenerBoleta());
#endif	
			
			double temp = Convert.ToDouble (this.db.ObtenerBoleta ());
			temp = temp + 1;
			Console.WriteLine ("temp");
			Console.WriteLine (temp);
			boleta = temp.ToString ();
			Console.WriteLine (boleta);
			
		
			
		//	this.treeviewListaProductos.Selection.Changed += TreeView2SelectionChanged;
			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
			labelTotalVenta.ModifyFont (Pango.FontDescription.FromString ("Courier bold 32"));
			
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
			
			//		Venta pago = new Venta(Int32.Parse(entryNumBoleta.Text.Trim()),DateTime.Now,Int32.Parse(labelTotalVenta.Text.Trim()));
			Console.WriteLine (DateTime.Now);

			
			
			
			//		this.db.AgregarVentaDetalle(pago);
			
			
			PagarDialog rcd = new PagarDialog (this, labelTotalVenta.Text.Trim (), usuarioLogin, productoventa);
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
			string codigoBarra = "";
			string asterisco = "";
			string recoPesa ="";
			string tipoProd ="";
			string cant = "";
			string precioprod = "";
			string codigobarracorto="";
			Console.WriteLine ("entra al OnEntry1KeyPressEvent1 de OnEntryCodigoBarraKeyPressEvent ");
			Console.WriteLine("DEBUG: KeyValue: " + args.Event.KeyValue);

			if ( args.Event.Key ==Gdk.Key.Return) {

				// caso 1: se ingresa la cantidad de productos
				// luego un * y seguido el codigo de barra
				// del producto, la cantidad sera el numero
				// que antecede al signo *

				int posAsterisco = 0;
					if(Int32.Parse(entryCodigoBarra.Text.Trim().Substring(0,1))==2 &&
				  		 entryCodigoBarra.Text.Trim().Substring(0,2)!="2*"){
						
						codigoBarra = entryCodigoBarra.Text.Trim ();
						
						
						recoPesa=codigoBarra.Substring(0,2);
						Console.WriteLine("codigoPesa: "+recoPesa);
						codigobarracorto=codigoBarra.Substring(0,7);
						Console.WriteLine("codigobarracorto: "+codigobarracorto);
						precioprod=Int32.Parse(codigoBarra.Substring(7,5))+"";
					//	Console.WriteLine("precioEntero: "+precioEntero);

						// caso2: se listan los productos con cantidad 1
					Produc n_prod = this.db.ObtenerProductosVenta (codigobarracorto);
			
						n_prod.setCantidad(1);
						productoventa.Add (n_prod);
						Console.WriteLine("lista:"+productoventa.Count);
						foreach (Produc i in productoventa) {/*se recorre esta lista con un foreach*/
							int contador = 0;
							String x = i.getCodigo ();
							String nom = i.getNombre ();/*se guarda un registro para luego hacer la comparacion*/
						String prec = precioprod ;
						listapago.Add (new Produc (x, nom, precioprod, contador)); /*se agrega a otra lista el codigo de barra,nombre,precio,cantidad de productos*/
							
						}
						
						treeviewListaProductos.Model = this.ventamodel;
						int valor=1;
						String nombre="" ;
						String precio="" ;
						foreach (Produc k in listapago) {
							valor= 1;
							nombre=k.getNombre();
							precio=precioprod;
							
						}
						
						Produc prod = this.productoventa.ToArray () [productoventa.Count - 1];
						TreeIter tmpIter = new TreeIter ();
						ventamodel.GetIterFirst (out tmpIter);
						
						string item = (string)ventamodel.GetValue (tmpIter, 1);
						
						
					preciototal = preciototal + Int32.Parse (precioprod);
						labelTotalVenta.Text = preciototal.ToString ();
						
					ventamodel.AppendValues(prod.getCantidad(),prod.getNombre(), precioprod);
						entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);
						
						
						
						


				}else{
				if((entryCodigoBarra.Text.Trim().Length > 13 ||
				   entryCodigoBarra.Text.Trim().Length == 10 ||
				   entryCodigoBarra.Text.Trim().Length == 11)){
					//y falta para que si se ingresa
					codigoBarra = entryCodigoBarra.Text.Trim ();
					
					posAsterisco = codigoBarra.IndexOf('*');
					asterisco = codigoBarra.Substring(posAsterisco,posAsterisco);
					cant = codigoBarra.Substring (0,posAsterisco);
					if(cant.Length < 1)
					{
						cant = "1";
					}
					Console.WriteLine("Cantidad: "+cant);
					Console.WriteLine("posAsterisco: "+posAsterisco);
					Console.WriteLine("asterisco: "+asterisco);
					Console.WriteLine("Largo codigo barra: "+codigoBarra.Length);
					Console.WriteLine("Codigo Barra: "+codigoBarra.Substring(posAsterisco+1,(entryCodigoBarra.Text.Trim().Length-(cant.Length+1)) ));
					Console.WriteLine("largo desconocido"+posAsterisco+codigoBarra.Length);
					Console.WriteLine("resultado"+(entryCodigoBarra.Text.Trim().Length-(cant.Length+1)));
					
					Produc n_prod = this.db.ObtenerProductosVenta ((codigoBarra.Substring(posAsterisco+1,(entryCodigoBarra.Text.Trim().Length-(cant.Length+1)))));
					n_prod.setCantidad( Int32.Parse(cant));
					productoventa.Add (n_prod);

					//**************

					Console.WriteLine("lista:"+productoventa.Count);
					foreach (Produc i in productoventa) {/*se recorre esta lista con un foreach*/
						int contador = 0;
						String x = i.getCodigo ();
						String nom = i.getNombre ();/*se guarda un registro para luego hacer la comparacion*/
						String prec = i.getPrecio ();
			
						listapago.Add (new Produc (x, nom, prec, contador)); /*se agrega a otra lista el codigo de barra,nombre,precio,cantidad de productos*/
					}
					
					treeviewListaProductos.Model = this.ventamodel;
					// valor es la cantidad de producto que lleva el cliente
					int valor=0;
					String nombre="" ;
					String precio="" ;
					valor= Int32.Parse(cant);
					foreach (Produc k in listapago) {
						//= Int32.Parse(cant);
						nombre=k.getNombre();
						precio=k.getPrecio();
						
					}
					Console.WriteLine (valor);

					Produc prod = this.productoventa.ToArray () [productoventa.Count - 1];
					TreeIter tmpIter = new TreeIter ();
					ventamodel.GetIterFirst (out tmpIter);
					
					string item = (string)ventamodel.GetValue (tmpIter, 1); 
	

					preciototal = preciototal + (Int32.Parse (prod.Precio)*prod.getCantidad());
					labelTotalVenta.Text = preciototal.ToString ();
					ventamodel.AppendValues(prod.getCantidad(),prod.getNombre(), prod.getPrecio());
					entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);


					//**************


				}
				else{

					// caso2: se listan los productos con cantidad 1
					Produc n_prod = this.db.ObtenerProductosVenta (entryCodigoBarra.Text.Trim ());
					n_prod.setCantidad(1);
					productoventa.Add (n_prod);
					Console.WriteLine("lista:"+productoventa.Count);
					foreach (Produc i in productoventa) {/*se recorre esta lista con un foreach*/
						int contador = 0;
						String x = i.getCodigo ();
						String nom = i.getNombre ();/*se guarda un registro para luego hacer la comparacion*/
						String prec = i.getPrecio ();
						listapago.Add (new Produc (x, nom, prec, contador)); /*se agrega a otra lista el codigo de barra,nombre,precio,cantidad de productos*/
						
					}
					
					treeviewListaProductos.Model = this.ventamodel;
					int valor=1;
					String nombre="" ;
					String precio="" ;
					foreach (Produc k in listapago) {
						valor= 1;
						nombre=k.getNombre();
						precio=k.getPrecio();
						
					}
					
					Produc prod = this.productoventa.ToArray () [productoventa.Count - 1];
					TreeIter tmpIter = new TreeIter ();
					ventamodel.GetIterFirst (out tmpIter);
					
					string item = (string)ventamodel.GetValue (tmpIter, 1);
					
		
					preciototal = preciototal + Int32.Parse (prod.Precio);
					labelTotalVenta.Text = preciototal.ToString ();
			
					ventamodel.AppendValues(prod.getCantidad(),prod.getNombre(), prod.getPrecio());
					entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);


				}

				}

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


		protected void OnLabelHoraEvent (object o, WidgetEventArgs args)
		{
			labelHora.ModifyFont (Pango.FontDescription.FromString ("Courier bold 20"));
			labelHora.Text = "Hora: "+DateTime.Now.ToLongTimeString();

		}


		protected void OnLabelHora (object sender, EventArgs e)
		{
			labelHora.ModifyFont (Pango.FontDescription.FromString ("Courier bold 20"));
			labelHora.Text = "Hora: "+DateTime.Now.ToLongTimeString();
		}

	
		protected void OnEditarNmeroBoletaActionActivated (object sender, EventArgs e)
		{
			EditarNumBoletaDialog numeroBoleta = new EditarNumBoletaDialog (usuarioLogin);
			try {
				numeroBoleta.Run ();
				numeroBoleta.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				numeroBoleta.Destroy ();
	
				Console.WriteLine(ex.Message);

				
			}		
		}
	
		protected void OnGenerarReportesActionActivated (object sender, EventArgs e)
		{
			GenerarReportesDialog reporte = new GenerarReportesDialog ();
			try {
				reporte.Run ();
				reporte.Destroy ();
			} catch (MySql.Data.MySqlClient.MySqlException ex) {
				reporte.Destroy ();
				
				Console.WriteLine(ex.Message);
				
				
			}
		}

	
		protected void OnAnularBoletaActionActivated (object sender, EventArgs e){
			AnularBoletaDialog asd = new AnularBoletaDialog ();
		try {
			asd.Run ();
			asd.Destroy ();
		} catch (MySql.Data.MySqlClient.MySqlException ex) {
			asd.Destroy ();
			
			Console.WriteLine(ex.Message);
			
			
		}		}

	}
	
}