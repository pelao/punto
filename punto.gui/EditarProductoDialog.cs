
using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	
	public partial class EditarProductoDialogChangedEventArgs : EventArgs
	{
		
		private string nombre;
		private string precio;
		private string familia;
		
		public EditarProductoDialogChangedEventArgs(string cant, string d,string fam)
		{
			nombre = cant.Trim();
			precio = d.Trim();
			familia = fam.Trim();
		}
		
		public string Nombre
		{
			get { return nombre; }
		}
		
		public string Precio
		{
			get { return precio; }
		}
		public string Familia
		{
			get { return familia; }
		}
		
		
	}
	
	public partial class EditarProductoDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		public List<FamiliaProducto> fam= new List<FamiliaProducto>();
		
		private Gtk.ListStore ventamodel;
		
		public event EventHandler<EditarProductoDialogChangedEventArgs> EditarProductoDialogdChanged;
		string familiaActual="";
		
		public EditarProductoDialog (Gtk.Window parent, string nombre, string precio,string familia) : base ("Editar producto", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			this.db = new ControladorBaseDatos();

	
				entryNombre.Text = nombre.Trim();

	
				entryPrecio.Text = precio.Trim();
	
	
			//	entryFamilia.Text = familia.Trim();
				//familiaActual=entryFamilia.Text.Trim();
			//comboboxFamilia.ActiveText=familia.Trim();
			//ventamodel.AppendValues(comboboxFamilia.ActiveText);
			comboboxFamilia.AppendText(familia.Trim());
			comboboxFamilia.Active =0;

		}
		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}
		
		protected void OnCambiarfamilabuttonClicked (object sender, EventArgs e)
		{			
		//	this.entryFamilia.Hide();
			this.comboboxFamilia.Show();
			this.CargarTiposFamiliaComboboxa();
		}

		protected virtual void OnEditarProductoDialogChanged(EditarProductoDialogChangedEventArgs e)
		{

			EventHandler<EditarProductoDialogChangedEventArgs> handler = EditarProductoDialogdChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		
	
		public void CargarTiposFamiliaComboboxa ()
		{
			
			List<FamiliaProducto> tipos = this.db.ObtenerFamiliasBd ();
			comboboxFamilia.Clear();
			CellRendererText cell = new CellRendererText ();
			comboboxFamilia.PackStart (cell, false);
			comboboxFamilia.AddAttribute (cell, "text", 0);
			this.ventamodel = new Gtk.ListStore (typeof(string));
			comboboxFamilia.Model = ventamodel;
			foreach (FamiliaProducto tp in tipos) {
				this.ventamodel.AppendValues (tp.Nombre);
				
			}
			vigentecheckbutton.Active = true;
			
			if (tipos.Count != 0) {
				this.comboboxFamilia.Active = 0;
			}
		}
		
		protected void OnButton3128Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}
		protected void OnButtonOkClicked (object sender, EventArgs e)
		{

			string nombre = "", precio = "", familia = "";

			nombre = entryNombre.Text.Trim ();

			precio = entryPrecio.Text.Trim ();
		
		//	familia = entryFamilia.Text.Trim ();
		 familia=comboboxFamilia.ActiveText;
			//ventamodel.AppendValues(comboboxFamilia.ActiveText);
	

			EditarProductoDialogChangedEventArgs args = new EditarProductoDialogChangedEventArgs(nombre,precio,familia);
			this.OnEditarProductoDialogChanged(args);
			this.Destroy();
						
		}
	}
}

