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
		public ControladorBaseDatos db;
		private string usuario_;
		private string nivelUsuario;


		public event EventHandler TimeChanged;
		public int CurrentTime;
		

		
		public List<Produc> productoventa = new List<Produc>();
		private Gtk.ListStore ventamodel;
		
		public List<Produc> listapago = new List<Produc>();
		private Gtk.ListStore listaventa;
		
		
		public event EventHandler<EdicionDialogChangedEventArgs> EdicionDialogChanged;
		private bool cambiado = false;
		public	int preciototal=0;
		private string boleta;
		public int contador=0;
		public string usuarioLogin;
		
		public PrincipalWindow (string usuario) : base(Gtk.WindowType.Toplevel)
		{
			this.usuario_ = usuario;

#if DEBUG
			Console.WriteLine ("En debug");
#endif      
		
			
		
			this.Build ();
			ControladorBaseDatos db = new ControladorBaseDatos ();
			nivelUsuario = db.ObtenerNivelUsuarioBd(usuario_);

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
			Gtk.TreeViewColumn cantidad_column = new Gtk.TreeViewColumn();
			cantidad_column.Title = "Cantidad";
			Gtk.CellRendererText cantidad_cell = new Gtk.CellRendererText();
			cantidad_column.PackStart(cantidad_cell, true);
			
			Gtk.TreeViewColumn precio_column = new Gtk.TreeViewColumn();
			precio_column.Title = "Precio";
			Gtk.CellRendererText precio_cell = new Gtk.CellRendererText();
			precio_column.PackStart(precio_cell, true);
			
			Gtk.TreeViewColumn nombre_column = new Gtk.TreeViewColumn();
			nombre_column.Title = "Nombre";
			Gtk.CellRendererText nombre_cell = new Gtk.CellRendererText();
			nombre_column.PackStart(nombre_cell, true);
			
			this.treeviewListaProductos.AppendColumn(cantidad_column);
			cantidad_column.AddAttribute(cantidad_cell, "text", 0);
			this.treeviewListaProductos.AppendColumn(nombre_column);
			nombre_column.AddAttribute(nombre_cell, "text", 1);
			this.treeviewListaProductos.AppendColumn(precio_column);
			precio_column.AddAttribute(precio_cell, "text", 2);

#if DEBUG
			
			Console.WriteLine(this.db.ObtenerBoleta());
#endif	
			
			double temp=Convert.ToDouble( this.db.ObtenerBoleta());
			temp=temp+1;
			Console.WriteLine("temp");
			Console.WriteLine(temp);
			boleta=temp.ToString();
			Console.WriteLine(boleta);
			
			entryNumBoleta.Text=boleta;
			Console.WriteLine(entryNumBoleta.Text);
			
			this.treeviewListaProductos.Selection.Changed += TreeView2SelectionChanged;
			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
			labelTotalVenta.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
			
		}


	
		public void CargarProductos ()
		{
			productoventa= this.db.ObtenerProductosVenta((entryCodigoBarra.Text.Trim()));
			treeviewListaProductos.Model = this.ventamodel;
			int cantidad=0;
			foreach (Produc bod in this.productoventa)
			{
				
				TreeIter tmpIter = new TreeIter();
				ventamodel.GetIterFirst(out tmpIter);
				string item = (string) ventamodel.GetValue(tmpIter,1); // este es el primer elemento
				
				if(item==null){
					Console.WriteLine("ventamodelvacio");
					ventamodel.AppendValues( 1,bod.Nombre, bod.Precio);
					preciototal=preciototal+Int32.Parse(bod.Precio);
					entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);
					
					Console.WriteLine(preciototal);
					labelTotalVenta.Text=preciototal.ToString();
					
					
					cantidad=1;
				}
				else{
					ventamodel.GetIterFirst(out tmpIter);
					string itema = (string) ventamodel.GetValue(tmpIter,1); // este es el primer elemento
					if (bod.Nombre==itema){
						cantidad=cantidad+1;
					}
					ventamodel.AppendValues(cantidad,bod.Nombre,bod.Precio);
					entryCodigoBarra.DeleteText(0, entryCodigoBarra.Text.Length);
					
					preciototal=preciototal+Int32.Parse(bod.Precio);
					Console.WriteLine(preciototal);
					labelTotalVenta.Text=preciototal.ToString();
					while(ventamodel.IterNext(ref tmpIter)  ) {
						TreeIter tmpIter1 = new TreeIter();
						
						item = (string) ventamodel.GetValue(tmpIter,1); // los demás elementos
						
						if(bod.Nombre==item){
							
							cantidad=cantidad+1;
							ventamodel.SetValue(tmpIter,0,cantidad);
							
							
						}else{
							Console.WriteLine("entra aqui");		
							
						}
						
					}
				}
				
			}
			
			
			this.treeviewListaProductos.Selection.UnselectAll();
			
			
		}


		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{
#if DEBUG
			Console.WriteLine("excepcion:--->"+e.ToString());
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
		
		
		protected void OnIngresarEditarProductosActionActivated (object sender, EventArgs e)
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

		protected void TreeView2SelectionChanged (object sender, EventArgs args)
		{	
			Gtk.TreeIter iter;
			TreeModel model;
			if (this.treeviewListaProductos.Selection.GetSelected(out model, out iter))
			{
				//model.SetValue(iter, 0, 1);
				//model.SetValue(iter, 1, "New Value");
				
				//this.entry1.Text = this.ventamodel.GetValue(iter, 0).ToString();
				
			}
			else
			{
			}
		}
		
		protected void OnFamiliaProductosActionActivated (object sender, EventArgs e)
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
		protected void OnButtonVentaClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos();
			ventamodel.Clear();
			double temp=Convert.ToDouble(db.ObtenerBoleta());
			temp=temp+1;
			Console.WriteLine("temp");
			Console.WriteLine(temp);
			boleta=temp.ToString();
			Console.WriteLine(boleta);
			
			entryNumBoleta.Text=boleta;
			Console.WriteLine(entryNumBoleta.Text);
			//		Venta pago = new Venta(Int32.Parse(entryNumBoleta.Text.Trim()),DateTime.Now,Int32.Parse(labelTotalVenta.Text.Trim()));
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(Int32.Parse(entryNumBoleta.Text.Trim()));
			
			
			
			
			//		this.db.AgregarVentaDetalle(pago);
			
			
			PagarDialog rcd = new PagarDialog(this,labelTotalVenta.Text.Trim(),entryNumBoleta.Text.Trim(),usuarioLogin, productoventa);
			try 
			{
				rcd.Run();
				rcd.Destroy();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				rcd.Destroy();
#if DEBUG
				
				
				Console.WriteLine("entra al OnEntry1KeyPressEvent ");
#endif
			}
			labelTotalVenta.Text="0";
			preciototal=0;	
			
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

		protected void OnRegistrarEditarUsuarioActionActivated (object sender, EventArgs e)
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


	}
}
